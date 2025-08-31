using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Infrastructure.CinemaTicketDataBase;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repository
{
    public class SeatRepository : BaseRepository<Seat>, ISeatRepository
    {
        public SeatRepository(CinemaTicketDBcontext dbContext) : base(dbContext) { }

        public bool DeleteAll(int hallId)
        {
            var itemsToDelete = _dbSet.Where(i => i.HallId == hallId).ToList();

            _dbSet.RemoveRange(itemsToDelete);

            _dbContext.SaveChanges();
            return true;
        }

        public Seat? GetSeatById(int seatId)
        {
            return _dbSet.Include(s => s.Tickets).FirstOrDefault(s => s.Id == seatId);
        }
    }
}
