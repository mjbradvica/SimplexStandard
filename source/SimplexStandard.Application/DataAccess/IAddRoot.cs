// <copyright file="IAddRoot.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

using SimplexStandard.Domain;

namespace SimplexStandard.Application.DataAccess
{
    public interface IAddRoot<in TRoot>
        where TRoot : IAggregateRoot
    {
        Task<IDataEnvelope> AddRoot(TRoot root, CancellationToken cancellationToken = default);
    }
}
