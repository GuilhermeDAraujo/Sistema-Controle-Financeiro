using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projeto_Controle_Financeiro.Models;

namespace Projeto_Controle_Financeiro.Context
{
    public class LancamentoFiscaisContext : IdentityDbContext<AplicacaoUsuario>
    {

        public LancamentoFiscaisContext(DbContextOptions<LancamentoFiscaisContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Lancamento>()
                .HasOne(l => l.Pessoa)
                .WithMany(p => p.Lancamentos)
                .HasForeignKey(l => l.PessoaId);
                
            base.OnModelCreating(builder);
        }

        public DbSet<Pessoa> Pessoas {get;set;}
        public DbSet<Lancamento> Lancamentos {get;set;}
    }
}