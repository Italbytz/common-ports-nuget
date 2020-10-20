using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExplicitArchitecture
{
    /// <summary>
    /// A generic repository.
    /// </summary>
    public interface IRepository<TId, TEntity>
    {
        /// <summary>
        /// Create an entity.
        /// </summary>
        /// <param name="entity">The entity to create.</param>
        /// <returns>ID of the created entity.</returns>
        Task<Result<TId>> Create(TEntity entity);

        /// <summary>
        /// Retrieves an entity.
        /// </summary>
        /// <param name="id">ID of the entity to retrieve.</param>
        /// <returns>An entity.</returns>
        Task<Result<TEntity>> Retrieve(TId id);

        /// <summary>
        /// Retrieves all entities.
        /// </summary>
        /// <returns>All entities.</returns>
        Task<Result<List<TEntity>>> RetrieveAll();

        /// <summary>
        /// Updates an entity.
        /// </summary>
        /// <param name="id">ID of the entity to update.</param>
        /// <param name="entity">Updated entity.</param>
        /// <returns>Boolean indicating success or failure.</returns>
        Task<Result<bool>> Update(TId id, TEntity entity);

        /// <summary>
        /// Deletes an entity.
        /// </summary>
        /// <param name="id">ID of the entity to delete.</param>
        /// <returns>Boolean indicating success or failure.</returns>
        Task<Result<bool>> Delete(TId id);
    }
}
