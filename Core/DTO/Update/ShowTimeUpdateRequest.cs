using Core.Domain.Entities;

namespace Core.DTO.Update
{
    /// <summary>
    /// Represent ShowTime update request 
    /// </summary>
    public class ShowTimeUpdateRequest
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int HallId { get; set; }
        public DateTime StartAt { get; set; }
        public decimal BasePrice { get; set; }

        public ShowTime ToShowTime()
        {
            return new ShowTime()
            {
                StartAt = StartAt,
                MovieId = MovieId,
                BasePrice = this.BasePrice
            };
        }
    }
}
