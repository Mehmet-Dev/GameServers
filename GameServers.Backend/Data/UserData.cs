using GameServers.Backend.Data.Interfaces;
using GameServers.Backend.Models;
using GameServers.Backend.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace GameServers.Backend.Data;

public class UserData : IUserData
{
    private readonly GameServersContext _context;

    public UserData(GameServersContext context)
        => _context = context;

    public async Task<User?> Create(User user)
    {
        _context.Users.Add(user);
        var affected = await _context.SaveChangesAsync();

        if(affected == 0) // 0 rows affected
            return null;
        
        return user;
    }

    public async Task<User?> GetById(long id)
        => await _context.Users.FindAsync(id);
    
    public async Task<List<User>> GetAll()
        => await _context.Users.ToListAsync();
    
    public async Task<bool> Update(User user)
    {
        _context.Users.Update(user);

        var affected = await _context.SaveChangesAsync();

        if(affected == 0)
            return false;
        
        return true;
    }

    public async Task<bool> DeleteById(long id)
    {
        var user = await GetById(id);

        if(user == null)
            return false;

        user.DeletedAt = DateTimeOffset.UtcNow; // soft delete

        var result = await Update(user);

        return result;
    }

    public async Task<User?> GetByUsername(string username)
    {
        var user = await _context.Users
            .Where(u => u.Username == username).FirstOrDefaultAsync();
        
        return user;
    }

    public async Task<bool> UsernameExists(string username)
        => await GetByUsername(username) != null;
    
    public async Task<List<User>> GetByRole(UserRole role)
        => await _context.Users
            .Where(u => u.Role == role)
            .ToListAsync();
    
    public async Task<List<User>> GetAllIncludingDeleted()
        => await _context.Users.IgnoreQueryFilters().ToListAsync();
}