using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NiLux.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres!")]
        [Required(ErrorMessage = "Informe o nome da categoria!")]
        [Display(Name="Nome")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres!")]
        [Required(ErrorMessage = "Informe a descricao da categoria!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

       public List<Evento> Evento { get; set; }
    }
}
