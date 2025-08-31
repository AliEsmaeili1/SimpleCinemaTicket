using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Entity to Response for DTO
    /// </summary>
    public class ShowTimeMapper : IMapper<ShowTime, ShowTimeResponse>
    {
        public ShowTime ToEntity<TInput>(TInput input) where TInput : class
        {
            return input switch
            {
                ShowTimeAddRequest request => new ShowTime()
                {
                    StartAt = request.StartAt,
                    BasePrice = request.BasePrice,
                    MovieId = request.MovieId,
                    HallId = request.HallId,
                },
                ShowTimeUpdateRequest update => new ShowTime()
                {
                    Id = update.Id,
                    StartAt = update.StartAt,
                    BasePrice = update.BasePrice,
                    MovieId = update.MovieId,
                    HallId = update.HallId,

                },
                _ => throw new ArgumentException($"Unsupported input type: {typeof(TInput).Name}")
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
