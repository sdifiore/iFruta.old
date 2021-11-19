using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fruta.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(8)]
        public string Nome { get; set; } = string.Empty;

        [Required]

        public DateTime Quando { get; set; }

        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
