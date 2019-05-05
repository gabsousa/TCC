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
        public int cod_pagto { get; set; }

   //   [DisplayName("Código do Serviço")] - FOREIGN KEY
   //   public int cod_serv { get; set; }

        [DisplayName("Forma de Pagamento")]
        public string forma_pgto { get; set; }

        [DisplayName("Tpo de Pagamento")]
        public string tipo_pgto { get; set; }

        [DisplayName("Tipo de Cartão")]
        public string tipo_cartao { get; set; }

        [DisplayName("Quantidade de Parcelas")]
        public int qtd_parcela { get; set; }

        [DisplayName("Valor da Consulta")]
        public Decimal valor { get; set; }

        [DisplayName("Status do Pagamento")]
        public string status_pgto { get; set; }

        [DisplayName("Observação do Pagamento")]
        public string obs_pgto { get; set; }
    }
}
