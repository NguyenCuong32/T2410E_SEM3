using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Security.Claims;
using TodoList_API.Models;
namespace TodoList_API.DBContext
{
    public class TodoListDbContext : DbContext
    {
        public TodoListDbContext():base()
        {
            
        }
        public TodoListDbContext(DbContextOptions<TodoListDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Todo>();
            modelBuilder.Entity<TaskType>();
            modelBuilder.Entity<Prorioty>();
        }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<Prorioty> Prorioties { get; set; }
    }
}
