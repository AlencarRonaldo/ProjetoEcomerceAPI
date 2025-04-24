using EcommerceAPI.Models;

namespace EcommerceAPI.Interfaces
{
    public interface IClienteRepository
    {
        //R - Read (Leitura)
        List<Cliente> ListarTodos();

        // Recebe um identificador, e 
        // retorna o prduto correspondente
        Cliente BuscarPorId(int id);
        Cliente BuscarPOremailSenha(String email, string senha);

        // C - Create (Cadastro    

        void Cadastrar(Cliente cliente);


        // U -UDADTE (atualixacao)
        //Recebe o identificador para encontrar o Produto e recebe o produto
        void Atualuzar(int id, Cliente cliente);

        // D  - Delete (Delete)
        // recebe o identificador de quem quer excluir

        void Deletar(int id);
        List<Cliente> BuscarClientePorNome(string nome);

    }
}
