using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class MoviePerformanceRevenue
    {
        public string movieName { get; set; }
        public Decimal revenue { get; set; }
        public string performance { get; set; }
        public int firstWeekRevenue { get; set; }
        public int secondWeekRevenue { get; set; }
        public MoviePerformanceRevenue() { }
        public MoviePerformanceRevenue(string movieName, Decimal revenue, string performance, int firstWeekRevenue, int secondWeekRevenue)
        {
            this.movieName = movieName; 
            this.revenue = revenue;
            this.performance = performance;
            this.firstWeekRevenue = firstWeekRevenue;
            this.secondWeekRevenue = secondWeekRevenue;
        }
    }
}
