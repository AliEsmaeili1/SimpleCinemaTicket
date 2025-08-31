
using CinemaTicket.Views.Factory;
using Core.BusinessLogicServices;
using Spectre.Console;

namespace CinemaTicket.Views
{
    internal static class ShowTimeView
    {
        public static void Index(int HallId, ShowTimeService showTimeBl, MovieService movieBl,
            ShowTimeFactory showTimeStrategyFactory, MovieFactory movieSterategyFactory)
        {
            int? select = 0;
            do
           {
       
                Console.WriteLine("----*----Select ShowTime Operation------*-----");
                Console.WriteLine("1: All Show Time Cinema");
                Console.WriteLine("2: Sanse Hall");
                Console.WriteLine("3: Add ShowTime");
                Console.WriteLine("4: Update ShowTime");
                Console.WriteLine("5: Delete ShowTime");
                Console.WriteLine("6: Movie Operation");
                Console.WriteLine("0: back");
                if (!int.TryParse(Console.ReadLine(), out int selectValue))
                    continue;

                select = selectValue;

                if (select == 0) break;

                try
                {
                    var strategy = showTimeStrategyFactory.GetStrategy(select.Value);
                    strategy.Execute(HallId, showTimeBl, movieBl,
                    showTimeStrategyFactory, movieSterategyFactory);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (select != 0);
        }
    }
}
