// <copyright file="IEnvelope.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace SimplexStandard.Application.Mediation
{
    /// <summary>
    /// Base interface for communication inside the application.
    /// </summary>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    public interface IEnvelope<out TResponse>
    {
        /// <summary>
        /// Gets the response from the application.
        /// </summary>
        public TResponse Response { get; }
    }
}
