using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class Funcionario
    {
        [DisplayName("Código do Funcionário")]
        public int COD_FUNC { get; set; }

        [DisplayName("Nome do Funcionário")]
        public string NOME_FUNC { get; set; }

        [DisplayName("Telefone do Funcionário")]
        public int TEL_FUNC { get; set; }

        [DisplayName("Celular do Funcionário")]
        public int CEL_FUNC { get; set; }

        [DisplayName("Email do Funcionário")]
        public string EMAIL_FUNC { get; set; }

        [DisplayName("Cargo do Funcionário")]
        public string CARGO_FUNC { get; set; }
    }
}
