using Microsoft.EntityFrameworkCore;


namespace iFruta.Models
{
    public class IfrutaDbContext : DbContext
    {
        
        public DbSet<Categoria> Categorias { get; set; } = null!;

        public IfrutaDbContext(DbContextOptions<IfrutaDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("GALILEO;Database=ifruta;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
