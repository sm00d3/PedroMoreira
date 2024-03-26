using System.ComponentModel.DataAnnotations;

namespace PedroMoreira.Domain.Core.Primitives
{
    public abstract class Entity : IEquatable<Entity>
    {
        [Key]
        public Guid Id { get; private set; }

        protected Entity(Guid id) : this()
        {
            Id = id;
        }

        protected Entity() { }

        public static bool operator !=(Entity a, Entity b) => !(a == b);
        public static bool operator ==(Entity a, Entity b)
        {
            if (a is null && b is null) return true;
            if (a is null || b is null) return false;
            return ((IEquatable<Entity>)a).Equals(b);
        }

        /// <inheritdoc/>
        public bool Equals(Entity? other)
        {
            if (other is null) return false;
            return ReferenceEquals(this, other) || Id == other.Id;
        }

        /// <inheritdoc/>
        public override int GetHashCode() => Id.GetHashCode() * 41;

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            if (obj is null) return false;

            if (ReferenceEquals(this, obj)) return true;

            if (ReferenceEquals(obj, null)) return false;

            if (obj.GetType() != GetType()) return false;

            if (!(obj is Entity other)) return false;

            if (Id == Guid.Empty || other.Id == Guid.Empty) return false;

            return Id == other.Id;
        }
    }
}
