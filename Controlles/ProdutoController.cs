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
        private IProdutoRepository _produtoRepository;

        // Injecao de dependencia
        // Ao onves de Eu criar a classe 
        // Eu aviso que DEPENDO dela.
        // E a responsabilidade de criar vem pra classe de chama (C#)
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
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

            return Created();
        }
    }
}
