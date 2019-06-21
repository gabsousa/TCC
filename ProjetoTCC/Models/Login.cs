using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Obrigatório informar o Login!")]
        [DisplayName("Usuário")]
        public string LOGIN { get; set; }

        [DisplayName("Senha do Funcionário")]
        public string SENHA { get; set; }

        [DisplayName("Nome do Funcionário")]
        public string NOME { get; set; }

        [DisplayName("Telefone do Funcionário")]
        public int COD_PAC { get; set; }

        [DisplayName("Celular do Funcionário")]
        public int COD_MED { get; set; }

        [DisplayName("Email do Funcionário")]
        public string COD_RESP { get; set; }

        [DisplayName("Cargo do Funcionário")]
        public string COD_FUNC { get; set; }
    }
}
