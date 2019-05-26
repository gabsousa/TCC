using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public DateTime DATANASC_PAC { get; set; }

        [DisplayName("Responsável")]
        public int COD_RESP { get; set; }

        [DisplayName("Sexo do Paciente")]
        public string SEXO_PAC { get; set; }

        [DisplayName("Idade do Paciente")]
        public int IDADE_PAC { get; set; }
    }
}
