using Core.Domain.Entities;
using Core.Domain.Enums;

namespace Core.DTO.Response
{
    /// <summary>
    /// Represent Movie Response DTO
    /// </summary>
    public class MovieResponse
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public TimeSpan Duration { get; set; }//int represent second
        public GenerEnums Gener { get; set; }
    }
}
