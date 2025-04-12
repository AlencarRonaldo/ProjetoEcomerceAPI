using EcommerceAPI.Context;
using EcommerceAPI.Interfaces;
using EcommerceAPI.Models;

namespace EcommerceAPI.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private EcommerceContext _context;

        public PagamentoRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Atualuzar(int id, Pagamento pagamento)
        {
            throw new NotImplementedException();
        }

        public Pagamento BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Pagamento pagamento)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pagamento> ListarTodos()
        {
            return _context.Pagamentos.ToList();
        }
    }
}
