using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Data.Models;

public class Product
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string? Name { get; set; }
    [Required]
    public DateTime ExpiryDate { get; set; }
}