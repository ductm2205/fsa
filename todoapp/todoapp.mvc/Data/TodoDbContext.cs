using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using todoapp.mvc.Models;

namespace todoapp.mvc.Data;

public class TodoDbContext(DbContextOptions<TodoDbContext> options) : DbContext(options)
{
    public DbSet<Models.Task> Tasks { get; set; }

    public DbSet<Category> Categories { get; set; }
}
