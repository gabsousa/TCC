using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class Paciente
    {
        [DisplayName("Código do Paciente")]
        public int cod_pac { get; set; }

        [DisplayName("Nome do Paciente")]
        public string nome_pac { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime datanasc_pac { get; set; }

    //  [DisplayName("Responsável")] - FOREIGN KEY
    //  public int cod_resp { get; set; }

        [DisplayName("Idade do Paciente")]
        public int int_pac { get; set; }
    }
}
