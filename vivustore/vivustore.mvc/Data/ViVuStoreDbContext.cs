using System;
using Microsoft.EntityFrameworkCore;
using vivustore.mvc.Models;

namespace vivustore.mvc.Data;

public class ViVuStoreDbContext(DbContextOptions<ViVuStoreDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderDetails>().HasKey(or => new { or.OrderId, or.ProductId });
        base.OnModelCreating(modelBuilder);
    }
    
    public DbSet<Category> Categories { get; set; }

    public DbSet<Supplier> Suppliers { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderDetails> OrderDetails { get; set; }
}
