<?xml version="1.0"?>
<doc>
    <assembly>
        <name>ProjectFlow.Core</name>
    </assembly>
    <members>
        <member name="M:ProjectFlow.Core.Interfaces.IRepository`1.Get">
            <summary>
            Retrieves all entities of type T from the data store.
            </summary>
            <returns>An enumerable collection of entities of type T.</returns>
        </member>
        <member name="M:ProjectFlow.Core.Interfaces.IRepository`1.Get(System.String)">
            <summary>
            Retrieves an entity of type T by its ID.
            </summary>
            <param name="id">The ID of the entity to retrieve.</param>
            <returns>The entity with the specified ID, or null if not found.</returns>
        </member>
        <member name="M:ProjectFlow.Core.Interfaces.IRepository`1.CreateAsync(`0)">
            <summary>
            Creates a new entity of type T in the data store.
            </summary>
            <param name="entity">The entity to create.</param>
            <returns>The newly created entity.</returns>
        </member>
        <member name="M:ProjectFlow.Core.Interfaces.IRepository`1.UpdateAsync(`0)">
            <summary>
            Updates an existing entity of type T in the data store.
            </summary>
            <param name="entity">The entity to update.</param>
            <returns>The updated entity.</returns>
        </member>
        <member name="M:ProjectFlow.Core.Interfaces.IRepository`1.DeleteAsync(`0)">
            <summary>
            Deletes an existing entity of type T from the data store.
            </summary>
            <param name="entity">The entity to delete.</param>
            <returns>The deleted entity.</returns>
        </member>
        <member name="M:ProjectFlow.Core.Interfaces.IRepository`1.DeleteAllAsync">
            <summary>
            Deletes all entities of type T from the data store.
            </summary>
            <returns>A task that represents the asynchronous operation.</returns>
        </member>
        <member name="M:ProjectFlow.Core.Interfaces.IService`1.Get">
            <summary>
            Retrieves all entities of type T from the data store.
            </summary>
            <returns>An enumerable collection of entities of type T.</returns>
        </member>
        <member name="M:ProjectFlow.Core.Interfaces.IService`1.Get(System.String)">
            <summary>
            Retrieves an entity of type T by its ID.
            </summary>
            <param name="id">The ID of the entity to retrieve.</param>
            <returns>The entity with the specified ID, or null if not found.</returns>
        </member>
        <member name="M:ProjectFlow.Core.Interfaces.IService`1.CreateAsync(`0)">
            <summary>
            Creates a new entity of type T in the data store.
            </summary>
            <param name="entity">The entity to create.</param>
            <returns>The newly created entity.</returns>
        </member>
        <member name="M:ProjectFlow.Core.Interfaces.IService`1.UpdateAsync(`0)">
            <summary>
            Updates an existing entity of type T in the data store.
            </summary>
            <param name="entity">The entity to update.</param>
            <returns>The updated entity.</returns>
        </member>
        <member name="M:ProjectFlow.Core.Interfaces.IService`1.DeleteAsync(`0)">
            <summary>
            Deletes an existing entity of type T from the data store.
            </summary>
            <param name="entity">The entity to delete.</param>
            <returns>The deleted entity.</returns>
        </member>
        <member name="M:ProjectFlow.Core.Interfaces.IService`1.DeleteAllAsync">
            <summary>
            Deletes all entities of type T from the data store.
            </summary>
            <returns>A task that represents the asynchronous operation.</returns>
        </member>
        <member name="P:ProjectFlow.Core.Models.Project.Id">
            <summary>
            The primary key for the project entity.
            </summary>
        </member>
        <member name="P:ProjectFlow.Core.Models.Project.Name">
            <summary>
            The name of the project.
            </summary>
        </member>
        <member name="P:ProjectFlow.Core.Models.Project.Description">
            <summary>
            A description of the project.
            </summary>
        </member>
        <member name="P:ProjectFlow.Core.Models.Project.GitHubUrl">
            <summary>
            The URL of the project's GitHub repository.
            </summary>
        </member>
    </members>
</doc>
