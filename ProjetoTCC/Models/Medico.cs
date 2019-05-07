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
        public int cod_med { get; set; }

        [DisplayName("Nome do Médico")]
        public string nome_med { get; set; }

        [DisplayName("Telefone do Médico")]
        public int tel_med { get; set; }

        [DisplayName("Celular do Médico")]
        public int cel_med { get; set; }

        [DisplayName("Email do Médico")]
        public string email_med { get; set; }

        [DisplayName("CPF do Médico")]
        public int cpf_med { get; set; }

        [DisplayName("RG do Médico")]
        public int rg_med { get; set; }

        [DisplayName("CRM do Médico")]
        public string crm_med { get; set; }

        [DisplayName("Validade do CRM")]
        public DateTime validade_crm { get; set; }

        [DisplayName("Sexo do Médico")]
        public string sexo_med { get; set; }

        [DisplayName("Especialidade do Médico")]
        public int cod_espec { get; set; }
    }
}
