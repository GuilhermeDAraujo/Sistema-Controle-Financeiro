using Microsoft.AspNetCore.Identity;

namespace Projeto_Controle_Financeiro.Models
{
    public class AplicacaoUsuario : IdentityUser
    {
        public string? RefreshToken {get;set;}
        public DateTime RefreshTokenExpiryTime {get;set;}
    }
}