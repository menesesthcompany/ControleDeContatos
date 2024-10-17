using ControleDeContatos.Models;

namespace ApiContatos.Repositories
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
