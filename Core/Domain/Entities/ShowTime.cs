using System.ComponentModel.DataAnnotations;

namespace Core.Domain.Entities
{
    /// <summary>
    /// Represent Domain ShowTime Model
    /// </summary>
    public class ShowTime:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int HallId { get; set; }
        public DateTime StartAt { get; set; }
        public decimal BasePrice { get; set; }
        //navigator
        public Movie? Movie { get; set; } = null;
        public Hall? Hall { get; set; } = null;
        public ICollection<Ticket> Tickets { get; set; }
    }
}
