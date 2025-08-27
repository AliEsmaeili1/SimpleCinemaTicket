using Core.Domain.Entities;

namespace Core.DTO.Request
{
    /// <summary>
    /// Represent ShowTime request DTO
    /// </summary>
    public class ShowTimeAddRequest:IRequest<ShowTime>
    {
        public int MovieId { get; set; }
        public int HallId { get; set; }
        public DateTime StartAt { get; set; }
        public decimal BasePrice { get; set; }

        public ShowTime ToDomain()
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
