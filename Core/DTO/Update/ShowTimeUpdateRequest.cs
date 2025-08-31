using Core.Domain.Entities;

namespace Core.DTO.Update
{
    /// <summary>
    /// Represent ShowTime update request 
    /// </summary>
    public class ShowTimeUpdateRequest : IEntity
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int HallId { get; set; }
        public DateTime StartAt { get; set; }
        public decimal BasePrice { get; set; }
    }
}
