using ProjectFlow.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFlow.Core.Interfaces
{
    public interface IService<T> where T : Project
    {
        /// <summary>
        /// Retrieves all entities of type T from the data store.
        /// </summary>
        /// <returns>An enumerable collection of entities of type T.</returns>
        Task<IEnumerable<T>> Get();

        /// <summary>
        /// Retrieves an entity of type T by its ID.
        /// </summary>
        /// <param name="id">The ID of the entity to retrieve.</param>
        /// <returns>The entity with the specified ID, or null if not found.</returns>
        Task<T?> Get(string id);

        /// <summary>
        /// Creates a new entity of type T in the data store.
        /// </summary>
        /// <param name="entity">The entity to create.</param>
        /// <returns>The newly created entity.</returns>
        Task<T?> CreateAsync(T entity);

        /// <summary>
        /// Updates an existing entity of type T in the data store.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        /// <returns>The updated entity.</returns>
        Task<T?> UpdateAsync(T entity);

        /// <summary>
        /// Deletes an existing entity of type T from the data store.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        /// <returns>The deleted entity.</returns>
        Task<T?> DeleteAsync(T entity);

        /// <summary>
        /// Deletes all entities of type T from the data store.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task<IEnumerable<T>> DeleteAllAsync();

    }
}
