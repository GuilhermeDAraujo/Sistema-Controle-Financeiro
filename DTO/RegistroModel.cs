using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Controle_Financeiro.DTO
{
    public class RegistroModel
    {
        [Required(ErrorMessage = "Obrigatório informar o usúario")]
        public string? NomeDeUsuario { get; set; }
        
        [EmailAddress]
        [Required(ErrorMessage = "Obrigatório informar o email")]
        public string? Email { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a senha")]
        public string? Senha { get; set; }
    }
}