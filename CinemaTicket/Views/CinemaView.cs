
using CinemaTicket.Views.Factory;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicServices;
using Spectre.Console;

namespace CinemaTicket.Views
{
    internal static class CinemaView
    {
        public static void Index(CinemaViewModel cinemaViewModel)
        {
            int? select = 0;
            do
           {
                
                Console.WriteLine("----*----Select Cinema Operation------*-----");
                Console.WriteLine("1: Show Cinema");
                Console.WriteLine("2: Add Cinema");
                Console.WriteLine("3: Delete Cinema");
                Console.WriteLine("4: Update Cinema");
                Console.WriteLine("5: Hall Operation");
                Console.WriteLine("6: ShowTime Cinema");
                Console.WriteLine("0: back");
                if (!int.TryParse(Console.ReadLine(), out int selectValue))
                    continue;

                select = selectValue;

                if (select == 0) break;

                try
                {
                    var strategy = cinemaViewModel.cinemaStrategyFactory.GetStrategy(select.Value);

                    strategy.Execute(cinemaViewModel);
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
