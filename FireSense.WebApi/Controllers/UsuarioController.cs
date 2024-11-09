using FireSense.WebApi.Model.Entities;
using FireSense.WebApi.Model.Interfaces;
using FireSense.WebApi.ViewModel;
using Microsoft.AspNetCore.Mvc; 
using System.Linq;

namespace FireSense.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository) 
        {
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
        }

        [HttpPost]
        public IActionResult Adicionar(UsuarioViewModel usuarioView)
        {
            try
            {
                var usuario = new Usuario(usuarioView.Login, usuarioView.Nome, usuarioView.Senha, usuarioView.CodPerfil);
                
                _usuarioRepository.Add(usuario);

                return Ok($"Bateu aqui, e foi salvo");
            }
            catch (Exception ex) 
            { 
                string msg = $"Ocorreu um erro inesperado: { ex.Message}";
                return BadRequest(msg);
            }
            
        }

        [HttpPut]
        public IActionResult AlterarSenha(int CodUsuario, [FromBody] UsuarioViewModel usuarioView)
        {
            try
            {
                var usuario = _usuarioRepository.Get();

                var newUsuario = new Usuario(usuarioView.Nome, usuarioView.Login, usuarioView.Senha, usuarioView.CodPerfil);

                foreach (var u in usuario)
                {
                    if (u.CodUsuario == CodUsuario && u.Senha != newUsuario.Senha)
                    {
                        u.CodUsuario = CodUsuario;
                        u.Nome = newUsuario.Nome;
                        u.Login = newUsuario.Login;
                        u.Senha = newUsuario.Senha;
                        u.CodPerfil = newUsuario.CodPerfil;
                        u.DataCadastro = DateTime.Now;
                        _usuarioRepository.Add(newUsuario);

                        return Ok($"Senha Atualizada com sucesso !");
                    }
                    else
                    {
                        continue;
                    }
                }

                return BadRequest($"Nenhum registro encontrado com o Codigo informado");
            }
            catch (Exception ex)
            {
                string msg = $"Ocorreu um erro inesperado: {ex.Message}";
                return BadRequest(msg);
            }
        }

        [HttpGet]
        public IActionResult Autenticar()
        {
            try
            {
                var usuario = _usuarioRepository.Get();

                if (usuario == null)
                {
                    return BadRequest("Usuario Não Encontrado");
                }

                return Ok(usuario);
            }
            catch (Exception ex)
            {
                string msg = $"Ocorreu um erro inesperado: {ex.Message}";
                return BadRequest(msg);
            }
        }
    }
}
