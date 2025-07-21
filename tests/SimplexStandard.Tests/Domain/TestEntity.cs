// <copyright file="TestEntity.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

using SimplexStandard.Domain;

namespace SimplexStandard.Tests.Domain
{
    /// <inheritdoc />
    internal class TestEntity : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestEntity"/> class.
        /// </summary>
        public TestEntity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestEntity"/> class.
        /// </summary>
        /// <param name="id">The id of the entity.</param>
        public TestEntity(Guid id)
            : base(id)
        {
        }
    }
}
