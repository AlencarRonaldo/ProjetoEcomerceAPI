using EcommerceAPI.Context;
using EcommerceAPI.Interfaces;
using EcommerceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controlles
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly EcommerceContext _context;
        private IPedidoRepository _pedidoRepository;

        public PedidoController(EcommerceContext context)
        {
            _context = context;
            _pedidoRepository = new PedidoRepository(_context);
        }

        // GET
        [HttpGet]
        public IActionResult ListarCliente()
        {
            return Ok(_pedidoRepository.ListarTodos());
        }
    }
}
