
using CinemaTicket.Views.Factory;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicServices;
using Core.Domain.Entities;
using Spectre.Console;

namespace CinemaTicket.Views
{
    public static class HallView
    {
        public static void Index(HallViewModel hallViewModel)
        {
            int? select = 0;
            do
            {
                Console.WriteLine("----*----Select Hall Operation------*-----");
                Console.WriteLine("1: Show Halls");
                Console.WriteLine("2: Add Hall");
                Console.WriteLine("3: Update Hall");
                Console.WriteLine("4: Delete Hall");
                Console.WriteLine("5: Seat Operation");
                Console.WriteLine("0: back");
                if (!int.TryParse(Console.ReadLine(), out int selectValue))
                    continue;

                select = selectValue;

                if (select == 0) break;

                try
                {
                    var strategy = hallViewModel.hallstrategyFactory.GetStrategy(select.Value);
                    strategy.Execute(hallViewModel);
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
