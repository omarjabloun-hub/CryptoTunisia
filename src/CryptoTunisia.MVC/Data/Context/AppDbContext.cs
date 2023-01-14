using CryptoTunisia.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CryptoTunisia.MVC.Data.Context;

public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {
        
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Comment> Comments { get; set; }

}