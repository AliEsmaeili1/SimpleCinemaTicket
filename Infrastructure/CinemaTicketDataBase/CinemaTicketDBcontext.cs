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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ticket → ShowTime (keep cascade if preferred)
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.ShowTime)
                .WithMany(st => st.Tickets)
                .HasForeignKey(t => t.ShowTimeId)
                .OnDelete(DeleteBehavior.Cascade); // or Restrict/NoAction

            // Ticket → User (disable cascade)
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.User)
                .WithMany(u => u.Tickets)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Restrict); // or NoAction

            // Ticket → Seat (disable cascade)
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Seat)
                .WithMany(s => s.Tickets)
                .HasForeignKey(t => t.SeatId)
                .OnDelete(DeleteBehavior.Restrict); // or NoAction
        }
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
