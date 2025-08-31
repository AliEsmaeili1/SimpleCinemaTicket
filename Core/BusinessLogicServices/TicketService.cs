using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicServices
{
    public class TicketService:BaseService<Ticket, TicketAddRequest, TicketResponse, TicketUpdateRequest>
                               ,ITicketServiceContracts
    {
        public TicketService
            (IMapper<Ticket, TicketResponse> mapper, IBaseRespository<Ticket> repository)
            : base(mapper, repository) { }
        /// <summary>
        /// Rerpresent Give User Id and base on return ticket of user
        /// </summary>
        /// <param name="userId">base on searches</param>
        /// <returns></returns>
        /// <exception cref="Exception">Ticket User Can't be null</exception>
        public List<TicketResponse> GetManyTicektUser(int userId)
        {
            ICollection<Ticket>? TicketsUser = _repository.GetMany(item => item.UserId == userId);
            if (TicketsUser is null)
                throw new Exception("Ticket User Can't be null");
            return TicketsUser.Select(s => _mapper.ToResponseDomain(s)).ToList();
        }
        /// <summary>
        /// Represent Give ticket and user and return specific ticket od user
        /// </summary>
        /// <param name="ticektid">base on searches in ticket list</param>
        /// <param name="userId">based on searches in user list</param>
        /// <returns></returns>
        /// <exception cref="Exception">ticket would not Exist</exception>
        public TicketResponse GetTicektUser(int ticektid, int userId)
        {
            Ticket? ticket= _repository.Get(item => item.Id == ticektid && item.UserId == userId);
            if (ticket is null)
                throw new Exception("Ticket is not found");

            return _mapper.ToResponseDomain(ticket);
        }

    }
}
