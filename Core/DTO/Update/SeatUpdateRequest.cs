using Core.Domain.Entities;

namespace Core.DTO.Update
{
    /// <summary>
    /// Represent Seat update request 
    /// </summary>
    public class SeatUpdateRequest
    {
        public int Id { get; set; }
        public int HallId { get; set; }
        public int SeatNo { get; set; }
        public int SeatRow { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsVip { get; set; }
        public decimal ExtraPrice { get; set; }
        public Seat ToSeat()
        {
            return new Seat()
            {
                HallId = HallId,
                SeatNo = SeatNo,
                SeatRow = SeatRow,
                IsAvailable = IsAvailable,
                IsVip = IsVip,
                ExtraPrice = ExtraPrice
            };
        }
    }
}
