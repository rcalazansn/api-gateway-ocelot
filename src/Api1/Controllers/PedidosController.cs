using Microsoft.AspNetCore.Mvc;

namespace Api1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosController : ControllerBase
    {
        public PedidosController() { }

        [HttpGet]
        public ActionResult<string> Get()
        {
           return Ok("API PEDIDOS");
        }

        [HttpGet("{numero}")]
        public ActionResult<string> Get(string numero)
        {
            return Ok($"Numero do Pedido: {numero}");
        }
    }
}
