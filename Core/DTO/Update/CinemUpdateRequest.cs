using Core.Domain.Entities;

namespace Core.DTO.Update
{
    /// <summary>
    /// Represent Cinema update request 
    /// </summary>
    public class CinemUpdateRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public Cinema ToCinema()
        {
            return new Cinema()
            {
                Address = Address,
                Name = Name
            };
        }
    }
    
}
