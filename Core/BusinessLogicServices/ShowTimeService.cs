using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;
using System.Linq;

namespace Core.BusinessLogicServices
{
    public class ShowTimeService
        :BaseService<ShowTime, ShowTimeAddRequest,
                     ShowTimeResponse, ShowTimeUpdateRequest>, IShowTimeContracts
    {
        private readonly IHallServiceContracts _hallService;
        public ShowTimeService
            (IMapper<ShowTime, ShowTimeResponse> mapper, IBaseRespository<ShowTime> repository,
            IHallServiceContracts hallService)
            : base(mapper, repository) 
        {
            _hallService = hallService;
        }
        /// <summary>
        /// Represent check Showtime to add don't conflict with other show times
        /// </summary>
        /// <param name="showTimeAddRequest">show time want add to list</param>
        /// <returns>true if dont conflict with others</returns>
        public bool CheckConflictTime(ShowTimeAddRequest showTimeAddRequest)  
        {
            ICollection<ShowTime> sts = _repository.GetAll();
            //date not previuos
            if (showTimeAddRequest.StartAt < DateTime.Now)
            {
                Console.WriteLine("Data can't be less than today");
                return false;
            }
            //date not conflict with other time Show
            bool conflictExists = sts.Any(s =>
                 (s.StartAt == showTimeAddRequest.StartAt && s.HallId == showTimeAddRequest.HallId));

            if (conflictExists) return false;

            return true;

        }
        /// <summary>
        /// Represent return all show time of specific hall 
        /// </summary>
        /// <param name="hall_Id">base on searches in hall list</param>
        /// <returns>all show Time of hall</returns>
        /// <exception cref="Exception"></exception>
        public List<ShowTimeResponse> AllShowTimeHall(int hall_Id)
        {
            
            HallResponse? hall = _hallService.GetHallWhithShowTime(hall_Id);
            if (hall is null)
                throw new Exception("Hall is not exist");

            List<ShowTime> showTimeHall = hall.ShowTimes.ToList();

            return showTimeHall.Select(s => _mapper.ToResponseDomain(s)).ToList();
        }
    }
}
