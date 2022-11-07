﻿using AplicaçãoWebJP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicaçãoWebJP.Data.Mapeamento
{
    public class AlunoMapping: IEntityTypeConfiguration<AlunoModel>
    {
        public void Configure(EntityTypeBuilder<AlunoModel> builder)
        {
            builder.ToTable("Alunos");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome).HasColumnType("varchar(255)");

            builder.Property(t => t.Idade).HasColumnType("int");

            builder.Property(t => t.Contato).HasColumnType("varchar(50)");

            builder.Property(t => t.Email).HasColumnType("varchar(50)");

            builder.Property(t => t.Cep).HasColumnType("varchar(50)");
        }
    }
}
