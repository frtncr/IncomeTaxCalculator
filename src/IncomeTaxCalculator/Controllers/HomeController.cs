using Microsoft.AspNetCore.Mvc;

namespace IncomeTaxCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok("Welcome to the Income Calculator API");
        }
    }
}