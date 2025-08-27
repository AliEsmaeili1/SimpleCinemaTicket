using Core.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Core.DTO.Update
{
    /// <summary>
    /// Represent Ticket update request 
    /// </summary>
    public class TicketUpdateRequest
    {
        [Key]
        public int Id { get; set; }
        public int SeatId { get; set; }
        public int UserId { get; set; }
        public int ShowTimeId { get; set; }
        public string? Payment { get; set; }//strategy design pattern
        public Ticket ToTicket()
        {
            return new Ticket
            {
                SeatId = SeatId,
                UserId = UserId,
                ShowTimeId = ShowTimeId,
                Payment = Payment
            };
        }
    }
 }
