using Core.DTO.Response;
using System.ComponentModel.DataAnnotations;

namespace Core.Domain.Entities
{
    /// <summary>
    /// Represent domain User model
    /// </summary>
    public class User: IEntity
    {
        [Key]
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
    }
}
