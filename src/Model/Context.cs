namespace Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
public class Context : DbContext
{
    public DbSet<Address> Addresses { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Likes> Likes { get; set; }
    public DbSet<Follow> Follows { get; set; }
    // public DbSet<Post> Posts { get; set; }
    // public DbSet<Comments> Comments { get; set; }
    // public DbSet<ResponseComments> ResponseComments { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=" + "DESKTOP-S4T02R7\\SQLEXPRESS" + ";Initial Catalog=Instagram; Integrated Security=True");

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey( entity=>entity.ID);
            entity.Property(entity => entity.Street);
            entity.Property(entity => entity.City);
            entity.Property(entity => entity.State);
            entity.Property(entity => entity.Country);
            entity.Property(entity => entity.Zip);

        });

        modelBuilder.Entity<User>(entity => {
            entity.HasKey(e => e.ID);
            entity.Property(e=> e.Name);
            entity.Property(e=> e.UserName);
            entity.Property(e=> e.Email);
            entity.Property(e=> e.Password);
            entity.Property(e=> e.Phone);
            entity.HasOne(e=> e.Address);
        });

        modelBuilder.Entity<Likes>(entity => {
            entity.HasKey(e => e.ID);
            entity.HasMany(e => e.User).WithMany().OnDelete(DeleteBehavior.ClientNoAction);
        });

        // modelBuilder.Entity<Post>(entity => {
        //     entity.HasKey(e => e.ID);
        //     entity.Property(e => e.Description);
        //     entity.Property(e => e.DatePost);
        //     entity.HasOne(e => e.User);
        //     entity.HasOne(e => e.Likes);
        //     entity.HasMany(e => e.Data);
        // });

        // modelBuilder.Entity<Comments>(entity => {
        //     entity.HasKey(e => e.ID);
        //     entity.Property(e => e.Text);
        //     entity.HasOne(e => e.User);
        //     entity.HasOne(e => e.Post);
        //     entity.HasOne(e => e.Likes);
        // });

        modelBuilder.Entity<Follow>(entity => {
            entity.HasKey(e => e.ID);
            entity.HasOne(e => e.Follower);
            entity.HasOne(e => e.User);
        });

        // modelBuilder.Entity<ResponseComments>(entity => {
        //     entity.HasKey(e => e.ID);
        //     entity.Property(e => e.Text);
        //     entity.HasOne(e => e.User);
        //     entity.HasOne(e => e.Comment);
        //     entity.HasOne(e => e.Likes);
        // });

      
    }
}