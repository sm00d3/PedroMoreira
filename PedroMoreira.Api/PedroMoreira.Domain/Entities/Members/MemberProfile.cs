using PedroMoreira.Domain.Core.Abstractions;

namespace PedroMoreira.Domain.Entities.Members
{

    public class MemberProfile : Core.Primitives.Entity, IAuditableEntity, ISoftDeleteEntity
    {

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public Guid MemberId { get; set; }

        public DateTime CreatedOnUtc { get; }

        public DateTime? ModifiedOnUtc { get; }

        public DateTime? DeletedOnUtc { get; }

        public bool Deleted { get; }

        public Member? User { get; set; }
    }
}
