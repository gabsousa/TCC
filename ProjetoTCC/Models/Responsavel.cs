using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class Responsavel
    {
        [DisplayName("Código do Responsável")]
        public int COD_RESP { get; set; }

        [DisplayName("Nome do Responsável")]
        public string NOME_RESP { get; set; }

        [DisplayName("Nome do Responsável 2")]
        public string RESP_DOIS { get; set; }

        [DisplayName("Endereço do Responsável")]
        public string COD_END { get; set; }

        [DisplayName("Telefone do Responsável")]
        public int TEL_RESP { get; set; }

        [DisplayName("Telefone Opcional")]
        public int TEL_DOIS { get; set; }

        [DisplayName("Celular do Responsável")]
        public int CEL_RESP { get; set; }

        [DisplayName("Email do Responsável")]
        public string EMAIL_RESP { get; set; }

        [DisplayName("CPF do Responsável")]
        public int CPF_RESP { get; set; }

//      [DisplayName("Imagem do Responsável")]
//      public ????
    }
}
