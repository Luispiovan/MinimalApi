using Microsoft.EntityFrameworkCore;
using MinimalApi.Models;

namespace MinimalApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo>? Todos { get; set; }
    }
}
