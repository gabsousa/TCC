using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class Anamneses
    {
        [DisplayName("Código Anamneses")]
        public int cod_anamneses { get; set; }

        [DisplayName("Paciente")]
        public int cod_pac { get; set; }

        [DisplayName("Data de Cadastro")]
        public DateTime data_anamneses { get; set; }

        [DisplayName("Descrição da Anamneses")]
        public string desc_anamneses { get; set; }

        [DisplayName("Fatos Importantes")]
        public string fatosimpo_anamneses { get; set; }

        [DisplayName("Médico")]
        public int cod_med { get; set; }
    }
}
