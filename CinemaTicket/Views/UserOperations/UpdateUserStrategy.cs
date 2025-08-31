using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.DTO.Response;
using Core.DTO.Update;

namespace PhoneBook.Views.UserOperations
{
    public class UpdateUserStrategy:IUserOperation
    {
        public int OperationId => 2;

        public void Execute(UserServices userBl)
        {
            Console.WriteLine("Insert user id to update?");
            int id = int.Parse(Console.ReadLine());

            var updateRequest = GetInfoTUpdate(userBl, id);
            userBl.Update(updateRequest);
            Console.WriteLine("============================");
            Console.WriteLine("-------User Updated---------");
            Console.WriteLine("============================");
        }

        public static UserUpdateRequest GetInfoTUpdate(UserServices userBl, int id_to_update)
        {
            UserResponse? oldUser = userBl.GetById(id_to_update);
            UserUpdateRequest newUser = new UserUpdateRequest();
            newUser.Id = oldUser.Id;
            Console.WriteLine("Old FullName: " + oldUser.FullName);
            Console.WriteLine("New FirsName");
            newUser.FullName = Console.ReadLine();
            Console.WriteLine("Old Email: " + oldUser.Email);
            Console.WriteLine("Email");
            newUser.Email = Console.ReadLine();
            return newUser;
        }
    }
}
