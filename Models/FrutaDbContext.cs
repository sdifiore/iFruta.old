using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fruta.Models
{
    public class FrutaDbContext : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; } = null!;
        public DbSet<Produto> Produtos { get; set; } = null!;
        public DbSet<Pedido> Pedidos { get; set; } = null!;

        public FrutaDbContext(DbContextOptions<FrutaDbContext> options) : base(options)
        {
        }
     }
}
