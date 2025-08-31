using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Infrastructure.CinemaTicketDataBase;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class CinemaRepository:BaseRepository<Cinema>,ICinemaRepository
    {
        public CinemaRepository(CinemaTicketDBcontext dbContext) : base(dbContext) { }

        public IEnumerable<ShowTime>MovieOnCinema(int cinemaId)
        {
            return _dbContext.Set<Hall>()
                 .Where(h => h.CinemaId == cinemaId)
                 .SelectMany(h => h.ShowTimes);
        }

    }
}
