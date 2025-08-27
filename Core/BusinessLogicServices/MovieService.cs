using Core.BusinessLogicContracts;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicServices
{
    public class MovieService:
        BaseService<MovieAddRequest, MovieResponse, MovieUpdateRequest>,
        IMovieServiceContracts
    {
    }
}
