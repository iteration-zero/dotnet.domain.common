namespace IterationZero.Domain.Common
{
    /// <summary>
    /// Represents the results of an entity operation.
    /// </summary>
    public class EntityOperationResult<TEntity, TIdentity> where TEntity: Entity<TIdentity>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="EntityOperationResult{TIdentity}"/> class.
        /// </summary>
        /// <param name="entity">
        /// The entity used in the result.
        /// </param>
        public EntityOperationResult(TEntity entity)
        {
            Entity = entity;
        }

        /// <summary>
        /// Gets or sets the entity used in the result.
        /// </summary>
        public TEntity Entity { get; }
    }
}