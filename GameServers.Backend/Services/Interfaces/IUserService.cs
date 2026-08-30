using GameServers.Backend.Models;
using GameServers.Backend.Models.Enums;

namespace GameServers.Backend.Services.Interfaces;

public interface IUserService : IServiceInterface<User>
{
    Task<User?> GetByUsername(string username);
    Task<bool> UsernameExists(string username);
    Task<List<User>> GetByRole(UserRole role);
    Task<List<User>> GetAllIncludingDeleted();
}