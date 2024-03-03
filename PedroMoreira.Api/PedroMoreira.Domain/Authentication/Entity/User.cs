using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedroMoreira.Domain.Authentication.Entity
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
    }
}
