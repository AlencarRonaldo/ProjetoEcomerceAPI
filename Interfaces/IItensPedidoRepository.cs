using EcommerceAPI.Models;

namespace EcommerceAPI.Interfaces
{
    public interface IItensPedidoRepository
    {
        //R - Read (Leitura)
        List<ItensPedido> ListarTodos();

        // Recebe um identificador, e 
        // retorna o prduto correspondente
        ItensPedido BuscarPorId(int id);


        // C - Create (Cadastro    

        void Cadastrar(ItensPedido itensPedido);


        // U -UDADTE (atualixacao)
        //Recebe o identificador para encontrar o Produto e recebe o produto
        void Atualuzar(int id, ItensPedido itensPedido);

        // D  - Delete (Delete)
        // recebe o identificador de quem quer excluir

        void Deletar(int id);
    }
}
