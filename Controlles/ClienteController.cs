using EcommerceAPI.Context;
using EcommerceAPI.Interfaces;
using EcommerceAPI.Models;
using EcommerceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controlles
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly EcommerceContext _context;
        private IClienteRepository _clienteRepository;

        public ClienteController(EcommerceContext context)
        {
            _context = context;
            _clienteRepository = new ClienteRepository(_context);
        }
        [HttpGet("/buscar{nome}")]
p            return Ok(_clienteRepository.BuscarClientePorNome(nome));
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            return Ok(_clienteRepository.BuscarPorId(id));
        }

        [HttpGet]
        public IActionResult ListarCliente()
        {
            return Ok(_clienteRepository.ListarTodos());
        }

        //POST
        [HttpPost]

        public IActionResult CadastrarCliente(Cliente cliente) 
        {
            _clienteRepository.Cadastrar(cliente);
                return Created();
        }
        
    }
}
