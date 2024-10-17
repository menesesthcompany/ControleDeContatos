using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int id { get; set; }
        
        [Required(ErrorMessage = "Digite a Idade")]
        public string Idade { get; set; }

        [Required(ErrorMessage = "Digite a Nacionalidade")]
        public string Nacionalidade { get; set; }
        
        [Required(ErrorMessage = "Digite o Celular")]
        [Phone(ErrorMessage = "O numero de telefone não e valido!")]

        public string Celular { get; set; }

    }
}
