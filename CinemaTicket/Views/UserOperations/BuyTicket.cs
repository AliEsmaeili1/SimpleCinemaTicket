using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.DTO.Request;


namespace CinemaTicket.Views.UserOperations
{
    public class BuyTicket :IUserOperation
    {
        public int OperationId => 4;

        public void Execute(UserServices userBl)
        {
            
            Console.WriteLine("insert user Id");
            int userId = int.Parse(Console.ReadLine());
            TicketAddRequest newTicket = GetInfoToBuy(userId);
            userBl.BuyTicket(newTicket, userId);
        }
        public TicketAddRequest GetInfoToBuy(int userId)
        {
            TicketAddRequest newTicket = new TicketAddRequest();
            newTicket.UserId = userId;
            Console.WriteLine("insert ShowTime Id");
            newTicket.ShowTimeId = int.Parse(Console.ReadLine());
            Console.WriteLine("insert Seat Id");
            newTicket.SeatId = int.Parse(Console.ReadLine());
            
            return newTicket;
        }
    }


}
