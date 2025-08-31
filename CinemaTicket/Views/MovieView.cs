
using CinemaTicket.Views.Factory;
using Core.BusinessLogicServices;
using Spectre.Console;

namespace CinemaTicket.Views
{
    internal static class MovieView
    {
        public static void Index(MovieService MovieBl,
            MovieFactory moviestrategyFactory)
        {
            int? select = 0;
            do
           {
       
                Console.WriteLine("----*----Select Movie Operation------*-----");
                Console.WriteLine("1: Add Movei");
                Console.WriteLine("2: Update Movie");
                Console.WriteLine("3: Delete Movie");
                Console.WriteLine("0: back");
                if (!int.TryParse(Console.ReadLine(), out int selectValue))
                    continue;

                select = selectValue;

                if (select == 0) break;

                try
                {
                    var strategy = moviestrategyFactory.GetStrategy(select.Value);
                    strategy.Execute(MovieBl);
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
