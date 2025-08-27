using Core.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Core.DTO.Response
{
    /// <summary>
    /// Represent Ticket Response
    /// </summary>
    public class TicketResponse
    {
        [Key]
        public int Id { get; set; }
        public int SeatId { get; set; }
        public int UserId { get; set; }
        public int ShowTimeId { get; set; }
        public string? Payment { get; set; }//strategy design pattern
    }
}
