using EcommerceAPI.Models;

namespace EcommerceAPI.Interfaces
{
    public interface IPagamentoRepository
    {
        //R - Read (Leitura)
        List<Pagamento> ListarTodos();

        // Recebe um identificador, e 
        // retorna o prduto correspondente
        Pagamento BuscarPorId(int id);


        // C - Create (Cadastro    

        void Cadastrar(Pagamento pagamento);


        // U -UDADTE (atualixacao)
        //Recebe o identificador para encontrar o Produto e recebe o produto
        void Atualuzar(int id, Pagamento pagamento);

        // D  - Delete (Delete)
        // recebe o identificador de quem quer excluir

        void Deletar(int id);
    }
}
