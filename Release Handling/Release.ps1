[CmdletBinding()]
param([switch]$Publish, [string]$NotesFile)
$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path $PSScriptRoot -Parent
function Invoke-Checked([string]$Command, [string[]]$Arguments) {
    & $Command @Arguments
    if ($LASTEXITCODE -ne 0) { throw "$Command failed with exit code $LASTEXITCODE" }
}
Push-Location $repoRoot
try {
    [xml]$project = Get-Content EarnerApp/Earner.csproj
    $version = @($project.Project.PropertyGroup.Version | Where-Object { $_ })[0]
    $tag = "v$version"
    if ($Publish) {
        if (!(Test-Path -LiteralPath $NotesFile -PathType Leaf)) { throw 'Publishing requires -NotesFile.' }
        $changes = & git status --porcelain
        if ($LASTEXITCODE -ne 0 -or $changes) { throw 'Commit and push the verified release before publishing.' }
        $head = & git rev-parse HEAD
        $remote = & git ls-remote origin refs/heads/master
        if ($LASTEXITCODE -ne 0 -or !($remote -match "^$head\s")) { throw 'HEAD must match remote master.' }
    }
    $releaseDir = Join-Path $repoRoot "Releases/$version"
    if (Test-Path -LiteralPath $releaseDir) { throw "Release output already exists: $releaseDir" }
    New-Item -ItemType Directory -Path $releaseDir | Out-Null
    Invoke-Checked dotnet @('run', '--project', 'tests/ExportSmoke/ExportSmoke.csproj', '-c', 'Release')
    Invoke-Checked dotnet @('publish', 'EarnerApp/Earner.csproj', '-c', 'Release', '-p:Platform=x64', '-r', 'win-x64', '--self-contained', 'true', '-p:PublishSingleFile=true', '-o', $releaseDir)
    $exe = Join-Path $releaseDir 'Earner.exe'
    if ((Get-Item $exe).VersionInfo.FileVersion -ne $version) { throw 'Published executable version mismatch.' }
    # Preserve the updater's existing five-asset format. MD5 files are compatibility checksums.
    $exeMd5 = (Get-FileHash $exe -Algorithm MD5).Hash.ToLowerInvariant()
    "$exeMd5  Earner.exe`r`n" | Set-Content (Join-Path $releaseDir 'Earner.exe.MD5') -Encoding ascii
    Compress-Archive -LiteralPath $exe,(Join-Path $releaseDir 'Earner.exe.MD5') -DestinationPath (Join-Path $releaseDir 'Earner.zip')
    $zipMd5 = (Get-FileHash (Join-Path $releaseDir 'Earner.zip') -Algorithm MD5).Hash.ToLowerInvariant()
    "$zipMd5  Earner.zip`r`n" | Set-Content (Join-Path $releaseDir 'Earner.zip.MD5') -Encoding ascii
    "$version Earner.zip" | Set-Content (Join-Path $releaseDir 'VERSION.TXT') -Encoding ascii
    if ($Publish) {
        $assets = @('Earner.exe','Earner.exe.MD5','Earner.zip','Earner.zip.MD5','VERSION.TXT')
        $assetPaths = @($assets | ForEach-Object { Join-Path $releaseDir $_ })
        Invoke-Checked gh (@('release','create',$tag,'--repo','voltura/Earner','--target',$head,'--title',"Earner $version",'--notes-file',$NotesFile,'--draft') + $assetPaths)
        $downloadDir = Join-Path $releaseDir 'verification'
        New-Item -ItemType Directory $downloadDir | Out-Null
        Invoke-Checked gh @('release','download',$tag,'--repo','voltura/Earner','--dir',$downloadDir)
        foreach ($asset in $assets) {
            if ((Get-FileHash (Join-Path $releaseDir $asset)).Hash -ne (Get-FileHash (Join-Path $downloadDir $asset)).Hash) { throw "Uploaded asset mismatch: $asset" }
        }
        Invoke-Checked gh @('release','edit',$tag,'--repo','voltura/Earner','--draft=false','--latest')
    }
    Write-Output "Release artifacts: $releaseDir"
} finally { Pop-Location }
