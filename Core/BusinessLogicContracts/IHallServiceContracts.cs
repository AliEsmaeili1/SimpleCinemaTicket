using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicContracts
{
    /// <summary>
    /// Hall Service Contracts
    /// </summary>
    public interface IHallServiceContracts
                     :IBaseServiceContracts
                      <HallAddRequest, HallResponse, HallUpdateRequest>
    {
        HallResponse GetHallWhithShowTime(int hall_id);
        bool ValidHall(int hallId);
    }
}
