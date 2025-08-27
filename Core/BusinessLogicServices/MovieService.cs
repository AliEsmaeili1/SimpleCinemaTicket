using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicServices
{
    public class MovieService:
        BaseService<Movie,MovieAddRequest, MovieResponse, MovieUpdateRequest>,
        IMovieServiceContracts
    {
        public MovieService(IMapper<Movie, MovieResponse, MovieAddRequest> mapper)
            : base(mapper) { }
    }
}
