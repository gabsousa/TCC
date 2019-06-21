using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models
{
    public class Paciente
    {
        [DisplayName("Código do Paciente")]
        public int COD_PAC { get; set; }

        [DisplayName("Nome do Paciente")]
        public string NOME_PAC { get; set; }

        [DisplayName("Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DATANASC_PAC { get; set; }

        [DisplayName("Sexo do Paciente")]
        public string SEXO_PAC { get; set; }

        [DisplayName("Idade do Paciente")]
        public int IDADE_PAC { get; set; }

        [DisplayName("Nome do Responsável")]
        public string NOME_RESP { get; set; }

        [DisplayName("Nome do Responsável 2")]
        public string RESP_DOIS { get; set; }

        [DisplayName("Telefone do Responsável")]
        public int TEL_RESP { get; set; }

        [DisplayName("Telefone Opcional")]
        public int TEL_DOIS { get; set; }

        [DisplayName("Celular do Responsável")]
        public int CEL_RESP { get; set; }

        [DisplayName("Email do Responsável")]
        public string EMAIL_RESP { get; set; }

        [DisplayName("CPF do Responsável")]
        public string CPF_RESP { get; set; }

        [DisplayName("Rua")]
        public string RUA_PAC { get; set; }

        [DisplayName("Município")]
        public string MUN_PAC { get; set; }

        [DisplayName("UF")]
        public string UF_PAC { get; set; }

        [DisplayName("Número")]
        public int NUM_PAC { get; set; }

        [DisplayName("CEP")]
        public int CEP_PAC { get; set; }

        [DisplayName("Bairro")]
        public string BAIRRO_PAC { get; set; }
    }
}