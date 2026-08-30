using GameServers.Backend.Data.Interfaces;
using GameServers.Backend.Models;
using GameServers.Backend.Services.Interfaces;

namespace GameServers.Backend.Services;

public class ServerLogService : IServerLogService
{
    private readonly IServerLogData _logs;

    public ServerLogService(IServerLogData logs)
        => _logs = logs;

    public Task<ServerLog?> Create(ServerLog log)
        => _logs.Create(log);

    public Task<ServerLog?> GetById(long id)
        => _logs.GetById(id);

    public Task<List<ServerLog>> GetAll()
        => _logs.GetAll();

    public Task<bool> Update(ServerLog log)
        => _logs.Update(log);

    public Task<bool> DeleteById(long id)
        => _logs.DeleteById(id);

    public Task<List<ServerLog>> GetByServerId(long serverId)
        => _logs.GetByServerId(serverId);

    public Task<List<ServerLog>> GetByDateRange(
        long serverId,
        DateTimeOffset from,
        DateTimeOffset to)
        => _logs.GetByDateRange(serverId, from, to);

    public Task<List<ServerLog>> GetLatest(long serverId, int amount)
        => _logs.GetLatest(serverId, amount);
}