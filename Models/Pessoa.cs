using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Controle_Financeiro.Models
{
    public class Pessoa
    {
        public int PessoaId {get;set;}
        public string Nome {get;set;}
        public int Cpf {get;set;}

        public ICollection<Lancamento> Lancamentos {get;set;}
    }
}