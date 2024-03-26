using PedroMoreira.Domain.Entities.Members;

namespace PedroMoreira.Application.Common.Interfaces.Repository
{
    public interface IUserRepository
    {
        //Task<Member?> GetByEmailAsync(string email, CancellationToken cancellationToken);

        //Task<Member> GetByIdWithProfileAsync(Guid id, CancellationToken cancellationToken);

        void Add(Member user);
        
        void Update(Member user);
        
        void Remove(Member user);
    }
}
