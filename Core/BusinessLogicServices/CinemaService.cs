using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicServices
{
    public class CinemaService:BaseService<Cinema, CinemaAddRequst, CinemaResponse, CinemUpdateRequest>
                               ,ICinemaServiceContracts
    {
        public CinemaService
            (IMapper<Cinema, CinemaResponse> mapper, IBaseRespository<Cinema> repository) 
            : base(mapper, repository) 
        {
           
        }
        /// <summary>
        /// Validate cinema is exist or not
        /// </summary>
        /// <param name="cinemaId">base on search in cinema list</param>
        /// <returns></returns>
        public bool ValidCinema(int cinemaId)
        {
            Cinema? cinema = _repository.Get(item => item.Id == cinemaId);
            if (cinema == null) 
            {
                Console.WriteLine("cinema not exist");
                return false;
            }
            else return true;
        }
    }
}
