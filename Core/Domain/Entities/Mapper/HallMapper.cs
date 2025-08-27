using Core.DTO.Response;
using System;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Hall Entity to Response for DTO
    /// </summary>
    public class HallMapper : IMapper<Hall, HallResponse>
    {
        public HallResponse ToResponseDomain(Hall entity)
        {
            return new HallResponse
            {
                Id = entity.Id,
                Capacity = entity.Capacity,
                CinemaId = entity.CinemaId
            };
        }
    }
}
