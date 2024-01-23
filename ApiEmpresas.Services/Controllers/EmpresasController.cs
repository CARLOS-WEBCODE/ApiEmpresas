using ApiEmpresas.Infra.Data.Entities;
using ApiEmpresas.Infra.Data.Interfaces;
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

        //atributo
        private readonly IUnitOfWork _unitOfWork;
        //construtor para injeção de dependência
        public EmpresasController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IActionResult Post(EmpresaPostRequest request)
        {
            try
            {
                //verificar se o CNPJ informado já está cadastrado..
                if (_unitOfWork.EmpresaRepository.ObterPorCnpj
               (request.Cnpj) != null)

                    //HTTP 422 -> UNPROCESSABLE ENTITY
                   return StatusCode(422,
                   new
                   {
                       message = "O CNPJ informado já está cadastrado." 
                   
                   });
                   
                    var empresa = new Empresa
                    {
                        IdEmpresa = Guid.NewGuid(),
                        NomeFantasia = request.NomeFantasia,
                        RazaoSocial = request.RazaoSocial,
                        Cnpj = request.Cnpj,
                    };

                //gravar no banco de dados
                _unitOfWork.EmpresaRepository.Inserir(empresa);

                var response = new EmpresaResponse
                {
                    Id = empresa.IdEmpresa,
                    NomeFantasia = empresa.NomeFantasia,
                    RazaoSocial = empresa.RazaoSocial,
                    Cnpj = empresa.Cnpj
                };

                //HTTP 201 -> SUCCESS CREATED
                return StatusCode(201, response);
            }
            catch (Exception e)
            {
                //retornando status e mensagem de erro
                //HTTP 500 -> ERRO INTERNO DE SERVIDOR
                return StatusCode(500, e.Message);
            }
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

        [HttpDelete("{idEmpresa}")]
        public IActionResult Delete(Guid idEmpresa)
        {
            var response = new EmpresaResponse
            {
                Id = idEmpresa,
                NomeFantasia = "Empresa Teste",
                RazaoSocial = "Empresa Teste LTDA",
                Cnpj = "44.424.467/0001-34",
                DataInclusao = DateTime.Now,
                DataUltimaAlteracao = DateTime.Now
            };

            return StatusCode(200, response);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var lista = new List<EmpresaResponse>();
            lista.Add(new EmpresaResponse
            {
                Id = Guid.NewGuid(),
                NomeFantasia = "Empresa Teste 01",
                RazaoSocial = "Empresa Teste 01 LTDA",
                Cnpj = "44.424.467/0001-34",
                DataInclusao = DateTime.Now,
                DataUltimaAlteracao = DateTime.Now,
            });

            lista.Add(new EmpresaResponse
            {
                Id = Guid.NewGuid(),
                NomeFantasia = "Empresa Teste 02",
                RazaoSocial = "Empresa Teste 02 LTDA",
                Cnpj = "70.614.891/0001-51",
                DataInclusao = DateTime.Now,
                DataUltimaAlteracao = DateTime.Now,
            });

            return StatusCode(200, lista);
        }

        [HttpGet("{idEmpresa}")]
        public IActionResult GetById(Guid idEmpresa)
        {
            var response = new EmpresaResponse
            {
                Id = Guid.NewGuid(),
                NomeFantasia = "Empresa Teste",
                RazaoSocial = "Empresa Teste LTDA",
                Cnpj = "44.424.467/0001-34",
                DataInclusao = DateTime.Now,
                DataUltimaAlteracao = DateTime.Now,
            };

            return StatusCode(200, response);
        }
    }
}
