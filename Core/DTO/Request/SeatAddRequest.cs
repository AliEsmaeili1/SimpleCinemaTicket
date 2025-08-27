using Core.Domain.Entities;

namespace Core.DTO.Request
{
    /// <summary>
    /// Seat Request DTO model
    /// </summary>
    public class SeatAddRequest
    {
        public int HallId { get; set; }
        public int SeatNo { get; set; }
        public int SeatRow { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsVip { get; set; }
        public decimal ExtraPrice { get; set; }

    }
}
