using Core.BusinessLogicContracts;
using Core.BusinessLogicServices;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBaseServiceContracts<UserAddRequest, UserResponse, UserUpdateRequest>
                baseServiceContracts = new UserServices();

            baseServiceContracts.Add(new UserAddRequest()
            {
                FullName = "aliesmaeil",
                Email = "a@gmail.com"
            });

        }
    }
}
