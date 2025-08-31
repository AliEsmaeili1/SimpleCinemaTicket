using System.ComponentModel.DataAnnotations;

namespace Core.Domain.Entities
{
    /// <summary>
    /// Represent Doamin seat model
    /// </summary>
    public class Seat:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int HallId { get; set; }
        public int SeatNo { get; set; }
        public int SeatRow { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsVip { get; set; }
        public decimal ExtraPrice { get; set; }

        //Navigator
        public Hall Hall { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
