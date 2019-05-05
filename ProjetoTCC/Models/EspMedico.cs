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
        public int cod_espec { get; set; }

        [DisplayName("Tipo de Especialidade")]
        public string tipo_espec { get; set; }

        [DisplayName("Descrição da Especialidade")]
        public string descricao_espec { get; set; }
    }
}
