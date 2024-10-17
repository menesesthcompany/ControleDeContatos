using ControleDeContatos.Enuns;
using ControleDeContatos.Helper;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite seu Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite Seu Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite o Email")]
        [EmailAddress(ErrorMessage = "O Email não e valido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite sua Senha")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O Perfil não e valido!")]
        public PerfilEnum? Perfil { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public bool SenhaValida(string senha)
        {
            return Senha == senha.GerarHash();
        }
        public void SetSenhaHash()
        {
            Senha = Senha.GerarHash();
        }

    }
}
