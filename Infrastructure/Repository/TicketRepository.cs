using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
namespace Infrastructure.Repository
{
    public class TicketRepository 
        : BaseRepository<Ticket>, ITicketRepository { }
}
