using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class Estoque
    {
        [DisplayName("Código do Produto")]
        public int COD_PROD { get; set; }

        [DisplayName("Nome do Produto")]
        public string NOME_PROD { get; set; }

        [DisplayName("Quantidade do Produto")]
        public int QNT_PROD { get; set; }

        [DisplayName("Data de Validade do Produto")]
        public DateTime DATA_VALIDADE { get; set; }

        [DisplayName("Nome do Fornecedor")]
        public string NOME_FORNEC { get; set; }

        [DisplayName("Data da Entrada do Produto")]
        public DateTime DATA_ENTRADA { get; set; }

        [DisplayName("Data da Retirada do Produto")]
        public DateTime DATA_RETIRADA { get; set; }

        [DisplayName("Hora da Retirada")]
        public DateTime HORA_RETIRADA { get; set; }

        [DisplayName("Responsáel Pela Retirada")]
        public string RESP_RETIRADA { get; set; }
    }
}
