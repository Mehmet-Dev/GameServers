using GameServers.Backend.Data.Interfaces;
using GameServers.Backend.Models;
using GameServers.Backend.Models.Enums;
using GameServers.Backend.Services.Interfaces;

namespace GameServers.Backend.Services;

public class UserService : IUserService
{
    private readonly IUserData _users;

    public UserService(IUserData users)
        => _users = users;

    public Task<User?> Create(User user)
        => _users.Create(user);

    public Task<User?> GetById(long id)
        => _users.GetById(id);

    public Task<List<User>> GetAll()
        => _users.GetAll();

    public Task<bool> Update(User user)
        => _users.Update(user);

    public Task<bool> DeleteById(long id)
        => _users.DeleteById(id);

    public Task<User?> GetByUsername(string username)
        => _users.GetByUsername(username);

    public Task<bool> UsernameExists(string username)
        => _users.UsernameExists(username);

    public Task<List<User>> GetByRole(UserRole role)
        => _users.GetByRole(role);

    public Task<List<User>> GetAllIncludingDeleted()
        => _users.GetAllIncludingDeleted();
}