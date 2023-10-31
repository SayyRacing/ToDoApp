using Microsoft.EntityFrameworkCore;
using ToDoApp.Data.Models;

namespace ToDoApp.Data;

public class ToDoAppDbContext : DbContext
{
    public ToDoAppDbContext(DbContextOptions<ToDoAppDbContext> options) : base(options)
    {
    }
    public DbSet<ToDoItem> ToDoItems => Set<ToDoItem>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ToDoItem>().HasData(
            new ToDoItem { Id = 1, Name = "Get AWS Certified", ExpiryDate = DateTime.Now.AddDays(90)},
            new ToDoItem { Id = 2, Name = "Book off days", ExpiryDate = DateTime.Now.AddDays(12)},
            new ToDoItem { Id = 3, Name = "Read a book", ExpiryDate = DateTime.Now.AddDays(11)},
            new ToDoItem { Id = 4, Name = "Pay Electricity bill", ExpiryDate = DateTime.Now.AddDays(21)},
            new ToDoItem { Id = 5, Name = "Get Groceries", ExpiryDate = DateTime.Now.AddDays(1)}
        );
    }
}