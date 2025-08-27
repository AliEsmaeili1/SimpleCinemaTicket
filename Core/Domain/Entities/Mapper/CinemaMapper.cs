using Core.DTO.Request;
using Core.DTO.Response;
using System.Net;
using System.Xml.Linq;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Cinema Entity to Response for DTO
    /// </summary>
    public class CinemaMapper 
        : IMapper<Cinema, CinemaResponse, CinemaAddRequst>
    {
        public Cinema ToEntity(CinemaAddRequst request)
        {
            return new Cinema()
            {
                Address = request.Address,
                Name = request.Name
            };
        }

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
