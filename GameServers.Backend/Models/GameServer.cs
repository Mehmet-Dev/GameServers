using GameServers.Backend.Models.Enums;

namespace GameServers.Backend.Models;

public class GameServer
{
    public long Id { get; set; }
    public string GameName { get; set; }
    public short ServerSize { get; set; }
    public DateTimeOffset StartedAt { get; set; }
    public ServerStatus Status { get; set; }
    public long CreatedBy { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}