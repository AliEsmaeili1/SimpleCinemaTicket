using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Entity to Response for DTO
    /// </summary>
    public class SeatMapper : IMapper<Seat, SeatResponse>
    {
        public Seat ToEntity<TInput>(TInput input) where TInput : class
        {
            return input switch
            {
                SeatAddRequest request => new Seat()
                {
                    SeatNo = request.SeatNo,
                    SeatRow = request.SeatRow,
                    IsVip = request.IsVip,
                    IsAvailable = request.IsAvailable,
                    HallId = request.HallId,
                    ExtraPrice = request.ExtraPrice
                },
                SeatUpdateRequest update => new Seat()
                {
                    Id = update.Id,
                    SeatNo = update.SeatNo,
                    SeatRow = update.SeatRow,
                    IsVip = update.IsVip,
                    IsAvailable = update.IsAvailable,
                    HallId = update.HallId,
                    ExtraPrice = update.ExtraPrice
                },
                _ => throw new ArgumentException($"Unsupported input type: {typeof(TInput).Name}")
            };
        }

        public SeatResponse ToResponseDomain(Seat entity)
        {
            return new SeatResponse()
            {
                Id = entity.Id,
                ExtraPrice = entity.ExtraPrice,
                IsAvailable = entity.IsAvailable,
                HallId = entity.HallId,
                IsVip = entity.IsVip,
                SeatNo = entity.SeatNo,
                SeatRow = entity.SeatRow,
                Tickets = entity.Tickets
            };
        }
    }
}
