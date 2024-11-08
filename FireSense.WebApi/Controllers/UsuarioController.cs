using FireSense.WebApi.Model.Entities;
using FireSense.WebApi.ViewModel;
using FireSenseDomain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FireSense.WebApi.Controllers
{
    [ApiController]
    [Route("api/Usuario")]
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

        [HttpGet]
        public IActionResult Autenticar()
        {
            try
            {
                var usuario = _usuarioRepository.Get();

                //var usuarioLogado = _usuarioRepository.FindBy(x => x.Login.Equals(login))

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
