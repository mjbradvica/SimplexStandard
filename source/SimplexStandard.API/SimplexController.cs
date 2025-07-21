// <copyright file="SimplexController.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SimplexStandard.API
{
    /// <inheritdoc />
    [ApiController]
    public abstract class SimplexController : ControllerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimplexController"/> class.
        /// </summary>
        /// <param name="mediator">An instance of the <see cref="IMediator"/> instance.</param>
        protected SimplexController(IMediator mediator)
        {
            Mediator = mediator;
        }

        /// <summary>
        /// Gets the Mediator instance.
        /// </summary>
        protected IMediator Mediator { get; }
    }
}
