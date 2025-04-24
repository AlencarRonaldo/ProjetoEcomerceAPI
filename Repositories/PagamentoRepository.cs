using EcommerceAPI.Context;
using EcommerceAPI.Interfaces;
using EcommerceAPI.Models;

namespace EcommerceAPI.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private EcommerceContext _context;
        private object pagamentoEncontrado;

        public PagamentoRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Atualuzar(int id, Pagamento pagamento)
        {
          
            Pagamento pagamentoEncontrado = _context.Pagamentos.Find(id);

            if (pagamentoEncontrado == null)
            {
                throw new Exception();
            }

            pagamentoEncontrado.IdPagamento = pagamento.IdPagamento;
            pagamentoEncontrado.FormaPagamento = pagamento.FormaPagamento;
            pagamentoEncontrado.IdPedido = pagamento.IdPedido;
            pagamentoEncontrado.Status = pagamento.Status;
           

            _context.SaveChanges();
        }

        public Pagamento BuscarPorId(int id)
        {
            return _context.Pagamentos.FirstOrDefault(p => p.IdPagamento == id);
       
        }

        public void Cadastrar(Pagamento pagamento)
        {
            
            _context.Pagamentos.Add(pagamento);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            //1- Econtrar o que eu quero excluir
            // Find - Procura pela chave primaria
            Pagamento pagamentoEncontrado = _context.Pagamentos.Find(id);

            if (pagamentoEncontrado == null)
            {
                throw new Exception();
            }

            //Caso encontre o produto renovo ele
            _context.Pagamentos.Remove(pagamentoEncontrado);

            //Salvo as alteracos no bnco de dados
            _context.SaveChanges();
        }

        public List<Pagamento> ListarTodos()
        {
            return _context.Pagamentos.ToList();
        }
    }
}
