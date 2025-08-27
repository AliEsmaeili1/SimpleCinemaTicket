using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicContracts
{
    public interface ISeatServiceContracts
        :IBaseServiceContracts<SeatAddRequest, SeatResponse, SeatUpdateRequest >
    {
    }
}
