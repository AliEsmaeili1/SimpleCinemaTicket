using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicServices
{
    public class HallService :
        BaseService<Hall, HallAddRequest, HallResponse, HallUpdateRequest>,
        IHallServiceContracts
    {
        private readonly IHallRepository _hallRepository;
        public HallService(IMapper<Hall, HallResponse> mapper, IBaseRespository<Hall> repository,
            IHallRepository hallRepository)
            : base(mapper, repository)
        {
            _hallRepository = hallRepository;
        }
        /// <summary>
        /// Get Hall Include Show Time
        /// </summary>
        /// <param name="hall_id">hall id base on to search</param>
        /// <returns></returns>
        /// <exception cref="Exception">hall With Show Time should not be null</exception>
        public HallResponse GetHallWhithShowTime(int hall_id)
        {
            Hall? hallWithShowTime = _hallRepository.GetByIdAndShowTime(hall_id);
            if (hallWithShowTime is null)
            {
                throw new Exception("hall With Show Time should not be null");
            }
            return _mapper.ToResponseDomain(hallWithShowTime);
        }
        /// <summary>
        /// Validat Hall is Exist or not
        /// </summary>
        /// <param name="hallId">based on search in hall list</param>
        /// <returns></returns>
        public bool ValidHall(int hallId)
        {
            Hall? hall = _repository.Get(item => item.Id == hallId);
            if (hall is null)
            {
                Console.WriteLine("hall not exist");
                return false;
            }
            else return true;
        }
    }
}



