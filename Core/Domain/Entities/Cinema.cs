using System.ComponentModel.DataAnnotations;

namespace Core.Domain.Entities
{
    /// <summary>
    /// Represent Domain Cinema Model
    /// </summary>
    public class Cinema: IEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        //Navigator
        public ICollection<Hall>? Halls { get; set; }

    }
}
