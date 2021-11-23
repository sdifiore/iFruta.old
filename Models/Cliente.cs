using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fruta.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(14)]
        public string CPF { get; set; } = string.Empty;

        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
