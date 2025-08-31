using CinemaTicket.Views.Operations;
using Core.BusinessLogicContracts;
using Core.BusinessLogicServices;
using Core.DTO.Response;

namespace CinemaTicket.Views.UserOperations
{
    public class DeleteUserStrategy:IUserOperation
    {
        private readonly ITicketServiceContracts _TicketService;

        public DeleteUserStrategy(ITicketServiceContracts TicketService)
        {
           _TicketService = TicketService; 
        }

        public int OperationId => 3;

        public void Execute(UserServices userBl)
        {
            int idToDelete = GetInfoToDlete(userBl);
            //Get all ticket of User and delete before delete user
            List<TicketResponse> ticketsUser = _TicketService.GetManyTicektUser(idToDelete);
            //when more than one ticket were buy
            foreach (TicketResponse item in ticketsUser)
                userBl.CancleTicket(idToDelete, item.Id);
            //delete user after cancel ticekt
            userBl.DeleteById(idToDelete);
            Console.WriteLine("============================");
            Console.WriteLine("-------User deleted------");
            Console.WriteLine("============================");
        }
        /// <summary>
        /// get user to delete from list
        /// </summary>
        /// <param name="conBl"></param>
        /// <returns></returns>
        public static int GetInfoToDlete(UserServices userBl)
        {
            Console.WriteLine("Insert user id to delete?");
            int id_to_delete = int.Parse(Console.ReadLine());
            return id_to_delete;
        }
    }
}
