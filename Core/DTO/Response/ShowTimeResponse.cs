using Core.Domain.Entities;

namespace Core.DTO.Response
{
    /// <summary>
    /// Represent ShowTime Response DTO
    /// </summary>
    public class ShowTimeResponse
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int HallId { get; set; }
        public DateTime StartAt { get; set; }
        public decimal BasePrice { get; set; }
    }
}
