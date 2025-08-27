using Core.Domain.Entities;
using Core.Domain.Enums;

namespace Core.DTO.Request
{
    /// <summary>
    /// Represent Movie Request DTO
    /// </summary>
    public class MovieAddRequest:IRequest<Movie>
    {
        public string? Title { get; set; }
        public TimeSpan Duration { get; set; }//int represent second
        public GenerEnums Gener { get; set; }

        public Movie ToDomain()
        {
            return new Movie()
            {
                Title = Title,
                Duration = Duration,
                Gener = Gener
            };
        }
    }
}
