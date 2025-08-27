using Core.Domain.Entities;

namespace Core.DTO.Request
{
    /// <summary>
    /// Represent Cinema Request DTO
    /// </summary>
    public class CinemaAddRequst
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}
