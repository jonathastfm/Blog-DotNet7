using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class CategoryModel
{
    [Key]
    public string Slug { get; set; }
    public string Name { get; set; }
}