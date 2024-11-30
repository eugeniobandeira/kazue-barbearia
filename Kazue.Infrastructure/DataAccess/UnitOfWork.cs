using Kazue.Domain.Interfaces;

namespace Kazue.Infrastructure.DataAccess
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly KazueDbContext _dbContext;

        public UnitOfWork(KazueDbContext kazueDbContext)
        {
            _dbContext = kazueDbContext;
        }

        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
