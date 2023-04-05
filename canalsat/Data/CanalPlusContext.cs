using Microsoft.EntityFrameworkCore;

public class CanalPlusContext : DbContext
{
    public CanalPlusContext()
    {
    }

    public CanalPlusContext(DbContextOptions<CanalPlusContext> options)
        : base(options)
    {
    }
    // LISTE TABLE WILL USE
    public DbSet<Utilisateur> Utilisateurs { get; set; }

}