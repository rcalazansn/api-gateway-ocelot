using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransportadorasController : ControllerBase
    {
        public TransportadorasController() { }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("API TRANSPORTADORA");
        }

        [HttpPost()]
        public ActionResult<string> Post(TransportadorasDto request)
        {
            return Ok($"POST: Código da transportadora: {request.Codigo}");
        }
    }
    public class TransportadorasDto
    {
        public string Codigo { get; set; }
    }
}
