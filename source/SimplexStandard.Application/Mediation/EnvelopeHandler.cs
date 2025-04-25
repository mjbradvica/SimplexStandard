// <copyright file="EnvelopeHandler.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

using MediatR;

namespace SimplexStandard.Application.Mediation
{
    /// <inheritdoc />
    public abstract class EnvelopeHandler<TRequest, TResponse> : IRequestHandler<TRequest, IEnvelope<TResponse>>
        where TRequest : IRequest<IEnvelope<TResponse>>
    {
        /// <inheritdoc />
        public abstract Task<IEnvelope<TResponse>> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
