using ApiEmpresas.Services.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiEmpresas.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : Controller
    {
        [HttpPost]
        public IActionResult Post()
        {
            return null;
        }
    }
}
