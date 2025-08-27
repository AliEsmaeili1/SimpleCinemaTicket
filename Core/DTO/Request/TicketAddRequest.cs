using Core.Domain.Entities;

namespace Core.DTO.Request
{
    /// <summary>
    /// Represent Ticket Request DTO
    /// </summary>
    public class TicketAddRequest
    {
        public int SeatId { get; set; }
        public int UserId { get; set; }
        public int ShowTimeId { get; set; }
        public string? Payment { get; set; }//strategy design pattern
    }
}
