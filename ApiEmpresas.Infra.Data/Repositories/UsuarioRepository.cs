using ApiEmpresas.Infra.Data.Contexts;
using ApiEmpresas.Infra.Data.Entities;
using ApiEmpresas.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpresas.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        //atributo
        private readonly SqlServerContext _context;

        //construtor para injeção de dependências (inicialização)
        public UsuarioRepository(SqlServerContext context)
        {
            _context = context;
        }

        public void Inserir(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Alterar(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Consultar()
        {
            throw new NotImplementedException();
        }

        public Usuario ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Usuario Obter(string email)
        {
            throw new NotImplementedException();
        }

        public Usuario Obter(string email, string senha)
        {
            throw new NotImplementedException();
        }

    }
}
