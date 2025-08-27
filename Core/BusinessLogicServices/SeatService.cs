using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicServices
{
    public class SeatService
        : BaseService<Seat, SeatAddRequest, SeatResponse, SeatUpdateRequest>
        ,ISeatServiceContracts
    {
        public SeatService(IMapper<Seat, SeatResponse, SeatAddRequest>mapper)
            :base(mapper) { }
        
    }
}
