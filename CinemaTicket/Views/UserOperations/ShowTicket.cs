using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.DTO.Request;
using Core.DTO.Response;

namespace CinemaTicket.Views.UserOperations
{
    public class ShowTicket :IUserOperation
    {
        public int OperationId => 6;

        public void Execute(UserServices userBl)
        {
            Console.WriteLine("user Id");
            int id_to_show = int.Parse(Console.ReadLine());
            userBl.ShowTicket(id_to_show);
        }
    }
}
