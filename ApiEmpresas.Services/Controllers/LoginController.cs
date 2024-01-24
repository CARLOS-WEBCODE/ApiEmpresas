using ApiEmpresas.Services.Authorization;
using ApiEmpresas.Services.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEmpresas.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        //atributo
        private readonly JwtService _jwtService;

        //Construtor para injeção de dependência
        public LoginController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost]
        public IActionResult Post(LoginPostRequest request)
        {
            if (request.Email.Equals("admin@admin.com") && request.Senha.Equals("coti"))
                return StatusCode(200, _jwtService.GenerateToken("admin"));
            else
                return StatusCode(401); //UNAUTHORIZED (Acesso Negado)
        }

    }
}
