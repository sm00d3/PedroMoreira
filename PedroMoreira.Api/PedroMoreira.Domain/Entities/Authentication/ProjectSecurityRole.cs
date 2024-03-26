using PedroMoreira.Domain.Core.Abstractions;
using PedroMoreira.Domain.Core.Primitives;

namespace PedroMoreira.Domain.Entities.Authentication
{
    public class ProjectSecurityRole : Entity, IAuditableEntity, ISoftDeleteEntity
    {        
        public Guid ProjectSecurityId { get; set; }

        public string Value { get; set; }

        public DateTime CreatedOnUtc { get; }
        
        public DateTime? ModifiedOnUtc { get; }
       
        public DateTime? DeletedOnUtc { get; }

        public bool Deleted { get; }

        public ProjectSecurity ProjectSecurity { get; set; }
    }
}
