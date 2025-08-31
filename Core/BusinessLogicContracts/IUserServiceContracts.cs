using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicContracts
{
    public interface IUserServiceContracts
                    :IBaseServiceContracts<UserAddRequest, UserResponse, UserUpdateRequest>
    {
        public bool BuyTicket(TicketAddRequest ticket, int userId);
        public void CancleTicket(int userId, int ticketId);
        public void ShowTicket(int userId);
       /* List<TicketResponse> GetAllTicketUser(int userId);*/
    }
}
