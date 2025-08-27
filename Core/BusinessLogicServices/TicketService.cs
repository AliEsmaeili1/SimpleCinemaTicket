using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicServices
{
    public class TicketService:BaseService<Ticket, TicketAddRequest, TicketResponse, TicketUpdateRequest>
                               ,ITicketServiceContracts
    {
        public TicketService
            (IMapper<Ticket, TicketResponse, TicketAddRequest> mapper)
            : base(mapper) { }
    }
}
