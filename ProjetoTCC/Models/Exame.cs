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
        public int cod_exame { get; set; }

   //   [DisplayName("Código do Paciente")] - FOREIGN KEY
   //   public int cod_pac { get; set; }

        [DisplayName("Nome do Exame")]
        public string nome_exame { get; set; }

        [DisplayName("Data do Exame")]
        public DateTime data_exame { get; set; }

        [DisplayName("Nome do Laboratório")]
        public string nome_lab { get; set; }

        [DisplayName("Hora do Exame")]
        public DateTime hora_exame { get; set; }

  //    [DisplayName("Arquivo do Exame")]
  //    public Byte[] arq_exame { get; set; }
       
        [DisplayName("Médico")]
        public int cod_med { get; set; }

        [DisplayName("Observação do Exame")]
        public string obs_exame { get; set; }
    }
}
