using GameServers.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace GameServers.Backend.Data;

public class GameServersContext : DbContext
{
    // entitties
    public DbSet<User> Users { get; set; }
    public DbSet<GameServer> GameServers { get; set; }
    public DbSet<ServerLog> ServerLogs { get; set; }

    public GameServersContext(DbContextOptions<GameServersContext> options) : base(options) {}
}