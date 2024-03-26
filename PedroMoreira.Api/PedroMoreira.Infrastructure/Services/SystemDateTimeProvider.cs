using PedroMoreira.Application.Common.Interfaces;

namespace PedroMoreira.Infrastructure.Services
{
    public class SystemDateTimeProvider : IDateTImeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
