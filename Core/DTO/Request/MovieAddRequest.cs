using Core.Domain.Entities;
using Core.Domain.Enums;

namespace Core.DTO.Request
{
    /// <summary>
    /// Represent Movie Request DTO
    /// </summary>
    public class MovieAddRequest
    {
        public string? Title { get; set; }
        public TimeSpan Duration { get; set; }//int represent second
        public GenerEnums Gener { get; set; }

    }
}
