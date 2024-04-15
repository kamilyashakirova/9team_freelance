using Microsoft.EntityFrameworkCore;
namespace freelance;
public partial class DBcontext : DbContext
{
    public virtual DbSet<client> clients { get; set; }
    public virtual DbSet<user> users { get; set; }
    public virtual DbSet<performer> performers { get; set; }
    public virtual DbSet<interest> interests { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder obuilder)
    {
            obuilder.UseSqlite("Data Source=../../../database/DB9freelance.db");
    }
    protected override void OnModelCreating(ModelBuilder mbuilder)
    {
        mbuilder.Entity<client>(с =>
        {
            с.HasKey(e => e.ID);
            с.ToTable("ClientsTable");
            с.HasIndex(e => e.userID, "IX_ClientsTable_userID").IsUnique();
            с.HasOne(e => e.InUsers).WithOne(e => e.clientsTable).HasForeignKey<client>(e => e.userID).OnDelete(DeleteBehavior.ClientSetNull);
            }); 
        mbuilder.Entity<performer>(с =>
        {
            с.HasKey(e => e.ID);
            с.ToTable("Performers");
        });
        mbuilder.Entity<interest>(с =>
        {
            с.HasKey(e => e.ID);
            с.ToTable("Interests");
            с.HasIndex(e => e.clientID, "IX_Interests_clientID").IsUnique();
            с.HasOne(e => e.InClients).WithOne(e => e.interestsTable).HasForeignKey<interest>(e => e.clientID).OnDelete(DeleteBehavior.ClientSetNull);
        });

        mbuilder.Entity<user>(u=>
        {
            u.HasKey(e => e.uId);
            u.ToTable("Users");
            u.HasIndex(e => e.uLogin, "IX_Users_uLogin").IsUnique();
        });
    }
}
