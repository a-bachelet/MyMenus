using Microsoft.EntityFrameworkCore;
using MyMenus.Entity;
using System;
using System.Linq;

namespace MyMenus.Context
{
    /// <summary>
    ///     A database context.
    /// </summary>
    public class MyMenusContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<RolePermission> RolePermissions { get; set; }

        public DbSet<User> Users { get; set; }

        public MyMenusContext() : base() { }

        public MyMenusContext(DbContextOptions<MyMenusContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbHost = Environment.GetEnvironmentVariable("DB_HOST");
            string dbUser = Environment.GetEnvironmentVariable("DB_USER");
            string dbPass = Environment.GetEnvironmentVariable("DB_PASS");
            string dbName = Environment.GetEnvironmentVariable("DB_NAME");

            optionsBuilder.UseSqlServer($"Data Source={dbHost};Initial Catalog={dbName};User ID={dbUser};Password={dbPass};");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region ManyToMany
            
            modelBuilder
                .Entity<RolePermission>()
                .HasKey(rp => new { rp.RoleId, rp.PermissionId  });

            #endregion

            #region ManyToOne

            modelBuilder
                .Entity<Role>()
                .HasMany(typeof(Role), "Children")
                .WithOne("Parent")
                .OnDelete(DeleteBehavior.Restrict);

            #endregion

            #region OneToOne

            modelBuilder
                .Entity<User>()
                .HasOne(typeof(Address), "Address")
                .WithOne("User")
                .OnDelete(DeleteBehavior.SetNull);

            #endregion
        }
    }
}
