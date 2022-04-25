using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class MoviesChangeStatus
    {
        public string movieName { get; set; }
        public string status { get; set; }
        public int week { get; set; }

        public MoviesChangeStatus() {}
        public MoviesChangeStatus(string movieName,string status, int week)
        {
            this.movieName = movieName;
            this.status = status;
            this.week = week;
        }
    }
}
