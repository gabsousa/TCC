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
        public int cod_agenda { get; set; }

        [DisplayName("Dia da Consulta")]
        public DateTime dia_consulta { get; set; }

        [DisplayName("Hora da Consulta")]
        public DateTime hora_consulta { get; set; }

        [DisplayName("Código do Médico")]
        public int cod_med { get; set; }
     
        [DisplayName("Código do Paciente")]
        public int cod_pac { get; set; }

        [DisplayName("Confirmação da Agenda")]
        public string confirmacao_agenda { get; set; }

        [DisplayName("Observação da Agenda")]
        public string obs_agenda { get; set; }

        [DisplayName("Responsável Pelo Agendamento")]
        public string resp_agendamento { get; set; }

        [DisplayName("Data de Retorno da Cosulta")]
        public DateTime data_retorno { get; set; }
    }
}
