using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedroMoreira.Application.Common.Interfaces
{
    public interface IDateTImeProvider
    {
        public DateTime UtcNow { get; }
    }
}
