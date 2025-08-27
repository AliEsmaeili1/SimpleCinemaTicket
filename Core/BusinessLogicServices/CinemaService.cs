using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicServices
{
    public class CinemaService:BaseService<Cinema, CinemaAddRequst, CinemaResponse, CinemUpdateRequest>
                               ,ICinemaRepository
    {
        public CinemaService
            (IMapper<Cinema, CinemaResponse, CinemaAddRequst> mapper) 
            : base(mapper) { }
    }
}
