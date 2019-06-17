using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class Login
    {
        [DisplayName("Usuário")]
        public int LOGIN { get; set; }

        [DisplayName("Nome do Funcionário")]
        public string SENHA { get; set; }

        //[DisplayName("Telefone do Funcionário")]
        //public int COD_PAC { get; set; }

        //[DisplayName("Celular do Funcionário")]
        //public int cel_func { get; set; }

        //[DisplayName("Email do Funcionário")]
        //public string email_func { get; set; }

        //[DisplayName("Cargo do Funcionário")]
        //public string cargo_func { get; set; }
    }
}
