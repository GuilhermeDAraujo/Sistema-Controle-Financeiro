using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto_Controle_Financeiro.Context;
using Projeto_Controle_Financeiro.Models;

namespace Projeto_Controle_Financeiro.Controllers
{
    public class PessoaController : Controller
    {
        private readonly LancamentoFiscaisContext _context;

        public PessoaController(LancamentoFiscaisContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var pessoas = _context.Pessoas.ToList();
            return View(pessoas);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Pessoa pessoa)
        {
            if(ModelState.IsValid)
            {
                _context.Pessoas.Add(pessoa);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Editar(int id)
        {
            var pessoa = _context.Pessoas.Find(id);

            if(pessoa == null)
                return RedirectToAction(nameof(Index));
            
            return View(pessoa);
        }

        [HttpPost]
        public IActionResult Editar(Pessoa pessoa)
        {
            var pessoaBanco = _context.Pessoas.Find(pessoa.PessoaId);

            pessoaBanco.Nome = pessoa.Nome;
            pessoaBanco.Cpf = pessoa.Cpf;

            _context.Pessoas.Update(pessoaBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Deletar(int id)
        {
            var pessoa = _context.Pessoas.Find(id);

            if(pessoa == null)
                return RedirectToAction(nameof(Index));

            return View(pessoa);
        }

        [HttpPost]
        public IActionResult Deletar(Pessoa pessoa)
        {
            var pessoaBanco = _context.Pessoas.Find(pessoa.PessoaId);

            _context.Pessoas.Remove(pessoaBanco);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}