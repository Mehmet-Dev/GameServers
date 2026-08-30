namespace GameServers.Backend.Data.Interfaces;

/// <summary>
/// Default methods every table needs.
/// If some methods aren't needed in a data layer, simply make them return nothing.
/// </summary>
/// <typeparam name="T">Model object to be based off of the database</typeparam>
public interface IDataInterface<T>
{
    Task<T?> Create(T data);
    Task<T?> GetById(long id);
    Task<List<T>> GetAll();
    Task<bool> Update(T data);
    Task<bool> DeleteById(long id);
}