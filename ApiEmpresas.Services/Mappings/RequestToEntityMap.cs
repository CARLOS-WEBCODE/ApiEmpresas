using ApiEmpresas.Infra.Data.Entities;
using ApiEmpresas.Services.Requests;
using AutoMapper;

namespace ApiEmpresas.Services.Mappings
{
    /// <summary>
    /// Mapeamento de objeto REQUEST para ENTITY
    /// </summary>
    public class RequestToEntityMap : Profile
    {
        //public RequestToEntityMap
        public RequestToEntityMap()
        {
            //CreateMap
            CreateMap<EmpresaPostRequest, Empresa>();
            CreateMap<EmpresaPutRequest, Empresa>();
            //CreateMap
            CreateMap<FuncionarioPostRequest, Funcionario>();
            CreateMap<FuncionarioPutRequest, Funcionario>();
        }
    }
}
