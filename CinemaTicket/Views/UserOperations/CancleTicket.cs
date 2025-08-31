using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.Domain.Entities;
using Core.DTO.Request;
namespace CinemaTicket.Views.UserOperations
{
    public class CancleTicket : IUserOperation
    {
        public int OperationId => 5;

        public void Execute(UserServices userBl)
        {
            if (GetInfoToCancle( userBl))
                Console.WriteLine("Ticket is deleted");
        }
        public bool  GetInfoToCancle(UserServices userBl)
        {
            
            Console.WriteLine("user Id");
            int userId = int.Parse(Console.ReadLine());
            Console.WriteLine("Ticket Id");
            int ticketId = int.Parse(Console.ReadLine());

            userBl.CancleTicket(userId, ticketId);

            return true;
        }
    }
}
