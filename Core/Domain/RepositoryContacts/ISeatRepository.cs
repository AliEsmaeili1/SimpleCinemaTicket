using Core.Domain.Entities;
namespace Core.Domain.RepositoryContacts
{
    /// <summary>
    /// Domain Repository Seat
    /// </summary>
    public interface ISeatRepository : IBaseRespository<Seat> 
    {
        Seat? GetSeatById(int seatId);
        bool DeleteAll(int hallId);
    }
}
