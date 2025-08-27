using Core.Domain.Entities;

namespace Core.DTO.Request
{
    /// <summary>
    /// Represent Hall request DTO
    /// </summary>
    public class HallAddRequest
    {
        public int CinemaId { get; set; }
        public int Capacity { get; set; }

    }
}
