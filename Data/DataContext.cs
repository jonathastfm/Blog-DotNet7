using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplication1.Models;


namespace SlifioHub.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) 
    {

    }

    public DbSet<UserModel> Users { get; set; }
    public DbSet<CategoryModel> Categories { get; set; }
    public DbSet<PostModel> Posts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}