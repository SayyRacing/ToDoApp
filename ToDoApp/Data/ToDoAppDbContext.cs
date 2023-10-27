using Microsoft.EntityFrameworkCore;
using ToDoApp.Data.Models;

namespace ToDoApp.Data;

public class ToDoAppDbContext : DbContext
{
    public ToDoAppDbContext(DbContextOptions<ToDoAppDbContext> options) : base(options)
    {
    }
    public DbSet<Product> Products => Set<Product>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Get AWS Certified", ExpiryDate = DateTime.Now.AddDays(90)},
            new Product { Id = 2, Name = "Book off days", ExpiryDate = DateTime.Now.AddDays(12)},
            new Product { Id = 3, Name = "Read a book", ExpiryDate = DateTime.Now.AddDays(11)},
            new Product { Id = 4, Name = "Pay Electricity bill", ExpiryDate = DateTime.Now.AddDays(21)},
            new Product { Id = 5, Name = "Get Groceries", ExpiryDate = DateTime.Now.AddDays(1)}
        );
    }
}