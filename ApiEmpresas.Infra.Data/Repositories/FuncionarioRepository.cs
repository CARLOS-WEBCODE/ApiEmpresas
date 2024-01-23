using ApiEmpresas.Infra.Data.Entities;
using ApiEmpresas.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpresas.Infra.Data.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {

        public void Inserir(Funcionario entity)
        {
            throw new NotImplementedException();
        }

        public void Alterar(Funcionario entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Funcionario entity)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> Consultar()
        {
            throw new NotImplementedException();
        }

        public Funcionario ObterPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public Funcionario ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Funcionario ObterPorMatricula(string matricula)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> ObterPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
