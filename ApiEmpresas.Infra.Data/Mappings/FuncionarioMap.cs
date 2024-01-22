using ApiEmpresas.Infra.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpresas.Infra.Data.Mappings
{
    ///Classe de mapeamento para a entidade Funcionario
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        ///Método para mapear a entidade
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            //nome da tabela
            builder.ToTable("FUNCIONARIO");

            //chave primária
            builder.HasKey(f => f.IdFuncionario);

            //mapeamento dos campos da entidade
            builder.Property(f => f.IdFuncionario)
                .HasColumnName("IDFUNCIONARIO")
                .IsRequired();

            builder.Property(f => f.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(f => f.Cpf)
                .HasColumnName("CPF")
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(f => f.Matricula)
                .HasColumnName("MATRICULA")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(f => f.DataAdmissao)
                .HasColumnName("DATAADMISSAO")
                .HasColumnType("date")
                .IsRequired();

            builder.Property(f => f.IdEmpresa)
                .HasColumnName("IDEMPRESA")
                .IsRequired();
        }
    }
}
