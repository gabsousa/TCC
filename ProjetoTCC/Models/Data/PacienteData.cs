using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models.Data
{
    public class PacienteData
    {
        public void CadastarPaciente(Paciente paciente)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=db_games");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("insert into tb_clientes values (@cod_pac, @nome_pac, @datanasc_pac, @sexo_pac, @idade_pac)", msc);

            cmd.Parameters.AddWithValue("@cod_pac", paciente.cod_pac);
            cmd.Parameters.AddWithValue("@nome_pac", paciente.nome_pac);
            cmd.Parameters.AddWithValue("@datanasc_pac", paciente.datanasc_pac);
            cmd.Parameters.AddWithValue("@sexo_pac", paciente.sexo_pac);

            cmd.ExecuteNonQuery();
            msc.Close();
        }
    }
}
