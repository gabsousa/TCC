using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class Exame
    {
        [DisplayName("Código do Exame")]
        public int COD_EXAME { get; set; }

        [DisplayName("Código do Paciente")] //FOREIGN KEY
        public int COD_PAC { get; set; }

        [DisplayName("Nome do Exame")]
        public string NOME_EXAME { get; set; }

        [DisplayName("Data do Exame")]
        public DateTime DATA_EXAME { get; set; }

        [DisplayName("Nome do Laboratório")]
        public string NOME_LAB { get; set; }

        [DisplayName("Hora do Exame")]
        public DateTime HORA_EXAME { get; set; }

        [DisplayName("Arquivo do Exame")]  //NÃO ESTA DECLARADA NO LAYOUT
        public Byte[] ARQ_EXAME { get; set; }
       
        [DisplayName("Médico")] //FOREIGN KEY
        public int COD_MED { get; set; }

        [DisplayName("Observação do Exame")]
        public string OBS_EXAME { get; set; }
    }
}
