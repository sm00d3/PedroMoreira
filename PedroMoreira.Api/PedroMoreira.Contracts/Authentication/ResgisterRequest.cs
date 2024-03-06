using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedroMoreira.Contracts.Authentication
{
    public record ResgisterRequest (
        string FirstName,
        string LastName,
        string Email,
        string Password
    );
}
