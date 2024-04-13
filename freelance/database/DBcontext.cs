using Microsoft.EntityFrameworkCore;
namespace freelance;

public partial class DBcontext : DbContext
    { 

        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../../../database/DB9freelance.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<client>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.ToTable("ClientsTable");

                entity.HasIndex(e => e.userID, "IX_ClientsTable_userID").IsUnique();
                    entity.HasOne(d => d.InUsers).WithOne(p => p.clientsTable)
                        .HasForeignKey<client>(d => d.userID)
                        .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<user>(entity =>
            {
                entity.HasKey(e => e.uId);

                entity.ToTable("Users");

                entity.HasIndex(e => e.uLogin, "IX_Users_uLogin").IsUnique();
            });

        }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
