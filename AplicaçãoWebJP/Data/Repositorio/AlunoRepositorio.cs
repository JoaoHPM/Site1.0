using AplicaçãoWebJP.Data.Repositorio.Interface;
using AplicaçãoWebJP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicaçãoWebJP.Data.Repositorio
{
    public class AlunoRepositorio: IAlunoRepositorio
    {
        private readonly JovemProgramadorContexto _jovemProgramadorContexto;
        
        public AlunoRepositorio(JovemProgramadorContexto jovemProgramadorContexto)
        {
            _jovemProgramadorContexto = jovemProgramadorContexto;
        }

        public void InserirAluno(AlunoModel alunos)
        {
            _jovemProgramadorContexto.Aluno.Add(alunos);
            _jovemProgramadorContexto.SaveChanges();
        }
    }
}
