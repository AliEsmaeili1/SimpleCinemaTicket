using Core.Domain.Entities;

namespace Core.DTO.Update
{
    /// <summary>
    /// Represent Hall update request 
    /// </summary>
    public class HallUpdateRequest : IEntity
    {
        public int Id { get; set; }
        public int CinemaId { get; set; }
        public int Capacity { get; set; }
     
    }
  
}
