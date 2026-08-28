using GameServers.Backend.Models.Enums;

namespace GameServers.Backend.Models;

public class User
{
    public long Id { get; set; }
    public string Username { get; set; }
    public UserRole Role { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}