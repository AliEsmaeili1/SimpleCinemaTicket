using Core.Domain.Entities;

namespace Core.DTO.Request
{
    /// <summary>
    /// Represent User Request DTO
    /// </summary>
    public class UserAddRequest
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }

    }
}
