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
        public int COD_ANAMNESES { get; set; }

        [DisplayName("Paciente")]
        public int COD_PAC { get; set; } //FOREIGN KEY

        [DisplayName("Data de Cadastro")]
        public DateTime DATA_ANAMNESES { get; set; }

        [DisplayName("Descrição da Anamneses")]
        public string DESC_ANAMNESES { get; set; }

        [DisplayName("Fatos Importantes")]
        public string FATOSIMPO_ANAMNESES { get; set; }

        [DisplayName("Médico")]
        public int COD_MED { get; set; } //FOREIGN KEY
    }
}
