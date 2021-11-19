using Microsoft.EntityFrameworkCore;


namespace Fruta.Models
{
    public class FrutaDbContext : DbContext
    {
        
        public DbSet<Categoria> Categorias { get; set; } = null!;

        public FrutaDbContext(DbContextOptions<FrutaDbContext> options) : base(options)
        {
        }
    }
}
