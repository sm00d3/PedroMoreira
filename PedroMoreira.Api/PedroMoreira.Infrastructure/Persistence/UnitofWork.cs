using PedroMoreira.Application.Common.Interfaces.Persistence;

namespace PedroMoreira.Infrastructure.Persistence
{
    internal sealed class UnitofWork(PostgresContext context) : IUnitofWork
    {

        private readonly PostgresContext _dbContext = context;


        public Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
