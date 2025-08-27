using Core.DTO.Request;
using Core.DTO.Response;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Entity to Response for DTO
    /// </summary>
    public class ShowTimeMapper : IMapper<ShowTime, ShowTimeResponse,ShowTimeAddRequest>
    {
        public ShowTime ToEntity(ShowTimeAddRequest request)
        {
            return new ShowTime()
            {
                StartAt = request.StartAt,
                MovieId = request.MovieId,
                BasePrice = request.BasePrice
            };
        }

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
