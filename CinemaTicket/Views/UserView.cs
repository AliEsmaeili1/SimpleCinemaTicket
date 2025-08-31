
using CinemaTicket.Views.Factory;
using Core.BusinessLogicServices;
using Spectre.Console;

namespace CinemaTicket.Views
{
    internal static class UserView
    {
        public static void Index(UserServices userBL, UserFactory strategyFactory)
        {
            int? select = 0;
            do
           {
       
                Console.WriteLine("----*----select User Operation------*-----");
                Console.WriteLine("1: Add User");
                Console.WriteLine("2: Update User");
                Console.WriteLine("3: Delete User");
                Console.WriteLine("4: Buy Ticket");
                Console.WriteLine("5: Cancl Ticket" );
                Console.WriteLine("6: Show Ticket" );
                Console.WriteLine("0: back");
                if (!int.TryParse(Console.ReadLine(), out int selectValue))
                    continue;

                select = selectValue;

                if (select == 0) break;

                try
                {
                    var strategy = strategyFactory.GetStrategy(select.Value);
                    strategy.Execute(userBL);
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
