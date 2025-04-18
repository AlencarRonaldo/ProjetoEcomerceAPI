using EcommerceAPI.Context;
using EcommerceAPI.Interfaces;
using EcommerceAPI.Models;

namespace EcommerceAPI.Repositories
{
    public class ClienteRepository : IClienteRepository

    {
        private readonly EcommerceContext _context;

        public ClienteRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Atualuzar(int id, Cliente cliente)
        {
            Cliente clienteEncontrado = _context.Clientes.Find(id);

            if (clienteEncontrado == null)
            {
                throw new Exception();
            }

            clienteEncontrado.NomeCompleto = cliente.NomeCompleto;
            clienteEncontrado.Email = cliente.Email;
            clienteEncontrado.Telefone = cliente.Telefone;
           clienteEncontrado.Endereco = cliente.Endereco;
           clienteEncontrado.DataCadastro = cliente.DataCadastro;

            _context.SaveChanges();
        }

        public Cliente BuscarPorEmailSenha(string email, string senha)
        {
            return _context.Clientes.FirstOrDefault();
        }

        public Cliente BuscarPorId(int id)
        {
            return _context.Clientes.FirstOrDefault(p => p.IdCliente == id);
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Cliente clienteEncontrado = _context.Clientes.Find(id);

            if (clienteEncontrado == null)
            {
                throw new Exception();

                _context.SaveChanges();
            }
        }

        public List<Cliente> ListarTodos()
        {
            return _context.Clientes.ToList(); 
        }
    }
}