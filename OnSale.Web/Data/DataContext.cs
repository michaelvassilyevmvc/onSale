using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnSale.Common.Enitities;
using OnSale.Web.Data.Entities;

namespace OnSale.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Создаем модели для базы данных

            //Категории
            modelBuilder.Entity<Category>()
                .HasIndex(t => t.Name)
                .IsUnique();

            //Город
            modelBuilder.Entity<City>()
                .HasIndex(t => t.Name)
                .IsUnique();

            //Страна
            modelBuilder.Entity<Country>()
                .HasIndex(t => t.Name)
                .IsUnique();

            //Департамент
            modelBuilder.Entity<Department>()
                .HasIndex(t => t.Name)
                .IsUnique();

                //Продукты
            modelBuilder.Entity<Product>()
                .HasIndex(t => t.Name)
                .IsUnique();
        }
    }
}
