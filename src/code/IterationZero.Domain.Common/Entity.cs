using System;

namespace IterationZero.Domain.Common
{
    /// <summary>
    /// Defines the base structure for an entity.
    /// </summary>
    public abstract class Entity<TIdentity>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the entity.
        /// </summary>
        public TIdentity Id { get; set; }
    }
}