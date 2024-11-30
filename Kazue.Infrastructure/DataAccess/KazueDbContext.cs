using Kazue.Domain.Entities.Barber;
using Kazue.Domain.Entities.Cliient;
using Kazue.Domain.Entities.QueueEntity;
using Microsoft.EntityFrameworkCore;

namespace Kazue.Infrastructure.DataAccess
{
    public class KazueDbContext : DbContext
    {
        public KazueDbContext(DbContextOptions<KazueDbContext> options) : base(options) { }

        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<BarberEntity> Barbers { get; set; }
        public DbSet<QueueEntity> QueueEntries { get; set; }

    }
}
