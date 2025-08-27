using Core.Domain.Entities;

namespace Core.DTO.Update
{
    /// <summary>
    /// Represent User update request 
    /// </summary>
    public class UserUpdateRequest
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public ICollection<Ticket>? Tickets { get; set; } = null;
        public User ToUser()
        {
            return new User
            {
                Id = Id,
                FullName = FullName,
                Email = Email
            };
        }
    }
}
