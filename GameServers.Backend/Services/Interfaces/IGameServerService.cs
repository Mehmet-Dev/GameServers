using GameServers.Backend.Models;
using GameServers.Backend.Models.Enums;

namespace GameServers.Backend.Services.Interfaces;

public interface IGameServerService : IServiceInterface<GameServer>
{
    Task<List<GameServer>> GetByGameName(string gameName);
    Task<List<GameServer>> GetByStatus(ServerStatus status);
    Task<List<GameServer>> GetByUser(long userId);
    Task<List<GameServer>> GetRunningServers();
}