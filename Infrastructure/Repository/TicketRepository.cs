using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Infrastructure.CinemaTicketDataBase;
namespace Infrastructure.Repository
{
    public class TicketRepository 
        : BaseRepository<Ticket>, ITicketRepository 
    {
        public TicketRepository(CinemaTicketDBcontext dbContext) : base(dbContext) { }
    }
}
