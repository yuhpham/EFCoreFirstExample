using EFCoreFirstExample.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFCoreFirstExample
{
    public class EFCoreFirstExampleDBContext : DbContext
    {
        private string _ConnectionString = "Host=ep-bold-fog-a1nyhb75.ap-southeast-1.aws.neon.tech;Database=neonbdtest;Username=pqh.sony;Password=mE9ZC7SAKPTb";

        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<UserOrder> UserOrders { get; set; }
        public DbSet<UserOrderProduct> UserOrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseNpgsql(_ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasOne(a => a.UserDetail)
                .WithOne(a => a.User)
                .HasForeignKey<UserDetail>(a => a.UserId);
            modelBuilder.Entity<User>()
            .HasMany(u => u.UserOrders)
            .WithOne(uo => uo.User)
            .HasForeignKey(uo => uo.UserId);

            modelBuilder.Entity<UserOrder>()
                .HasMany(uo => uo.UserOrderProducts)
                .WithOne(uop => uop.UserOrder)
                .HasForeignKey(uop => uop.UserOrderId);
        }
    }
}
