using GameServers.Backend.Data.Interfaces;
using GameServers.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace GameServers.Backend.Data;

public class ServerLogData : IServerLogData
{
    private GameServersContext _context;

    public ServerLogData(GameServersContext context)
        => _context = context;

    public async Task<ServerLog?> Create(ServerLog log)
    {
        _context.ServerLogs.Add(log);

        var affected = await _context.SaveChangesAsync();

        if (affected == 0)
            return null;

        return log;
    }

    public async Task<ServerLog?> GetById(long id)
        => await _context.ServerLogs.FindAsync(id);

    public async Task<List<ServerLog>> GetAll()
        => await _context.ServerLogs.ToListAsync();

    public async Task<bool> Update(ServerLog log)
    {
        _context.ServerLogs.Update(log);

        var affected = await _context.SaveChangesAsync();

        if (affected == 0)
            return false;

        return true;
    }

    public Task<bool> DeleteById(long id)
    {
        throw new NotSupportedException("Server logs cannot be deleted.");
    }

    public async Task<List<ServerLog>> GetByServerId(long serverId)
        => await _context.ServerLogs
            .Where(log => log.ServerId == serverId)
            .ToListAsync();

    public async Task<List<ServerLog>> GetByDateRange(
        long serverId,
        DateTimeOffset from,
        DateTimeOffset to)
        => await _context.ServerLogs
            .Where(log =>
                log.ServerId == serverId &&
                log.CreatedAt >= from &&
                log.CreatedAt <= to)
            .ToListAsync();

    public async Task<List<ServerLog>> GetLatest(long serverId, int amount)
        => await _context.ServerLogs
            .Where(log => log.ServerId == serverId)
            .OrderByDescending(log => log.CreatedAt)
            .Take(amount)
            .ToListAsync();
}