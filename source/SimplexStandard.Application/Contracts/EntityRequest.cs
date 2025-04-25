// <copyright file="EntityRequest.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

namespace SimplexStandard.Application.Contracts
{
    public abstract class EntityRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRequest"/> class.
        /// </summary>
        /// <param name="id"></param>
        protected EntityRequest(Guid id)
        {
            Id = id;
        }

        [Required]
        public Guid Id { get; init; }
    }
}
