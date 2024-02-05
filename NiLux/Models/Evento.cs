using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiLux.Models
{
    [Table("Eventos")]
    public class Evento
    {
        [Key]
        public int EventoId { get; set; }


        [Required(ErrorMessage = "Informe o nome do evento!")]
        [StringLength(100, MinimumLength =10, ErrorMessage = "O {0} deve ter no minimo {1} e máximo {2}")]
        [Display(Name = "Nome do Evento")]
        public string NomeEvento { get; set; }

        [Required(ErrorMessage = "Informe a descrica curta!")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e máximo {2}")]
        [Display(Name = "Descricao do Evento")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Informe a descrica longa!")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e máximo {2}")]
        [Display(Name = "Descricao detalhada do Evento")]
        public string DescricaoLonga { get; set; }

        [Required(ErrorMessage ="Informe o preco do evento!")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(100,999999.99, ErrorMessage="Opreço deve estar entre 100 e 999999.99")]
        public decimal Preco { get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1}")]
        [Display(Name = "Caminho Imagem Normal")]
        public string ImagemURL { get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1}")]
        [Display(Name = "Caminho Imagem Miniatura")]
        public string ImagemTumbnailURL { get; set; }

        [Display(Name = "Preferido?")]
        public bool EventoPreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
