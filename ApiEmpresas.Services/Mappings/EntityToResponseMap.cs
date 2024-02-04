using ApiEmpresas.Infra.Data.Entities;
using ApiEmpresas.Services.Requests;
using ApiEmpresas.Services.Responses;
using AutoMapper;

namespace ApiEmpresas.Services.Mappings
{
    /// <summary>
    /// Mapeamento de objetos ENTITY para RESPONSE (OUTPUT da Api)
    /// </summary>
    public class EntityToResponseMap : Profile
    {
        //public EntityToResponseMap
        public EntityToResponseMap()
        {
            CreateMap<Empresa, EmpresaResponse>();
            CreateMap<Funcionario, FuncionarioResponse>();
        }
    }
}
