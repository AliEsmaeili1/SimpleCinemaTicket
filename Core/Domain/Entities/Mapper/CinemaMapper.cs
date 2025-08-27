using Core.DTO.Response;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Cinema Entity to Response for DTO
    /// </summary>
    public class CinemaMapper : IMapper<Cinema, CinemaResponse>
    {
        public CinemaResponse ToResponseDomain(Cinema entity)
        {
            return new CinemaResponse
            {
                Id = entity.Id,
                Name = entity.Name,
                Address = entity.Address
            };
        }
    }
}
