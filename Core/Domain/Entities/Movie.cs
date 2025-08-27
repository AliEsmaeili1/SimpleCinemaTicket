using Core.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Core.Domain.Entities
{
    /// <summary>
    /// Represent Domain Movie Model
    /// </summary>
    public class Movie:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public TimeSpan Duration { get; set; }//int represent second
        public GenerEnums Gener { get; set; }

        //Navigator
        ICollection<ShowTime>? ShowTimes { get; set; }
    }
}
