using System.Data;
using Microsoft.EntityFrameworkCore;
using CursoEFCore.Domain;

namespace CursoEFCore.Data
{
    public DbSet<Pedido> Pedidos{get; set;}

    public  class ApplicationContext : DbContext
    {
        protected override void OnConfigure(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqldb;Initial Catalog=CursoEFCore;Integrated Security=true");
        }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           
       }
    }
}