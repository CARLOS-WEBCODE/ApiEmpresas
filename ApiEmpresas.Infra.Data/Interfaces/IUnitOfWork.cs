﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpresas.Infra.Data.Interfaces
{
    /// <summary>
    /// Interface de unidade de trabalho do EntityFramework
    /// </summary>
    public interface IUnitOfWork
    {
        #region Métodos para controle de transação

        void BeginTransaction();
        void Commit();
        void Rollback();

        #endregion

        #region Método para acesso aos repositorios

        public IEmpresaRepository EmpresaRepository { get; }
        public IFuncionarioRepository FuncionarioRepository { get; }

        #endregion
    }
}
