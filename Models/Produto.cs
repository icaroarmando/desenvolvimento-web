using System.ComponentModel.DataAnnotations;

namespace DW01.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }
        public decimal Preco { get; set; }

    }
}
