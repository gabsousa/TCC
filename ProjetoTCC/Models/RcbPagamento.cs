using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class RcbPagamento
    {
        [DisplayName("Código do Serviço")]
        public int COD_SERV { get; set; }

        [DisplayName("Código do Paciente")] // FOREIGN KEY
        public int COD_PAC { get; set; }
     
        [DisplayName("Código do Médico")] // FOREIGN KEY
        public int COD_MED { get; set; }
     
        [DisplayName("Código do Agenda")] // FOREIGN KEY
        public int COD_AGENDA { get; set; }

        [DisplayName("Data de Pagamento")]
        public DateTime DATA_PGTO { get; set; }
    }
}
