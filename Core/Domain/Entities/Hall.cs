using System.ComponentModel.DataAnnotations;
namespace Core.Domain.Entities
{
    /// <summary>
    /// Represent Domain User model
    /// </summary>
    public class Hall: IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CinemaId { get; set; }
        public int Capacity { get; set; }

        //Navigator
        public Cinema Cinema { get; set; }
        public ICollection<ShowTime> ShowTimes { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
