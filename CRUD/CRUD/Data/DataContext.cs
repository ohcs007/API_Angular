using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Data
{
    //responsável pelas ações de banco de dados
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext>options) : base(options)
        {}

        //Quais modelos serao contemplados
        public DbSet<Pessoa> pessoa { get; set; }
    }
}
