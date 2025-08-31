
using CinemaTicket.Views.Factory;
using Core.BusinessLogicServices;
using Core.Domain.Entities;
using Core.DTO.Response;
using Spectre.Console;

namespace CinemaTicket.Views
{
    internal static class SeatView
    {
        public static void Index(SeatService seataBL,
            SeatFactory seatStrategyFactory, HallResponse hall)
        {
            int? select = 0;
            do
           {
                

                Console.WriteLine("----*----Select Seat Operation------*-----");
                Console.WriteLine("1: Show Seat");
                Console.WriteLine("2: Add Seat");
                Console.WriteLine("3: Update Seat");
                Console.WriteLine("4: Delete Seat");
                Console.WriteLine("0: back");
                if (!int.TryParse(Console.ReadLine(), out int selectValue))
                    continue;

                select = selectValue;

                if (select == 0) break;

                try
                {
                    var strategy = seatStrategyFactory.GetStrategy(select.Value);
                    strategy.Execute(seataBL, seatStrategyFactory, hall);
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
