using AplicaçãoWebJP.Data.Repositorio.Interface;
using AplicaçãoWebJP.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicaçãoWebJP.Controllers
{
    public class AlunosController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunosController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult InserirAluno(AlunoModel alunos)
        {
            _alunoRepositorio.InserirAluno(alunos);
            return View();
        }
    }
}
