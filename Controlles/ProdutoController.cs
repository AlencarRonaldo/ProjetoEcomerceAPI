using EcommerceAPI.Context;
using EcommerceAPI.Interfaces;
using EcommerceAPI.Models;
using EcommerceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Controlles
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {

        private readonly EcommerceContext _context;
        private IProdutoRepository _produtoRepository;

        public ProdutoController(EcommerceContext context)
        {
            _context = context;
            _produtoRepository = new ProdutoRepository(_context);
        }

        // GET
        [HttpGet]
        public IActionResult ListarProdutos()
        {
            return Ok(_produtoRepository.ListarTodos());
        }

        //CADASTRAR PRODUTO
        [HttpPost]
        public IActionResult CadastrarProduto(Produto prod)
        {
            // 1- colocar produto no banco de dados
            _produtoRepository.Cadastrar(prod);

            //2- Salvar a alteracao
            _context.SaveChanges(); //vai usar em todos que pedem alteracao

            return Created();
        }
    }
}
