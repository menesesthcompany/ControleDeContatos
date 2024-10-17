using ControleDeContatos.Data;
using ControleDeContatos.Models;

namespace ApiContatos.Repositories

{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Add(contato);
            _bancoContext.SaveChanges();

            return contato;
        }

    }
}
