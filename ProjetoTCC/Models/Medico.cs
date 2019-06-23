using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class Medico
    {
        [DisplayName("Código do Médico")]
        public int COD_MED { get; set; }

        [DisplayName("Nome")]
        public string NOME_MED { get; set; }

        [DisplayName("Telefone")]
        public int TEL_MED { get; set; }

        [DisplayName("Celular")]
        public int CEL_MED { get; set; }

        [DisplayName("Email")]
        public string EMAIL_MED { get; set; }

        [DisplayName("CPF")]
        public string CPF_MED { get; set; }

        [DisplayName("CRM")]
        public string CRM { get; set; }

        [DisplayName("Validade do CRM")]
        public DateTime VALIDADE_CRM { get; set; }

        [DisplayName("Sexo")]
        public string SEXO_MED { get; set; }

        [DisplayName("Especialidade")] //FOREIGN KEY
        public int COD_ESPEC { get; set; }

        [DisplayName("Cargo")] // FOREIGN KEY
        public int COD_CARGO { get; set; }
    }
}
