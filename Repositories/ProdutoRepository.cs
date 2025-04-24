using EcommerceAPI.Context;
using EcommerceAPI.DTO;
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
            //Encontro o produto desejo
            Produto produtoEncontrado = _context.Produtos.Find(id);

            // CAso nao encontre o produto lanco um erro
            if(produtoEncontrado == null)
            {
                throw new Exception();
            }

            produtoEncontrado.Nome = produto.Nome;
            produtoEncontrado.Descricao = produto.Descricao;
            produtoEncontrado.Preco = produto.Preco;
            produtoEncontrado.Categoria = produto.Categoria;
            produtoEncontrado.Imagem = produto.Imagem;
            produtoEncontrado.EstoqueDisponivel = produto.EstoqueDisponivel;

            _context.SaveChanges();

        }

        public Produto BuscarPorId(int id)
        {
            //ToList() - Pega varios
            //FirstorDefault - Traz o primeiro que encontrar
            //FINCAOLAMBIDA
            //_context.Produtos - acessa a tabela de contexto
            //FirstOrDefault - peque o primeiro que encontrar 
            //p.Idproduto == id - Para cada produto p 
            return _context.Produtos.FirstOrDefault(p => p.Idproduto == id);
        }

        public void Cadastrar(CadastrarProdutoDto produto)

        {
            Produto produtoCadastro = new Produto
            {
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Preco = produto.Preco,
                EstoqueDisponivel = produto.EstoqueDisponivel,
                Categoria = produto.Categoria,
                Imagem = produto.Imagem
            };

            _context.Produtos.Add(produtoCadastro);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            //1- Econtrar o que eu quero excluir
            // Find - Procura pela chave primaria
            Produto produtoEncontrado = _context.Produtos.Find(id);

            if(produtoEncontrado == null)
            {
                throw new Exception();
            }

            //Caso encontre o produto renovo ele
            _context.Produtos.Remove(produtoEncontrado);

            //Salvo as alteracos no bnco de dados
            _context.SaveChanges();
        }

        public List<Produto> ListarTodos()
        {
            return _context.Produtos.ToList();
        }
    }
}
