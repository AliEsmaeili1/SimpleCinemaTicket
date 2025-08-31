using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicContracts
{
    public interface ITicketServiceContracts
                     :IBaseServiceContracts<TicketAddRequest, TicketResponse, TicketUpdateRequest>
    {
        TicketResponse GetTicektUser(int ticektid, int userId);    
        List<TicketResponse> GetManyTicektUser(int userId);    
    }
}
