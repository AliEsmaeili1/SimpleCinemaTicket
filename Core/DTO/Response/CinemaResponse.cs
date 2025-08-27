using Core.Domain.Entities;

namespace Core.DTO.Response
{
    /// <summary>
    /// Represent Cinema response DTO
    /// </summary>
    public class CinemaResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}
