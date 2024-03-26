using PedroMoreira.Domain.Core.Abstractions;
using PedroMoreira.Domain.Core.Primitives;
using PedroMoreira.Domain.Entities.Authentication;

namespace PedroMoreira.Domain.Entities.Projects
{
    public class Project : Entity, IAuditableEntity, ISoftDeleteEntity
    {
        public string Name { get; set; }

        public DateTime CreatedOnUtc { get; }

        public DateTime? ModifiedOnUtc { get; }

        public DateTime? DeletedOnUtc { get; }

        public bool Deleted { get; }
        
        public IEnumerable<ProjectSecurity> ProjectSecurity { get; set; }
    }
}
