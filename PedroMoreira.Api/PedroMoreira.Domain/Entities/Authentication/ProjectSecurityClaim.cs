using PedroMoreira.Domain.Core.Abstractions;
using PedroMoreira.Domain.Core.Primitives;

namespace PedroMoreira.Domain.Entities.Authentication
{
    public class ProjectSecurityClaim : Entity, IAuditableEntity
    {
        public Guid ProjectSecurityId { get; set; }

        public string ClaimValue { get; set; }

        public string ClaimType { get; set; }

        public DateTime CreatedOnUtc { get; }

        public DateTime? ModifiedOnUtc { get; }

        public ProjectSecurity ProjectSecurity { get; set; }
    }
}
