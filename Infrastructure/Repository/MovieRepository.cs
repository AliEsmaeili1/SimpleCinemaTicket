using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Infrastructure.CinemaTicketDataBase;

namespace Infrastructure.Repository
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository 
    {
        public MovieRepository(CinemaTicketDBcontext dbContext) : base(dbContext) { }
    }
}
