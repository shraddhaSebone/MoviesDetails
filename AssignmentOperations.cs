using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{ 
    internal class AssignmentOperations
    {/* @classname:AssignmentOperations
      * @objective:To Perfrom various task
      * @Date:20-04-2022
      * @Author name:Shraddha Choudhary
      */
        public List<RevenuePerMoviesData> getRevenuePerMovies(List<AssignmentData> list)
        {
            /* Method:getRevenuePerMovies
             * param:List<AssignmentData>
             * objective:Find revenue per movie per shows in week-1 and week-2
             * return:RevenuePerMoviesData type assingmentdetails
             */
            Dictionary<KeyValuePair<string, int>, RevenuePerMoviesData> dict = new Dictionary<KeyValuePair<string, int>, RevenuePerMoviesData>();
            List<RevenuePerMoviesData> assingmentdetails = new List<RevenuePerMoviesData>();
            foreach (AssignmentData data in list)
            {
                var keyvalue = new KeyValuePair<string, int>(data.movieName, data.week);
                decimal revenuepershow = data.revenue / data.noOfShows;
                if (!dict.ContainsKey(keyvalue))
                {
                    dict.Add(keyvalue, new RevenuePerMoviesData(data.movieName, revenuepershow, data.week));
                    { 
                    // key[keyvalue].revenuepershow /= data.noofshows;
                
                        // decimal revenuepershow = data.revenue / data.noofshows;
                        // key[keyvalue].revenuepershow += revenuepershow;
                        // key[keyvalue].week = data.week;
                 
                        //}
                        //{
                        //else
                        //{
                        //   key.add(keyvalue, new revenuepermoviesdata(data.moviename,revenuepershow,data.week));
                        //   key.add(keyvalue, new revenuepermoviesdata(data.moviename,revenuepershow,data.week));
                        //}
                     }
                }
            }
            foreach (RevenuePerMoviesData data in dict.Values)
            {
                assingmentdetails.Add(data);
            }
            return assingmentdetails;
            {
                //List<RevenuePerMoviesData> assingmentDetails = new List<RevenuePerMoviesData>();
                //foreach (AssignmentData data in list)
                //{
                //    RevenuePerMoviesData obj = new RevenuePerMoviesData();
                //    obj.movieName = data.movieName;
                //    obj.week = data.week;
                //    obj.revenuePerShow = data.revenue / data.noOfShows;
                //    assingmentDetails.Add(obj);
                //}
                //return assingmentDetails;
            }
        }

        public List<AssignmentDataByHitMovies> getTotalRevenueForAllHitMovies(List<AssignmentData> list)
        {
            /* @Method:getTotalRevenueForAllHitMovies
             * param:List<AssignmentData>
             * objective:Find total revenue for all hit movie across all weeks
             * return:assignmentDataByHitMovies
            */
            Dictionary<string, AssignmentDataByHitMovies> dict = new Dictionary<string, AssignmentDataByHitMovies>();
            List<AssignmentDataByHitMovies> assignmentDataByHitMovies = new List<AssignmentDataByHitMovies>();
            foreach (AssignmentData data in list)
            {
                if (dict.ContainsKey(data.movieName))
                {
                    if (data.status == "Hit")
                    {
                        dict[data.movieName].totalRrevenue += data.revenue;
                    }
                }
                else
                {
                    if (data.status == "Hit")
                    {
                        dict.Add(data.movieName, new AssignmentDataByHitMovies());
                        dict[data.movieName].movieName = data.movieName;
                        dict[data.movieName].totalRrevenue = data.revenue;
                    }
                }
            }
            foreach (AssignmentDataByHitMovies data1 in dict.Values)
            {
                assignmentDataByHitMovies.Add(data1);
            }
            return assignmentDataByHitMovies;
        }

        public List<MoviesChangeStatus> getMoviesChangeStatus(List<AssignmentData> list)
        {
            /* @Method:getRevenuePerMovies
             * @param:List<AssignmentData>
             * @objective:Show movies which are changed in status in weekly level
             * @return:RevenuePerMoviesData type assingmentdetails
             */
            Dictionary<string, MoviesChangeStatus> dict = new Dictionary<string, MoviesChangeStatus>();
            List<MoviesChangeStatus> moviesChangeStatus = new List<MoviesChangeStatus>();
            foreach (AssignmentData data in list) //list of all object
            {
                MoviesChangeStatus moviesChange = new MoviesChangeStatus();
                if (dict.ContainsKey(data.movieName))
                {
                    if (data.status != dict[data.movieName].status)
                    {
                        moviesChange.movieName = data.movieName;
                        moviesChange.status = data.status;
                        moviesChange.week = data.week;
                        moviesChangeStatus.Add(moviesChange);
                        moviesChangeStatus.Add(dict[data.movieName]);
                    }
                }
                else
                {
                    moviesChange.movieName = data.movieName;
                    moviesChange.status = data.status;
                    moviesChange.week = data.week;
                    dict.Add(data.movieName, moviesChange);
                }
            }
            return moviesChangeStatus;
        }

        public List<MoviePerformanceRevenue> getMoviePerformanceRevenues(List<AssignmentData> list)
        {
            /* @Method:getMoviePerformanceRevenues
            * @param:List<AssignmentData>
            * @objective:Show revenue per show increase or decrease for movies on week-2 compare to week-1 level
            * @return:movies
            */
            Dictionary<string, MoviePerformanceRevenue> key = new Dictionary<string, MoviePerformanceRevenue>();
            List<MoviePerformanceRevenue> movies = new List<MoviePerformanceRevenue>();
            foreach (AssignmentData data in list)
            {
                if (key.ContainsKey(data.movieName))
                {
                    MoviePerformanceRevenue movieperformancerevenue = new MoviePerformanceRevenue();
                    movieperformancerevenue.movieName = data.movieName;
                    movieperformancerevenue.revenue = data.revenue / data.noOfShows;
                    if (key[data.movieName].revenue <= movieperformancerevenue.revenue)
                    {
                        movieperformancerevenue.performance = "Incremnet";
                        movies.Add(movieperformancerevenue);
                    }
                    else
                    {
                        movieperformancerevenue.performance = "Decrement";
                        movies.Add(movieperformancerevenue);
                    }
                }
                else
                {
                    MoviePerformanceRevenue movieperformancerevenue = new MoviePerformanceRevenue();
                    movieperformancerevenue.movieName = data.movieName;
                    movieperformancerevenue.revenue = data.revenue / data.noOfShows;
                    key.Add(data.movieName, movieperformancerevenue);
                }
            }
            return movies;
        }


        //public List<MoviePerformanceRevenue> movieRevenueReuse(List<RevenuePerMoviesData> list)
        //{
        //    Dictionary<string, MoviePerformanceRevenue> dict = new Dictionary<string, MoviePerformanceRevenue>();
        //    foreach (RevenuePerMoviesData data1 in list)
        //    {
        //        if (dict.ContainsKey(data1.movieName))
        //        {
        //            data1.revenuePerShow = data1.revenuePerShow;
        //        }
        //        else
        //        {

        //            dict.Add(data1.movieName, new MoviePerformanceRevenue());
        //            dict[data1.movieName].movieName = data1.movieName;
        //            dict[data1.movieName].revenue = data1.revenue;
        //        }
        //    }
        //    return null;
        //}
    }
}

