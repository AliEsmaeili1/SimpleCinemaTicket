using Core.Domain.Entities;

namespace Core.DTO.Response
{
    /// <summary>
    /// Represent Hall Response DTO
    /// </summary>
    public class HallResponse
    {
        public int Id { get; set; }
        public int CinemaId { get; set; }
        public int Capacity { get; set; }

        public ICollection<ShowTime> ShowTimes { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
