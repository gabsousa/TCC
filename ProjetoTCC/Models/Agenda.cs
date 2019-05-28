using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class Agenda
    {
        [DisplayName("Código de Agendamento")]
        public int COD_AGENDA { get; set; }

        [DisplayName("Dia da Consulta")]
        public DateTime DIA_CONSULTA { get; set; }

        [DisplayName("Hora da Consulta")]
        public DateTime HORA_CONSULTA { get; set; }

        [DisplayName("Código do Médico")]
        public int COD_MED { get; set; } //FOREIGN KEY
     
        [DisplayName("Código do Paciente")]
        public int COD_PAC { get; set; } //FOREIGN KEY

        [DisplayName("Confirmação da Agenda")]
        public string CONFIRMACAO_AGENDA { get; set; }

        [DisplayName("Observação da Agenda")]
        public string OBS_AGENDA { get; set; }

        [DisplayName("Responsável Pelo Agendamento")]
        public string RESP_AGENDAMENTO { get; set; }

        [DisplayName("Data de Retorno da Cosulta")]
        public DateTime DATA_RETORNO { get; set; }
    }
}
