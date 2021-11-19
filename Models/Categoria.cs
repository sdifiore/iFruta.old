using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iFruta.Models
{
    
    [Table("Categorias")]
    public class Categoria
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }

        [Required]
        [StringLength(16)]
        public string Nome { get; set; } = string.Empty;

        [StringLength(128)]
        public string Descricao { get; set;} = string.Empty;
    }
}
