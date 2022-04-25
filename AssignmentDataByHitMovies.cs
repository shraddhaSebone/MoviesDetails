using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class AssignmentDataByHitMovies
    {
        public string movieName { get; set; }
       // public int week { get; set; }
        public Decimal totalRrevenue { get; set; }

        public AssignmentDataByHitMovies() { }
        public AssignmentDataByHitMovies(string movieName, Decimal totalRrevenue)
        {
            this.movieName = movieName;
            //this.week = week;
            this.totalRrevenue = totalRrevenue;
        }

    }
}
