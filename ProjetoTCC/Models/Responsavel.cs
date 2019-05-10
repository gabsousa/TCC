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
        public int cod_resp { get; set; }

        [DisplayName("Nome do Responsável")]
        public string nome_resp { get; set; }

        [DisplayName("Nome do Responsável 2")]
        public string resp_dois { get; set; }

        [DisplayName("Endereço do Responsável")]
        public string end_resp { get; set; }

        [DisplayName("Telefone do Responsável")]
        public int tel_resp { get; set; }

        [DisplayName("Telefone Opcional")]
        public int tel_dois { get; set; }

        [DisplayName("Celular do Responsável")]
        public int cel_resp { get; set; }

        [DisplayName("Email do Responsável")]
        public string email_resp { get; set; }

        [DisplayName("CPF do Responsável")]
        public int cpf_resp { get; set; }
    }
}
