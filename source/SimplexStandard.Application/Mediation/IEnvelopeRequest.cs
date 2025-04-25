// <copyright file="IEnvelopeRequest.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

using MediatR;

namespace SimplexStandard.Application.Mediation
{
    /// <inheritdoc />
    public interface IEnvelopeRequest : IRequest<IEnvelope<Unit>>
    {
    }

    /// <inheritdoc />
    public interface IEnvelopeRequest<out TResponse> : IRequest<IEnvelope<TResponse>>
    {
    }
}
