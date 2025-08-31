using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicServices
{
    public class MovieService:
        BaseService<Movie,MovieAddRequest, MovieResponse, MovieUpdateRequest>,
        IMovieServiceContracts
    {
        public MovieService(IMapper<Movie, MovieResponse> mapper, IBaseRespository<Movie> repository)
            : base(mapper, repository) { }
        /// <summary>
        /// Represent Validate Movie is Exist or not
        /// </summary>
        /// <param name="movieId">movie id based on to search movie list</param>
        /// <returns></returns>
        public bool MovieIsExist(int movieId)
        {
            if (_repository.Get(item => item.Id == movieId) != null) return true;
            else return false;
        }
    }

    
}
