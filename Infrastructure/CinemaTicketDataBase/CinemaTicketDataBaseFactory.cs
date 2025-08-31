using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace Infrastructure.CinemaTicketDataBase
{
    public class CinemaTicketDataBaseFactory: 
        IDesignTimeDbContextFactory<CinemaTicketDBcontext>
    {
        public CinemaTicketDBcontext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CinemaTicketDBcontext>();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=CinemaTicketDataBase;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;" +
                "Trust Server Certificate=False;Application Intent=ReadWrite;" +
                "Multi Subnet Failover=False");
            return new CinemaTicketDBcontext(optionsBuilder.Options);
        }
    }
}
