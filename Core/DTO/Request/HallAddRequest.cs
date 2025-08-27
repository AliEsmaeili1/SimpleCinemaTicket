using Core.Domain.Entities;

namespace Core.DTO.Request
{
    /// <summary>
    /// Represent Hall request DTO
    /// </summary>
    public class HallAddRequest:IRequest<Hall>
    {
        public int CinemaId { get; set; }
        public int Capacity { get; set; }

        public Hall ToDomain()
        {
            return new Hall
            {
                Capacity = Capacity,
                CinemaId = CinemaId
            };
        }
    }
}
