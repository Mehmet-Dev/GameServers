namespace GameServers.Backend.Services.Interfaces;

public interface IServiceInterface<T>
{
    Task<T?> Create(T data);
    Task<T?> GetById(long id);
    Task<List<T>> GetAll();
    Task<bool> Update(T data);
    Task<bool> DeleteById(long id);
}