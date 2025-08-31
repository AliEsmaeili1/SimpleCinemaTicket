using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;
using System.Net;
using System.Xml.Linq;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Cinema Entity to Response for DTO
    /// </summary>
    public class CinemaMapper 
        : IMapper<Cinema, CinemaResponse>
    {
        public Cinema ToEntity<TInput>(TInput input) where TInput : class
        {
            return input switch
            {
                CinemaAddRequst request => new Cinema()
                {
                    Name = request.Name,
                    Address = request.Address  
                },
                CinemUpdateRequest update => new Cinema()
                {
                    Id = update.Id,
                    Name = update.Name,
                    Address = update.Address
                },
                _ => throw new ArgumentException($"Unsupported input type: {typeof(TInput).Name}")
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
