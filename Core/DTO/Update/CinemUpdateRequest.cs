using Core.Domain.Entities;

namespace Core.DTO.Update
{
    /// <summary>
    /// Represent Cinema update request 
    /// </summary>
    public class CinemUpdateRequest : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
    
}
