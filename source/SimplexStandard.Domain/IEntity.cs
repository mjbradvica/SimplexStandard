// <copyright file="IEntity.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace SimplexStandard.Domain
{
    /// <summary>
    /// Base interface for all entities.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Gets the identifier of the entity.
        /// </summary>
        public Guid Id { get; }
    }
}
