using Microsoft.EntityFrameworkCore;
using Todo.Models.Db;

namespace Todo.Db;

public class TodoListDbContext : DbContext
{
    public TodoListDbContext(DbContextOptions<TodoListDbContext> options) : base(options) {}

    public DbSet<SingleTask> Task { get; set; }
    
}