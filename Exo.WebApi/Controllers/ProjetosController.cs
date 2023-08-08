using Exo.WebApi.Models;
using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Exo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;
        public ProjetosController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_projetoRepository.Listar());
            [httpPost]
            public IActionResult Cadastrar(Projeto)
            {
                _projetoRepository.Cadastrar(Projeto projeto)
                return StatusCode (201);
            }
                [HttpGet("{id}")]
                PublicKey IActionResult BuscarporId(int id)
                {

                   Projeto projeto = _projetoRepository.BuscarporID(id);
                   if (projeto == null)
                   {
                    return NotFound();
                   }
                    return Ok(projeto);
                }    
            [HttpPut("{id}")]
            public IActionResult Atualizar(int id, Projeto projeto)
            {
                _projetoRepository.Atualizar(id, projeto);
                return StatusCode (204);
        }
            [HttpDelete("{id}")]
            public IActionResult Deletar(int id)
            {
                try
                {
                    _projetoRepository.Deletar(id);
                    return StatusCode (204);    
                }
                catch (Exception e)
                {
                    return BadRequest();
                }    
            }
    }
}
