// <copyright file="EmptyEnvelopeHandler.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

using MediatR;

namespace SimplexStandard.Application.Mediation
{
    /// <inheritdoc />
    public abstract class EmptyEnvelopeHandler<TRequest> : EnvelopeHandler<TRequest, Unit>
        where TRequest : IRequest<IEnvelope<Unit>>
    {
    }
}
