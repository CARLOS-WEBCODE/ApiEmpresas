using ApiEmpresas.Services.Requests;
using ApiEmpresas.Services.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEmpresas.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(EmpresaPostRequest request)
        {
            var response = new EmpresaResponse
            {
                Id = Guid.NewGuid(),
                NomeFantasia = request.NomeFantasia,
                RazaoSocial = request.RazaoSocial,
                Cnpj = request.Cnpj,
                DataInclusao = DateTime.Now,
                DataUltimaAlteracao = DateTime.Now,
            };
            return StatusCode(201, response);
        }

        [HttpPut]
        public IActionResult Put(EmpresaPutRequest request)
        {
            var response = new EmpresaResponse
            {
                Id = request.IdEmpresa,
                NomeFantasia = request.NomeFantasia,
                RazaoSocial = request.RazaoSocial,
                Cnpj = request.Cnpj,
                DataInclusao = DateTime.Now,
                DataUltimaAlteracao = DateTime.Now,
            };
            return StatusCode(200, response);
        }

    }
}
