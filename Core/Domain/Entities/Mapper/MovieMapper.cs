using Core.DTO.Request;
using Core.DTO.Response;
using System.Diagnostics.Metrics;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Movie Entity to Response for DTO
    /// </summary>
    public class MovieMapper : IMapper<Movie, MovieResponse, MovieAddRequest>
    {
        public Movie ToEntity(MovieAddRequest request)
        {
            return new Movie()
            {
                Title = request.Title,
                Duration = request.Duration,
                Gener = request.Gener
            };
        }

        public MovieResponse ToResponseDomain(Movie entity)
        {
            return new MovieResponse
            {
                Id = entity.Id,
                Title = entity.Title,
                Duration = entity.Duration,
                Gener = entity.Gener
            };
        }
    }
}
