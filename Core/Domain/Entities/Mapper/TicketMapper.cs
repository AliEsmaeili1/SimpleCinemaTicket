using Core.DTO.Request;
using Core.DTO.Response;
using System.Net.Sockets;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Entity to Response for DTO
    /// </summary>
    public class TicketMapper : IMapper<Ticket, TicketResponse, TicketAddRequest>
    {
        public Ticket ToEntity(TicketAddRequest request)
        {
            return new Ticket
            {
                SeatId = request.SeatId,
                UserId = request.UserId,
                ShowTimeId = request.ShowTimeId,
                Payment = request.Payment
            };
        }

        public TicketResponse ToResponseDomain(Ticket entity)
        {
            return new TicketResponse()
            {
                Id = entity.Id,
                Payment = entity.Payment,
                SeatId = entity.SeatId,
                UserId = entity.UserId,
                ShowTimeId = entity.ShowTimeId
            };
        }
    }
}
