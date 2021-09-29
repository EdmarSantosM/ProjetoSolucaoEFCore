using System.Data;
using Microsoft.EntityFrameworkCore;

namespace CursoEFCore.Data
{
    public  class ApplicationContext : DbContext
    {
        protected override void OnConfigure(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqldb;Initial Catalog=CursoEFCore;Integrated Security=true");
        }
    }
}