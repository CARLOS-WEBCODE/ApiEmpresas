using ApiEmpresas.Infra.Data.Entities;
using ApiEmpresas.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpresas.Infra.Data.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        public void Inserir(Empresa entity)
        {
            throw new NotImplementedException();
        }

        public void Alterar(Empresa entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Empresa entity)
        {
            throw new NotImplementedException();
        }

        public List<Empresa> Consultar()
        {
            throw new NotImplementedException();
        }

        public Empresa ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Empresa ObterPorCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }

    }
}
