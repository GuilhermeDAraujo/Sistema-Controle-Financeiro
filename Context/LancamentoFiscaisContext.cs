using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_Controle_Financeiro.Models;

namespace Projeto_Controle_Financeiro.Context
{
    public class LancamentoFiscaisContext : DbContext
    {

        public LancamentoFiscaisContext(DbContextOptions<LancamentoFiscaisContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lancamento>()
                .HasOne(l => l.Pessoa)
                .WithMany(p => p.Lancamentos)
                .HasForeignKey(l => l.PessoaId)
                .OnDelete(DeleteBehavior.Cascade);
                
        }

        public DbSet<Pessoa> Pessoas {get;set;}
        public DbSet<Lancamento> Lancamentos {get;set;}
    }
}