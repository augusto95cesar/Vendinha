using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Vendinha.Domain;

namespace Vendinha.Repository;
public class VendinhaContext:DbContext
{
    //private readonly IConfiguration _configuration;


    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{   
    //    optionsBuilder.UseSqlite(_configuration.GetConnectionString("VendinhaContext"));
    //}

    public VendinhaContext(DbContextOptions<VendinhaContext> options)  : base(options) { }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Divida> Dividas { get; set; }
}