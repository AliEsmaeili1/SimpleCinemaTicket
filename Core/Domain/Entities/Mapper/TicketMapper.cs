using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;
using System.Net.Sockets;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Entity to Response for DTO
    /// </summary>
    public class TicketMapper : 
        IMapper<Ticket, TicketResponse>
    {
        public Ticket ToEntity<TInput>(TInput input) where TInput : class
        {
            return input switch
            {
                TicketAddRequest request => new Ticket()
                {
                    SeatId = request.SeatId,
                    UserId = request.UserId,
                    ShowTimeId = request.ShowTimeId,
                    Payment = request.Payment
                },
                TicketUpdateRequest update => new Ticket()
                {
                    Id = update.Id,
                    SeatId = update.SeatId,
                    UserId = update.UserId,
                    ShowTimeId = update.ShowTimeId,
                    Payment = update.Payment
               
                },
                _ => throw new ArgumentException($"Unsupported input type: {typeof(TInput).Name}")
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
