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
        public int cod_prod { get; set; }

        [DisplayName("Nome do Produto")]
        public string nome_prod { get; set; }

        [DisplayName("Quantidade do Produto")]
        public int qtd_prod { get; set; }

        [DisplayName("Data de Validade do Produto")]
        public int data_validade { get; set; }

        [DisplayName("Nome do Fornecedor")]
        public string nome_fornec { get; set; }

        [DisplayName("Data da Entrada do Produto")]
        public int data_entrada { get; set; }

        [DisplayName("Data da Retirada do Produto")]
        public int data_saida { get; set; }

        [DisplayName("Hora da Retirada")]
        public DateTime hora_retirada { get; set; }

        [DisplayName("Responsáel Pela Retirada")]
        public string resp_retirada { get; set; }
    }
}
