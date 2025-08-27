using Core.Domain.Entities;

namespace Core.DTO.Request
{
    /// <summary>
    /// Represent Cinema Request DTO
    /// </summary>
    public class CinemaAddRequst:IRequest<Cinema>
    {
        public string? Name { get; set; }
        public string? Address { get; set; }

        public Cinema ToDomain()
        {
            return new Cinema()
            {
                Address = Address,
                Name = Name
            };
        }
    }
}
