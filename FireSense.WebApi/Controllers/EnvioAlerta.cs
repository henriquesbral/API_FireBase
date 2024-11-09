using Microsoft.AspNetCore.Mvc;

namespace FireSense.WebApi.Controllers
{
    [ApiController]
    [Route("api/Alertas")]
    public class EnvioAlerta : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterAlertas()
        {
            try
            {
                return Ok("OlaMundo");
            }
            catch (Exception ex)
            {
                string msg = $"Ocorreu um erro inesperado: {ex.Message}";
                return BadRequest(msg);
            }
        }
    }
}
