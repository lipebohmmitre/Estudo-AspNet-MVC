using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacaoLanches.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }

        [StringLength(80, MinimumLength = 10)]
        [Required]
        public string LancheNome { get; set; } = string.Empty;
        public string DescricaoCurta { get; set; } = string.Empty;
        public string DescricaoDetalhada { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }
        public string ImgUrl { get; set; } = string.Empty;
        public string ImgThumbnailUrl { get; set; } = string.Empty;
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }


        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
