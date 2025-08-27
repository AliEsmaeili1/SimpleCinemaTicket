using Core.DTO.Request;
using Core.DTO.Response;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Entity to Response for DTO
    /// </summary>
    public class SeatMapper : IMapper<Seat, SeatResponse, SeatAddRequest>
    {
        public Seat ToEntity(SeatAddRequest request)
        {
            return new Seat()
            {
                HallId = request.HallId,
                SeatNo = request.SeatNo,
                SeatRow = request.SeatRow,
                IsAvailable = request.IsAvailable,
                IsVip = request.IsVip,
                ExtraPrice = request.ExtraPrice
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
                SeatRow = entity.SeatRow
            };
        }
    }
}
