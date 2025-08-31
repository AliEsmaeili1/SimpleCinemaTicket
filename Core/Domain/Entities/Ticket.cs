using System.ComponentModel.DataAnnotations;
namespace Core.Domain.Entities
{
    /// <summary>
    /// Represent Domain Tickets Model
    /// </summary>
    public class Ticket: IEntity
    {
        [Key]
        public int Id { get; set; }
        public int SeatId { get; set; }
        public int UserId { get; set; }
        public int ShowTimeId { get; set; }
        public string? Payment { get; set; }//strategy design pattern

        //Navigator
        public User User { get; set; } 
        public Seat Seat { get; set; } 
        public ShowTime ShowTime { get; set; }
    }
}
