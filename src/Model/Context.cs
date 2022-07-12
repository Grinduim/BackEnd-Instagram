namespace Model;
using Microsoft.EntityFrameworkCore;
using Model;
public class Context : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Likes> Likes { get; set; }
    public DbSet<Comments> Comments { get; set; }
    public DbSet<Follow> Follows { get; set; }
    public DbSet<ResponseComments> ResponseComments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=" + Environment.MachineName + ";Initial Catalog=Instagram; Integrated Security=True");

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>(entity => {
            entity.HasKey(e => e.ID);
            entity.Property(e=> e.Name);
            entity.Property(e=> e.UserName);
            entity.Property(e=> e.Email);
            entity.Property(e=> e.Password);
            entity.Property(e=> e.Phone);
            entity.HasOne(e=> e.Address);
        });
    }
}