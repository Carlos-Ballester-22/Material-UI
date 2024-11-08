using backend.API.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.API.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }    
}