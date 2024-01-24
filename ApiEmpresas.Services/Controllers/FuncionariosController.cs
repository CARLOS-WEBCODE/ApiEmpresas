using ApiEmpresas.Infra.Data.Entities;
using ApiEmpresas.Infra.Data.Interfaces;
using ApiEmpresas.Services.Requests;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace ApiEmpresas.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FuncionariosController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post(FuncionarioPostRequest request)
        {
            try
            {
                if (_unitOfWork.FuncionarioRepository.ObterPorCpf(request.Cpf) != null)

                    return StatusCode(422, new { message = "O CPF informado já está cadastrado." });

                    if (_unitOfWork.FuncionarioRepository.ObterPorMatricula(request.Matricula) != null)
                    return StatusCode(422, new { message = "A Matrícula informada já está cadastrado." });
                   
                    var funcionario = _mapper.Map<Funcionario>(request);
                    funcionario.IdFuncionario = Guid.NewGuid();

                    _unitOfWork.FuncionarioRepository.Inserir(funcionario);

                    var response = _mapper.Map<FuncionarioResponse>(funcionario);

                    return StatusCode(201, response);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
