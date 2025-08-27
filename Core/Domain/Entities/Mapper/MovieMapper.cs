using Core.DTO.Response;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Movie Entity to Response for DTO
    /// </summary>
    public class MovieMapper : IMapper<Movie, MovieResponse>
    {
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
