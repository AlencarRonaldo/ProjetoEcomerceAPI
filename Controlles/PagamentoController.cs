using EcommerceAPI.Context;
using EcommerceAPI.Interfaces;
using EcommerceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controlles
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private readonly EcommerceContext _context;
        private IPagamentoRepository _pagamentoRepository;

        public PagamentoController(EcommerceContext context)
        {
            _context = context;
            _pagamentoRepository = new PagamentoRepository(_context);
        }

        // GET
        [HttpGet]
        public IActionResult ListarCliente()
        {
            return Ok(_pagamentoRepository.ListarTodos());
        }
    }
}
