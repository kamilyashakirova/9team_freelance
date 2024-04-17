using Microsoft.EntityFrameworkCore;
namespace freelance;
public partial class DBcontext : DbContext
{
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Performer> Performers { get; set; }
    public virtual DbSet<Interest> Interests { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder obuilder)
    {
            obuilder.UseSqlite("Data Source=../../../database/DB9freelance.db");
    }
    protected override void OnModelCreating(ModelBuilder mbuilder)
    {
        mbuilder.Entity<Client>(с =>
        {
            с.HasKey(e => e.ID);
            с.ToTable("ClientsTable");
            с.HasIndex(e => e.UserID, "IX_ClientsTable_userID").IsUnique();
            с.HasOne(e => e.InUsers).WithOne(e => e.ClientsTable).HasForeignKey<Client>(e => e.UserID).OnDelete(DeleteBehavior.ClientSetNull);
            }); 
        mbuilder.Entity<Performer>(с =>
        {
            с.HasKey(e => e.ID);
            с.ToTable("Performers");
        });
        mbuilder.Entity<Interest>(с =>
        {
            с.HasKey(e => e.ID);
            с.ToTable("Interests");
            с.HasIndex(e => e.ClientID, "IX_Interests_clientID").IsUnique();
            с.HasOne(e => e.InClients).WithOne(e => e.InterestsTable).HasForeignKey<Interest>(e => e.ClientID).OnDelete(DeleteBehavior.ClientSetNull);
        });

        mbuilder.Entity<User>(u=>
        {
            u.HasKey(e => e.UId);
            u.ToTable("Users");
            u.HasIndex(e => e.ULogin, "IX_Users_uLogin").IsUnique();
        });
    }
}
