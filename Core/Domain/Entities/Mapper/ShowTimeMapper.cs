using Core.DTO.Response;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Entity to Response for DTO
    /// </summary>
    public class ShowTimeMapper : IMapper<ShowTime, ShowTimeResponse>
    {
        public ShowTimeResponse ToResponseDomain(ShowTime entity)
        {
            return new ShowTimeResponse()
            {
                BasePrice = entity.BasePrice,
                HallId = entity.HallId,
                StartAt = entity.StartAt,
                Id = entity.Id,
                MovieId = entity.MovieId
            };
        }
    }
}
