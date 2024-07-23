using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_Controle_Financeiro.Context;
using Projeto_Controle_Financeiro.Models;

namespace Projeto_Controle_Financeiro.Controllers
{
    public class LancamentoController : Controller
    {
        private readonly LancamentoFiscaisContext _context;

        public LancamentoController(LancamentoFiscaisContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var lancamentos = _context.Lancamentos.Include(l => l.Pessoa).ToList();
            return View(lancamentos);
        }

        public IActionResult Criar()
        {
            var model = new Lancamento
            {
                DataDaCompra = DateTime.Now
            };
            ViewBag.Pessoa = new SelectList(_context.Pessoas.ToList(), "PessoaId", "Nome");
            return View(model);
        }

        [HttpPost]
        public IActionResult Criar(Lancamento lancamento)
        {
            if(ModelState.IsValid)
            {
                _context.Lancamentos.Add(lancamento);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(lancamento);
        }

        public IActionResult Editar(int id)
        {
            var lancamento = _context.Lancamentos.Find(id);

            if(lancamento == null)
                return RedirectToAction(nameof(Index));
            
            ViewBag.Pessoa = new SelectList(_context.Pessoas.ToList(), "PessoaId", "Nome");
            return View(lancamento);
        }

        [HttpPost]
        public IActionResult Editar(Lancamento lancamento)
        {
            var lancamentoBanco = _context.Lancamentos.Find(lancamento.LancamentoId);

            if(lancamentoBanco == null)
                return RedirectToAction(nameof(Index));

            lancamentoBanco.PessoaId = lancamento.PessoaId;
            lancamentoBanco.DataDaCompra = lancamento.DataDaCompra;
            lancamentoBanco.Banco = lancamento.Banco;
            lancamentoBanco.Descricao = lancamento.Descricao;
            lancamentoBanco.Valor = lancamento.Valor;

            _context.Lancamentos.Update(lancamentoBanco);
            _context.SaveChanges();
  
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var lancamento = _context.Lancamentos.Find(id);

            if(lancamento == null)
                return RedirectToAction(nameof(Index));
            
            ViewBag.Pessoa = new SelectList(_context.Pessoas.ToList(), "PessoaId", "Nome");
            return View(lancamento);
        }

        public IActionResult Deletar(int id)
        {
            var lancamento = _context.Lancamentos.Find(id);

            if(lancamento == null)
                return RedirectToAction(nameof(Index));
            
            ViewBag.Pessoa = new SelectList(_context.Pessoas.ToList(), "PessoaId", "Nome");
            return View(lancamento);
        }

        [HttpPost]
        public IActionResult Deletar(Lancamento lancamento)
        {
            var lancamentoBanco = _context.Lancamentos.Find(lancamento.LancamentoId);

            _context.Lancamentos.Remove(lancamentoBanco);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Filtrar()
        {
            return View();
        }
    }
}