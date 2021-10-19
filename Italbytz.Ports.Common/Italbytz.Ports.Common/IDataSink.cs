using System;
using System.Threading.Tasks;

namespace Italbytz.Ports.Common
{
    /// <summary>
    /// A data sink (the CUD of a CRUD Repository).
    /// </summary>
    public interface IDataSink<TId, TEntity>
    {
        /// <summary>
        /// Create an entity.
        /// </summary>
        /// <param name="entity">The entity to create.</param>
        /// <returns>ID of the created entity.</returns>
        Task<Result<TId>> Create(TEntity entity);

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
