// <copyright file="IAddRoot.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

using SimplexStandard.Domain;

namespace SimplexStandard.Application.DataAccess
{
    /// <summary>
    /// Adds a root to the persistence.
    /// </summary>
    /// <typeparam name="TRoot">The root type.</typeparam>
    public interface IAddRoot<in TRoot>
        where TRoot : IAggregateRoot
    {
        /// <summary>
        /// Adds a root to the persistence.
        /// </summary>
        /// <param name="root">The root to add.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task<IDataEnvelope> AddRoot(TRoot root, CancellationToken cancellationToken = default);
    }
}
