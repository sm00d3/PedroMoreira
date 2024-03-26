using PedroMoreira.Domain.Core.Abstractions;
using PedroMoreira.Domain.Core.Primitives;

namespace PedroMoreira.Domain.Entities.Members
{
    public class MemberToken : Entity, IAuditableEntity, ISoftDeleteEntity
    {

        public Guid MemberId { get; set; }

        public string Value { get; set; }

        public string Token { get; set; }

        public DateTime? Expiration { get; set; }

        public DateTime CreatedOnUtc { get; }

        public DateTime? ModifiedOnUtc { get; }

        public DateTime? DeletedOnUtc { get; }

        public bool Deleted { get; }

        public Member Member { get; set; }
    }
}
