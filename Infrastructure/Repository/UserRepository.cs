using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Infrastructure.CinemaTicketDataBase;

namespace Infrastructure.Repository
{
    public class UserRepository 
        : BaseRepository<User>, IUserRepository 
    {
        public UserRepository(CinemaTicketDBcontext dbContext):base(dbContext) { }
    }
}
