// <copyright file="AggregateRoot.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

using MediatR;

namespace SimplexStandard.Domain
{
    /// <inheritdoc cref="IAggregateRoot" />
    public abstract class AggregateRoot : Entity, IAggregateRoot
    {
        private readonly List<INotification> _domainEvents;

        /// <inheritdoc />
        protected AggregateRoot()
        {
            _domainEvents = new List<INotification>();
        }

        /// <inheritdoc />
        protected AggregateRoot(Guid id)
            : base(id)
        {
            _domainEvents = new List<INotification>();
        }

        /// <inheritdoc/>
        public IEnumerable<INotification> DomainEvents => _domainEvents.AsEnumerable();

        /// <summary>
        /// Adds a domain event to the entity.
        /// </summary>
        /// <param name="domainEvent">An instance of the <see cref="INotification"/> interface.</param>
        public void AppendDomainEvent(INotification domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
    }
}
