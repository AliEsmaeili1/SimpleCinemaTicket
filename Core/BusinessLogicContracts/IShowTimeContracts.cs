using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicContracts
{
    public interface IShowTimeContracts
                     :IBaseServiceContracts<ShowTimeAddRequest, ShowTimeResponse, ShowTimeUpdateRequest>
    {
        bool CheckConflictTime(ShowTimeAddRequest showTimeAddRequest);
    }
}
