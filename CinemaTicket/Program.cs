using Core.BusinessLogicContracts;
using Core.BusinessLogicServices;
using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Infrastructure.CinemaTicketDataBase;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddScoped<IUserServiceContracts, UserServices>();
            services.AddScoped<ITicketServiceContracts, TicketService>();
            services.AddScoped<IShowTimeContracts, ShowTimeService>();
            services.AddScoped<ISeatServiceContracts, SeatService>();
            services.AddScoped<IMovieServiceContracts, MovieService>();
            services.AddScoped<IHallServiceContracts, HallService>();
            services.AddScoped<ICinemaRepository, CinemaService>();

            //Repository DIP
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<IShowtimeRepository, ShowTimeRepository>();
            services.AddScoped<ISeatRepository, SeatRepository>();
            services.AddScoped<IHallRepository, HallRepository>();
            services.AddScoped<ICinemaRepository, CinemaRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();

            //Database
            services.AddDbContext<CinemaTicketDBcontext>(options =>
                options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=CinemaTicketDataBase;" +
                "Integrated Security=True;Connect Timeout=30;" +
                "Encrypt=False;Trust Server Certificate=False;Application Intent=" +
                "ReadWrite;Multi Subnet Failover=False"));




        }
    }
}
