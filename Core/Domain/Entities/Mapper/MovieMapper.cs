using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;
using System.Diagnostics.Metrics;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Movie Entity to Response for DTO
    /// </summary>
    public class MovieMapper : IMapper<Movie, MovieResponse>
    {
        public Movie ToEntity<TInput>(TInput input) where TInput : class
        {
            return input switch
            {
                MovieAddRequest request => new Movie()
                {
                    Title= request.Title,
                    Duration= request.Duration,
                    Gener = request.Gener
                },
                MovieUpdateRequest update => new Movie()
                {
                    Id = update.Id,
                    Title = update.Title,
                    Duration = update.Duration,
                    Gener = update.Gener
                },
                _ => throw new ArgumentException($"Unsupported input type: {typeof(TInput).Name}")
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
