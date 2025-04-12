using EcommerceAPI.Context;
using EcommerceAPI.Interfaces;
using EcommerceAPI.Models;

namespace EcommerceAPI.Repositories
{
    public class ItensPedidoRepository : IItensPedidoRepository

    {
        private readonly EcommerceContext _context;
        public ItensPedidoRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Atualuzar(int id, ItensPedido itensPedido)
        {
            throw new NotImplementedException();
        }


        public ItensPedidoRepository BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ItensPedido itensPedido)
        {
            _context.ItensPedidos.Add(itensPedido); 
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        ItensPedido IItensPedidoRepository.BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        List<ItensPedido> ListarTodos()
        {
           return _context.ItensPedidos.ToList();
        }

        List<ItensPedido> IItensPedidoRepository.ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
