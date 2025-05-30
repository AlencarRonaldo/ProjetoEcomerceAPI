﻿using EcommerceAPI.Context;
using EcommerceAPI.Interfaces;
using EcommerceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controlles
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItensPedidoController : ControllerBase
    {
        private readonly EcommerceContext _context;
        public IItensPedidoRepository _itensPedidoRepository;

        public ItensPedidoController(EcommerceContext context)
        {
            _context = context;
            _itensPedidoRepository = new ItensPedidoRepository(_context);
        }

        // GET
        [HttpGet]
        public IActionResult ListarItensPedido()
        {
            return Ok(_itensPedidoRepository.ListarTodos());
        }
    }
}
