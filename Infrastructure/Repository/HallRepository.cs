using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Infrastructure.CinemaTicketDataBase;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class HallRepository:BaseRepository<Hall>,IHallRepository
    {
        public HallRepository(CinemaTicketDBcontext dbContext) : base(dbContext) { }

        public Hall? GetByIdAndShowTime(int hall_id)
        {
            return _dbSet.Include(h => h.ShowTimes).FirstOrDefault(item => item.Id == hall_id);
        }
    }
}
