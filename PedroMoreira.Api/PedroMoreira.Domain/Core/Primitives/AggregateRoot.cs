﻿namespace PedroMoreira.Domain.Core.Primitives
{
    public abstract class AggregateRoot : Entity
    {
        protected AggregateRoot(Guid id) : base(id) { }

        protected AggregateRoot() { }

    }
}
