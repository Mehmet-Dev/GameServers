using GameServers.Backend.Models;

namespace GameServers.Backend.Services.Interfaces;

public interface IServerLogService : IServiceInterface<ServerLog>
{
    Task<List<ServerLog>> GetByServerId(long serverId);
    Task<List<ServerLog>> GetByDateRange(
        long serverId,
        DateTimeOffset from,
        DateTimeOffset to);
    Task<List<ServerLog>> GetLatest(long serverId, int amount);
}