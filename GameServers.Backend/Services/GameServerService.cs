using GameServers.Backend.Data.Interfaces;
using GameServers.Backend.Models;
using GameServers.Backend.Models.Enums;
using GameServers.Backend.Services.Interfaces;

namespace GameServers.Backend.Services;

public class GameServerService : IGameServerService
{
    private readonly IGameServerData _gameServers;

    public GameServerService(IGameServerData gameServers)
        => _gameServers = gameServers;

    public Task<GameServer?> Create(GameServer server)
        => _gameServers.Create(server);

    public Task<GameServer?> GetById(long id)
        => _gameServers.GetById(id);

    public Task<List<GameServer>> GetAll()
        => _gameServers.GetAll();

    public Task<bool> Update(GameServer server)
        => _gameServers.Update(server);

    public Task<bool> DeleteById(long id)
        => _gameServers.DeleteById(id);

    public Task<List<GameServer>> GetByGameName(string gameName)
        => _gameServers.GetByGameName(gameName);

    public Task<List<GameServer>> GetByStatus(ServerStatus status)
        => _gameServers.GetByStatus(status);

    public Task<List<GameServer>> GetByUser(long userId)
        => _gameServers.GetByUser(userId);

    public Task<List<GameServer>> GetRunningServers()
        => _gameServers.GetRunningServers();
}