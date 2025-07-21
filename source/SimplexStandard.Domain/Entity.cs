// <copyright file="Entity.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace SimplexStandard.Domain
{
    /// <inheritdoc cref="IEntity" />
    public abstract class Entity : IEntity, IEquatable<IEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity"/> class.
        /// </summary>
        protected Entity()
            : this(Guid.CreateVersion7())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Entity"/> class.
        /// </summary>
        /// <param name="id">The identifier for the entity.</param>
        protected Entity(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id), "The identifier may not be empty.");
            }

            Id = id;
        }

        /// <inheritdoc/>
        public Guid Id { get; init; }

        /// <inheritdoc/>
        public bool Equals(IEntity? other)
        {
            return Id == other?.Id;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            if (obj is IEntity entity)
            {
                return Equals(entity);
            }

            return false;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
