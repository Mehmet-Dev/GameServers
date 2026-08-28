namespace GameServers.Backend.Models;

public class ServerLog
{
    public long Id { get; set; }
    public long ServerId { get; set; }
    public string Content { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}