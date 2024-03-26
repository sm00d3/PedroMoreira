using PedroMoreira.Application.Common.Interfaces.Repository;
using PedroMoreira.Domain.Entities.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedroMoreira.Infrastructure.Persistence.Repository
{
    internal sealed class UserRepository(PostgresContext context): IUserRepository
    {
        private readonly PostgresContext _context = context;

        //public async Task<Member?> GetByEmailAsync(string email, CancellationToken cancellationToken)
        //{
        //    return await _context.Set<Member>()
        //        .FirstOrDefaultAsync(u => u.Email!.Equals(email, StringComparison.CurrentCultureIgnoreCase), cancellationToken);
        //}

        //public async Task<Member> GetByIdWithProfileAsync(Guid id, CancellationToken cancellationToken)
        //{
        //    return await _context.Set<Member>()
        //        .Include(up => up.Profile)
        //        .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
        //}

        public void Add(Member user)
        {
            _context.Set<Member>().Add(user);
        }

        public void Update(Member user)
        {
            _context.Set<Member>().Update(user);
        }

        public void Remove(Member user)
        {
            _context.Set<Member>().Remove(user);
        }
    }
}
