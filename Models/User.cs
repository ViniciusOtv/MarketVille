using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Models
{
    public class User
    {
        /// <summary>
        /// Identificador único do usuário.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Nome Completo do usuário.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Senha do usuário. 
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Segunda coluna de senha, para confirmar se a primeira está valida. 
        /// </summary>
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// Email do usuário. Onde a autenticação será feita na plataforma. 
        /// </summary>
        public string Email { get; set; }

    }
}
