using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.CinemaTicketDataBase
{
    public class CinemaTicketDBcontext:DbContext
    {
        public CinemaTicketDBcontext(DbContextOptions<CinemaTicketDBcontext> option)
            : base(option) { }

        public DbSet<User> User { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<ShowTime> ShowTime { get; set; }
        public DbSet<Seat> Seat { get; set; }
        public DbSet<Hall> Hall { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Cinema> Cinema { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial" +
                " Catalog=CinemaTicketDataBase;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;" +
                "Trust Server Certificate=False;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }
    }
}
