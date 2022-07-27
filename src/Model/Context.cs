using Microsoft.EntityFrameWorkCore;
namespace Model;


public class Context : DbContext
{
    public DbSet<Address> Addresses { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Post { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<ResponseComment> ResponseComments { get; set; }
    public DbSet<Like> Likes { get; set; }

    public DbSet<Follow> Follows { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        try
        {
            optionsBuilder.UseSqlServer("Data Source=" + Environment.MachineName + ";Initial Catalog=MarketPlace; Integrated Security=True");
        }
        catch
        {
            optionsBuilder.UseSqlServer("Data Source=" + Environment.MachineName + "//SQLEXPRESS;Initial Catalog=MarketPlace; Integrated Security=True");
        }
    }

    public override void OnModelCreating(ModelBuilder modelBuilder){

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Address>(entity => {
            entity.HasKey(q=>q.ID);
            entity.Property(q => q.Street);
            entity.Property(q => q.City);
            entity.
        });
    }

}