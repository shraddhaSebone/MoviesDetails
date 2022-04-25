using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class RevenuePerMoviesData
    {
        public string movieName { get; set; }
        public Decimal revenuePerShow { get; set; }
        public int week { get; set; }

        public RevenuePerMoviesData() { }
        public RevenuePerMoviesData(string movieName,Decimal revenuePerShow, int week)
        {
            this.movieName = movieName;
            this.revenuePerShow = revenuePerShow;
            this.week = week;
        }
    }
}
