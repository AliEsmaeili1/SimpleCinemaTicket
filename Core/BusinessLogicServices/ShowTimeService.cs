using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicServices
{
    public class ShowTimeService
        :BaseService<ShowTime, ShowTimeAddRequest,
                     ShowTimeResponse, ShowTimeUpdateRequest>, IShowTimeContracts
    {
        public ShowTimeService
            (IMapper<ShowTime, ShowTimeResponse, ShowTimeAddRequest> mapper)
            : base(mapper) { }
    }
}
