using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.DTO.Request;

namespace CinemaTicket.Views.UserOperations
{
    public class AddUserStrategy:IUserOperation
    {
        public int OperationId => 1;

        public void Execute(UserServices userBl)
        {
            var userAddRequest = GetInfoToAdd();
            userBl.Add(userAddRequest);
            Console.WriteLine("============================");
            Console.WriteLine("-------New User Add---------");
            Console.WriteLine("============================");
        }
        /// <summary>
        /// get data from user and add to list
        /// </summary>
        /// <returns>user to add</returns>
        public static UserAddRequest GetInfoToAdd()
        {
            UserAddRequest newUser = new UserAddRequest();
            Console.WriteLine("FullName");
            newUser.FullName = Console.ReadLine();
            Console.WriteLine("Email");
            newUser.Email = Console.ReadLine();
            return newUser;
        }
    }
}
