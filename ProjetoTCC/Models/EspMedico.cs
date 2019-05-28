using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class EspMedico
    {
        [DisplayName("Código da Especialidade")]
        public int COD_ESPEC { get; set; }

        [DisplayName("Tipo de Especialidade")]
        public string TIPO_ESPEC { get; set; }

        [DisplayName("Descrição da Especialidade")]
        public string DESC_ESPEC { get; set; }
    }
}
