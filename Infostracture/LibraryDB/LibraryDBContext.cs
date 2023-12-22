using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.LibraryDB
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> ProductOrder { get; set; }
        public DbSet<UserRole> OrderCus { get; set; }
    /*    public DbSet<CustomerOrder> CustomerOrder { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderCusts>().HasOne(o => o.Customer);


        }*/

    }
}
