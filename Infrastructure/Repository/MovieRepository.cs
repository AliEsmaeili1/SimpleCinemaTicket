using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;

namespace Infrastructure.Repository
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository { }
}
