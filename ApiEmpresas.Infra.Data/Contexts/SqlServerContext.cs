﻿using ApiEmpresas.Infra.Data.Entities;
using ApiEmpresas.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpresas.Infra.Data.Contexts
{
    //Classe para configuração (contexto) do EntityFrameWork no projeto Infra.Data
    public class SqlServerContext : DbContext
    {
        //construtor para injeção de dependência
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {
            
        }

        //Sobrescrever o método OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //informar cada classe de mapeamento do projeto
            modelBuilder.ApplyConfiguration(new EmpresaMap());
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
        }

        //declarar uma propriedade DbSet para cada entidade
        public DbSet<Empresa> Empresa {  get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
    }
}
