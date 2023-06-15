using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoraAli.Api.Infra.Data;
using BoraAli.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoraAli.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioInfraData _usuarioInfra;
        public UsuarioController(IUsuarioInfraData usuarioInfra)
        {
            _usuarioInfra = usuarioInfra;

        }

        [HttpGet("Usuarios")]
        public async Task<IActionResult> GetUsuarios()
        {
            var usuarios = await _usuarioInfra.GetUsuarios();
            return usuarios.Any() ? Ok(usuarios) : BadRequest("Usuario nao encontrado");
        }

        [HttpGet("Usuario/{id}")]
        public async Task<IActionResult> GetUsuarioById(int id)
        {
            var usuario = await _usuarioInfra.GetUsuarioById(id);
            return usuario != null ? Ok(usuario) : BadRequest("Usuario nao encontrado");
        }

        [HttpPost]
        public async Task<IActionResult> AddUsuarios(Usuario usuario)
        {

            _usuarioInfra.Add(usuario);
            return await _usuarioInfra.SaveChangesAsync()
            ? Ok("Usuario adicionado")
            : BadRequest("O usuario não pode ser adicionado");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {

            var usuarioSelecionado = await _usuarioInfra.GetUsuarioById(id);
            if (usuarioSelecionado.Equals(null)) return BadRequest("Usuario não encontrado");

            _usuarioInfra.Delete(usuarioSelecionado);
            return await _usuarioInfra.SaveChangesAsync()
            ? Ok("Usuario removido")
            : BadRequest("O usuario não pode ser removido");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUsuario(int id, [FromBody] Usuario usuario)
        {
            if (id == usuario.Id)
            {
                _usuarioInfra.Update(usuario);
                return await _usuarioInfra.SaveChangesAsync() ?
                Ok("Usuario Atualizado com sucesso") : BadRequest("Dados inconsistente");
            }
            else
                return BadRequest("Resquisição invalida");

        }
    }
}