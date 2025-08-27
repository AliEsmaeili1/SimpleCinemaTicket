using Core.Domain.Entities;
using Core.Domain.Enums;

namespace Core.DTO.Update
{
    /// <summary>
    /// Represent Movie update request 
    /// </summary>
    public class MovieUpdateRequest
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public TimeSpan Duration { get; set; }//int represent second
        public GenerEnums Gener { get; set; }
        public Movie ToMovie()
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
