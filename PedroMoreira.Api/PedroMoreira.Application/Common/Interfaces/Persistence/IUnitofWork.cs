namespace PedroMoreira.Application.Common.Interfaces.Persistence
{
    public interface IUnitofWork
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
