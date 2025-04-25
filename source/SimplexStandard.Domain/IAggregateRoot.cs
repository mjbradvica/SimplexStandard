// <copyright file="IAggregateRoot.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

using MediatR;

namespace SimplexStandard.Domain
{
    /// <inheritdoc />
    public interface IAggregateRoot : IEntity
    {
        /// <summary>
        /// Gets the domain events for a root.
        /// </summary>
        public IEnumerable<INotification> DomainEvents { get; }
    }
}
