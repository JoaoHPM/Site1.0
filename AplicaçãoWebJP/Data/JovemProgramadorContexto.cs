using AplicaçãoWebJP.Data.Mapeamento;
using AplicaçãoWebJP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicaçãoWebJP.Data
{
    public class JovemProgramadorContexto: DbContext
    {
        public JovemProgramadorContexto(DbContextOptions<JovemProgramadorContexto> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMapping());
        }
        public DbSet<AlunoModel> Aluno { get; set; }
    }
}
