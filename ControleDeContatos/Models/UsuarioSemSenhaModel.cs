using ControleDeContatos.Enuns;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite seu Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite Seu Login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o Email")]

        [EmailAddress(ErrorMessage = "O Email não e valido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Perfil não e valido!")]
        public PerfilEnum? Perfil {  get; set; } 

}
}
