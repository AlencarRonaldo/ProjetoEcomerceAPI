using EcommerceAPI.Models;

namespace EcommerceAPI.Interfaces
{
    public interface IPedidoRepository
    {
        //R - Read (Leitura)
        List<Pedido> ListarTodos();

        // Recebe um identificador, e 
        // retorna o prduto correspondente
        Pedido BuscarPorId(int id);


        // C - Create (Cadastro    

        void Cadastrar(Pedido pedido);


        // U -UDADTE (atualixacao)
        //Recebe o identificador para encontrar o Produto e recebe o produto
        void Atualuzar(int id, Pedido Pedido);

        // D  - Delete (Delete)
        // recebe o identificador de quem quer excluir

        void Deletar(int id);
    }
}
