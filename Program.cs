using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    /* @classname: Assignmnet3
     * objective: to osrsaction of a program by serval calling
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AssignmentData> list = new List<AssignmentData>(); // craete a AssignmnetData type list 
            AssignmentData assignmentData1 = new AssignmentData("RRR" , 60 , 40000000 , "Hit" , 1);
            AssignmentData assignmentData2 = new AssignmentData("KGF", 90, 75000000, "Hit", 1);
            AssignmentData assignmentData3 = new AssignmentData("Attack", 35, 80000000, "Average", 1);
            AssignmentData assignmentData4 = new AssignmentData("Spiderman", 120, 90000000, "Hit",1);
            AssignmentData assignmentData5 = new AssignmentData("RRR", 40, 30000000, "Hit", 2);
            AssignmentData assignmentData6 = new AssignmentData("KGF", 60, 450000000, "Hit", 2);
            AssignmentData assignmentData7 = new AssignmentData("Attack", 45, 95000000, "Hit", 2);
            AssignmentData assignmentData8 = new AssignmentData("Spiderman", 75, 30000000, "Average", 2);
           
            list.Add(assignmentData1); //Add all the data into list
            list.Add(assignmentData2);
            list.Add(assignmentData3);
            list.Add(assignmentData4);
            list.Add(assignmentData5);
            list.Add(assignmentData6);
            list.Add(assignmentData7);
            list.Add(assignmentData8);

            foreach (AssignmentData data in list)
            {
                Console.WriteLine($"{data.movieName},{data.noOfShows},{data.revenue},{data.status},{data.week}");
            }
            Console.WriteLine($"-------------------------------------------------------------------------------");
            
            AssignmentOperations assignmentOperations = new AssignmentOperations(); //create AssignmentOperations class object
            List<RevenuePerMoviesData> list1 = assignmentOperations.getRevenuePerMovies(list);//call the getRevenuePerMovies and given parameter is list
            foreach (RevenuePerMoviesData data in list1)//iterting the list who give by method
            {
                Console.WriteLine($"{data.movieName},{data.revenuePerShow},{data.week}");
            }
            Console.WriteLine($"-------------------------------------------------------------------------------");
            List<AssignmentDataByHitMovies> list2 = assignmentOperations.getTotalRevenueForAllHitMovies(list);  
            foreach(AssignmentDataByHitMovies data in list2)
            {
                Console.WriteLine($"{data.movieName},{data.totalRrevenue}");
            }
            Console.WriteLine($"-------------------------------------------------------------------------------");
            List<MoviesChangeStatus> list3 = assignmentOperations.getMoviesChangeStatus(list);
            foreach(MoviesChangeStatus data in list3)
            {
                Console.WriteLine($"{data.movieName},{data.status},{data.week}");
            }
            Console.WriteLine($"-------------------------------------------------------------------------------");
            List<MoviePerformanceRevenue> list4 = assignmentOperations.getMoviePerformanceRevenues(list);
            foreach (MoviePerformanceRevenue data in list4)
            {
                Console.WriteLine($"{data.movieName},{data.revenue},{data.performance}");
            }
        }
    }
}
