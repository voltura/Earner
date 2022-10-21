using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earner
{
    internal record EarnerRecord
    {
        public string Task { get; set; } = string.Empty;
        public double Earned { get; set; } = 0.0d;
        public List<TimeSpan> Times { get; set; } = new List<TimeSpan>();
    }
}
