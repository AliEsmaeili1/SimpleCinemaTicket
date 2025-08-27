using Core.DTO.Response;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Entity to Response for DTO
    /// </summary>
    public class SeatMapper : IMapper<Seat, SeatResponse>
    {
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
