using GameServers.Backend.Data.Interfaces;
using GameServers.Backend.Models;
using GameServers.Backend.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace GameServers.Backend.Data;

public class GameServerData : IGameServerData
{
    private readonly GameServersContext _context;

    public GameServerData(GameServersContext context)
        => _context = context;

    public async Task<GameServer?> Create(GameServer server)
    {
        _context.GameServers.Add(server);
        var affected = await _context.SaveChangesAsync();

        if (affected == 0)
            return null;

        return server;
    }

    public async Task<GameServer?> GetById(long id)
        => await _context.GameServers.FindAsync(id);

    public async Task<List<GameServer>> GetAll()
        => await _context.GameServers.ToListAsync();

    public async Task<bool> Update(GameServer server)
    {
        _context.GameServers.Update(server);

        var affected = await _context.SaveChangesAsync();

        if (affected == 0)
            return false;

        return true;
    }

    public Task<bool> DeleteById(long id) // no delete allowed
    {
        throw new NotSupportedException("Game servers cannot be deleted.");
    }

    public async Task<List<GameServer>> GetByGameName(string gameName)
        => await _context.GameServers
            .Where(s => s.GameName == gameName)
            .ToListAsync();
    
    public async Task<List<GameServer>> GetByStatus(ServerStatus status)
        => await _context.GameServers
            .Where(s => s.Status == status)
            .ToListAsync();
    
    public async Task<List<GameServer>> GetByUser(long userId)
        => await _context.GameServers
            .Where(s => s.CreatedBy == userId)
            .ToListAsync();
    
    public async Task<List<GameServer>> GetRunningServers()
        => await _context.GameServers
            .Where(s => s.Status == ServerStatus.Running)
            .ToListAsync();
}