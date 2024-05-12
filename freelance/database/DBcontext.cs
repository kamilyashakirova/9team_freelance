using Microsoft.EntityFrameworkCore;
namespace freelance;
/// <summary>
/// Класс для работы с БД
/// </summary>
public partial class DBcontext : DbContext
{
    /// <summary>
    /// Таблица заказчиков в БД
    /// </summary>
    public virtual DbSet<Client> Clients { get; set; }
    /// <summary>
    /// Таблица пользователей в БД
    /// </summary>
    public virtual DbSet<User> Users { get; set; }
    /// <summary>
    /// Таблица фрилансеров в БД
    /// </summary>
    public virtual DbSet<Performer> Performers { get; set; }
    /// <summary>
    /// Таблица предпочтений в БД
    /// </summary>
    public virtual DbSet<Interest> Interests { get; set; }
    /// <summary>
    /// Таблица скрытых фрилансеров в БД
    /// </summary>
    public virtual DbSet<DislikedPerformers> DislikedPerformers { get; set; }
    /// <summary>
    /// Таблица избранных фрилансеров в БД
    /// </summary>
    public virtual DbSet<LikedPerformers> LikedPerformers { get; set; }
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
            с.HasIndex(e => e.ID, "IX_Performers_ID").IsUnique();
            с.HasOne(e => e.InClients).WithOne(e => e.Myservices).HasForeignKey<Performer>(e => e.ClientID).OnDelete(DeleteBehavior.ClientSetNull);
    });
        mbuilder.Entity<DislikedPerformers>(с =>
        {
            с.HasKey(e => e.ID);
            с.ToTable("DislikedPerformers");
            с.HasIndex(e => e.ClientID, "IX_DislikedPerformers_ClientID").IsUnique();
            с.HasOne(e => e.InClients).WithOne(e => e.DislikedTable).HasForeignKey<DislikedPerformers>(e => e.ClientID).OnDelete(DeleteBehavior.ClientSetNull);
            с.HasOne(e => e.InPerformers).WithOne(e => e.DislikedTable).HasForeignKey<DislikedPerformers>(e => e.PerformerID).OnDelete(DeleteBehavior.ClientSetNull);
        });
        mbuilder.Entity<LikedPerformers>(с =>
        {
            с.HasKey(e => e.ID);
            с.ToTable("LikedPerformers");
            с.HasIndex(e => e.ClientID, "IX_LikedPerformers_ClientID").IsUnique();
            с.HasOne(e => e.InClients).WithOne(e => e.LikedTable).HasForeignKey<LikedPerformers>(e => e.ClientID).OnDelete(DeleteBehavior.ClientSetNull);
            с.HasOne(e => e.InPerformers).WithOne(e => e.LikedTable).HasForeignKey<LikedPerformers>(e => e.PerformerID).OnDelete(DeleteBehavior.ClientSetNull);
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
