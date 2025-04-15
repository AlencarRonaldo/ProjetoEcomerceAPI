using EcommerceAPI.Context;
using EcommerceAPI.Interfaces;
using EcommerceAPI.Models;

namespace EcommerceAPI.Repositories
{
    public class ProdutoRepository : IProdutoRepository

    {
        //Metodos que acessam o Bancos de Dados
        //Inlatear context
        //Injecao de dependencia

        private readonly EcommerceContext _context;

        //ctor e uma metodo contrutor
        // Quando criar um obejto o que eu preciso ter?
        public ProdutoRepository(EcommerceContext context)
        {

            _context = context;
        }
        public void Atualuzar(int id, Produto produto)
        {
            throw new NotImplementedException();
        }

        public Produto BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListarTodos()
        {
            return _context.Produtos.ToList();
        }
    }
}
