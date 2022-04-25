using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class AssignmentData
    {
        public string movieName { get; set; }
        public int noOfShows { get; set; }
        public Decimal revenue { get; set; }
        public string status { get; set; }
        public int week { get; set; }

        public AssignmentData() { }
        public AssignmentData(string movieName,int noOfShows,Decimal revenue,string status,int week)
        {
            this.movieName = movieName;
            this.noOfShows = noOfShows;
            this.revenue = revenue;
            this.status = status;
            this.week = week;
        }
    }
}
