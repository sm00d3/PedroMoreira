using PedroMoreira.Domain.Core.Abstractions;
using PedroMoreira.Domain.Core.Primitives;
using PedroMoreira.Domain.Entities.Members;
using PedroMoreira.Domain.Entities.Projects;

namespace PedroMoreira.Domain.Entities.Authentication
{
    public class ProjectSecurity : Entity, IAuditableEntity
    {

        public Guid ProjectId { get; set; }
        
        public Guid MemberId { get; set; }

        public DateTime CreatedOnUtc { get; }

        public DateTime? ModifiedOnUtc { get; }

        public Project Project { get; set; }

        public Member Member { get; set; }

        public IEnumerable<ProjectSecurityRole> Roles { get; set; }

        public IEnumerable<ProjectSecurityClaim> Claims { get; set; }

    }
}
