using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;

namespace Infrastructure.Repository
{
    public class UserRepository 
        : BaseRepository<User>, IUserRepository { }
}
