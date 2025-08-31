using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.DTO.Request;

namespace CinemaTicket.Views.ShowTimeOperation
{
    public class AddShowtimeSterategy:IShowTimeOperation
    {
        public int OperationId => 3;

        public void Execute(int HallId, ShowTimeService showTimeBl, MovieService movieBl,
            ShowTimeFactory showTimeStrategyFactory, MovieFactory movieSterategyFactory)
        {
                var showTimeAddRequest = GetInfoToAdd(HallId, showTimeBl, movieBl);
                showTimeBl.Add(showTimeAddRequest);
                Console.WriteLine("============================");
                Console.WriteLine("-------New ShowTime Add---------");
                Console.WriteLine("============================");
        }
        /// <summary>
        /// get data from user and add to list
        /// </summary>
        /// <returns>user to add</returns>
        public static ShowTimeAddRequest GetInfoToAdd(int HallId, ShowTimeService showTimeBl, MovieService movieBl)
        {
            ShowTimeAddRequest newShowtime = new ShowTimeAddRequest();
            do
            {

                Console.WriteLine("insert Date (2005-05-01)");
                string dateInput = Console.ReadLine();
                if (!DateTime.TryParse(dateInput, out DateTime parsedDate))
                {
                    Console.WriteLine("Invalid date format. Please try again.");
                    continue;
                }
                newShowtime.StartAt = parsedDate;
                Console.WriteLine("insert Base Price");
                newShowtime.BasePrice = int.Parse(Console.ReadLine());
                Console.WriteLine("insert Movie id");
                newShowtime.MovieId = int.Parse(Console.ReadLine());
                if (!movieBl.MovieIsExist(newShowtime.MovieId))
                {
                    Console.WriteLine("Movie is not exist");
                    continue;
                }
                newShowtime.HallId = HallId;
            } while (!showTimeBl.CheckConflictTime(newShowtime));
            
            return newShowtime;
        }
    }
}
