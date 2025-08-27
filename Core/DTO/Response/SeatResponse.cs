using Core.Domain.Entities;

namespace Core.DTO.Response
{
    /// <summary>
    /// Represent Seat Response DTO
    /// </summary>
    public class SeatResponse
    {
        public int Id { get; set; }
        public int HallId { get; set; }
        public int SeatNo { get; set; }
        public int SeatRow { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsVip { get; set; }
        public decimal ExtraPrice { get; set; }
    }
}
