using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Controle_Financeiro.DTO
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Obrigatório informar o usúario")]
        public string? NomeDeUsuario { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        public string Senha { get; set; }
    }
}