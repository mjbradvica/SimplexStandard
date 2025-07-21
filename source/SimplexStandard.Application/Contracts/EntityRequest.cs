// <copyright file="EntityRequest.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;
using SimplexStandard.Application.Mediation;

namespace SimplexStandard.Application.Contracts
{
    /// <inheritdoc />
    public abstract class EntityRequest<TResponse> : IEnvelopeRequest<TResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRequest{TResponse}"/> class.
        /// </summary>
        /// <param name="id">The id of the entity request.</param>
        protected EntityRequest(Guid id)
        {
            Id = id;
        }

        /// <summary>
        /// Gets the id of the request.
        /// </summary>
        [Required]
        public Guid Id { get; init; }
    }
}
