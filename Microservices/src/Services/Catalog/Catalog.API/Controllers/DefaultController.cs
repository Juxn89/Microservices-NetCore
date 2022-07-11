using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController : ControllerBase
    {
        public DefaultController(ILogger<DefaultController> logger)
        {

        }

        [HttpGet]
        public string Get()
        {
            return "Running...";
        }
    }
}