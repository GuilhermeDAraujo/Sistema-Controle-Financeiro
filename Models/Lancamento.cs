using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Controle_Financeiro.Models
{
    public class Lancamento
    {
        public int LancamentoId {get;set;}
        public DateTime DataDaCompra {get;set;}
        public string Banco {get;set;}
        public string Descricao {get;set;}
        public Decimal Valor {get;set;}

        
        public int PessoaId {get;set;}
        public Pessoa Pessoa {get;set;}
    }
}