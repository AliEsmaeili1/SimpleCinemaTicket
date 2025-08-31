using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Infrastructure.CinemaTicketDataBase;


namespace Infrastructure.Repository
{
    public class ShowTimeRepository 
        : BaseRepository<ShowTime>,IShowtimeRepository 
    {
        public ShowTimeRepository(CinemaTicketDBcontext dbContext) : base(dbContext) { }

      
    }
}
