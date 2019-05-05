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
        public int cod_serv { get; set; }

   //   [DisplayName("Código do Paciente")] - FOREIGN KEY
   //   public int cod_pac { get; set; }

   //   [DisplayName("Código do Médico")] - FOREIGN KEY
   //   public int cod_med { get; set; }

   //   [DisplayName("Código do Agenda")] - FOREIGN KEY
   //   public int cod_agenda { get; set; }

        [DisplayName("Data de Pagamento")]
        public DateTime data_pgto { get; set; }
    }
}
