using EcommerceAPI.Context;
using EcommerceAPI.DTO;
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
            _produtoRepository.CadastrarProdutoDto(prod);

            return Created();
        }

        //buscar Produto por id
        // /api/Produtos
        // /api/produtos/1
        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            Produto produto = _produtoRepository.BuscarPorId(id);

            if(produto == null)
            {
                //404 - Nao Encontrado
                return NotFound();
            }

            return Ok(produto);
        }

        [HttpPut("{id}")]

        public IActionResult Editar(int id, CadastrarProdutoDto prod)
        {
            //tratativa de erros
            try
            {
                //204 - Deu certo
                _produtoRepository.Atualuzar(id, prod);
                return Ok(prod);
            }
            //caso de erro
            catch (Exception ex)
            {
                return NotFound("Produto nao encontrado!");
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                //204 - Deu certo
                _produtoRepository.Deletar(id);
                return NoContent();
            }
            //caso de erro
            catch (Exception ex)
            {
                return NotFound("Produto nao encontrado!");
            }
        }
    }
}
