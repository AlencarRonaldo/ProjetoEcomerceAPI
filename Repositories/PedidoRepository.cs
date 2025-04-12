using EcommerceAPI.Context;
using EcommerceAPI.Interfaces;
using EcommerceAPI.Models;

namespace EcommerceAPI.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly EcommerceContext _context;

        public PedidoRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Atualuzar(int id, Pedido Pedido)
        {
            throw new NotImplementedException();
        }

        public Pedido BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pedido> ListarTodos()
        {
            return _context.Pedidos.ToList(); ;
        }
    }
}
