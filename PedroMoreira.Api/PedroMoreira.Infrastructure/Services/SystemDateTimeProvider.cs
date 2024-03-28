using PedroMoreira.Application.Common.Interfaces;

namespace PedroMoreira.Infrastructure.Services
{
    internal sealed class SystemDateTimeProvider : IDateTImeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
