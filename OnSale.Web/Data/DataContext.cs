using Microsoft.EntityFrameworkCore;
using OnSale.Common.Enitities;

namespace OnSale.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Создаем модели для базы данных

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
        }
    }
}
