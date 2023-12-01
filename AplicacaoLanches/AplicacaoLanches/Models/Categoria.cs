using System.ComponentModel.DataAnnotations;

namespace AplicacaoLanches.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [StringLength(100)]
        [Required]
        public string CategoriaNome { get; set; } = string.Empty;

        [StringLength(200)]
        [Required]
        public string Descricao { get; set; } = string.Empty;
        

        public List<Lanche> Lanches { get; set; } = new List<Lanche>();
    }
}
