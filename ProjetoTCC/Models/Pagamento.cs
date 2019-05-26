using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class Pagamento
    {
        [DisplayName("Código do Pagamento")]
        public int COD_PGTO { get; set; }

        [DisplayName("Código do Serviço")]
        public int COD_SERV { get; set; }

        [DisplayName("Forma de Pagamento")]
        public string FORMA_PGTO { get; set; }

        [DisplayName("Tpo de Pagamento")]
        public string TIPO_PGTO { get; set; }

        [DisplayName("Tipo de Cartão")]
        public string TIPO_CARTAO { get; set; }

        [DisplayName("Quantidade de Parcelas")]
        public int QTD_PARCELA { get; set; }

        [DisplayName("VALOR da Consulta")]
        public Decimal VALOR { get; set; }

        [DisplayName("Status do Pagamento")]
        public string STATUS_PGTO { get; set; }

        [DisplayName("Observação do Pagamento")]
        public string OBS_PGTO { get; set; }
    }
}
