using EcommerceAPI.Models;

namespace EcommerceAPI.Interfaces
{
    public interface IProdutoRepository
    {
        //R - Read (Leitura)
        List<Produto> ListarTodos();

        // Recebe um identificador, e 
        // retorna o prduto correspondente
        Produto BuscarPorId(int id);
        

        // C - Create (Cadastro    

        void Cadastrar(Produto prodututo);


        // U -UDADTE (atualixacao)
        //Recebe o identificador para encontrar o Produto e recebe o produto
        void Atualuzar(int id, Produto produto);

        // D  - Delete (Delete)
        // recebe o identificador de quem quer excluir

        void Deletar(int id);
    }
}
