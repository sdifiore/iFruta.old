using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fruta.Models
{
    
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(16)]
        public string Nome { get; set; } = string.Empty;

        [StringLength(128)]
        public string Descricao { get; set;} = string.Empty;
    }
}
