using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fruta.Models
{

    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public float Preco { get; set; }

        [Required]
        public float QtdEstoque { get; set; }

        public ICollection<Pedido> Produtos { get; set; } = new List<Pedido>();
    }
}
