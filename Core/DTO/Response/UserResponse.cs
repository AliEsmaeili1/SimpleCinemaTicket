using Core.Domain.Entities;

namespace Core.DTO.Response
{
    /// <summary>
    /// Represent User Response DTO
    /// </summary>
    public class UserResponse
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
    }
}
