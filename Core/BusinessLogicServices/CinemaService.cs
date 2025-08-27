using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicServices
{
    public class CinemaService:BaseService<Cinema, CinemaAddRequst, CinemaResponse, CinemUpdateRequest>
                               ,ICinemaServiceContracts
    {
        public CinemaService(IMapper<Cinema, CinemaResponse, CinemaAddRequst> mapper) : base(mapper) { }
    }
}
