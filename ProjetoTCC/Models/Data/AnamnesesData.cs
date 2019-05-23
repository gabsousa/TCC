using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models.Data
{
    public class AnamnesesData
    {
        public void CadastarAnamneses(Anamneses anamneses)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("INSERIR_ANAMNESES");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cod_anamneses", anamneses.cod_anamneses);
            cmd.Parameters.AddWithValue("@cod_pac", anamneses.cod_pac);
            cmd.Parameters.AddWithValue("@data_anamneses", anamneses.data_anamneses);
            cmd.Parameters.AddWithValue("@desc_anammneses", anamneses.desc_anamneses);
            cmd.Parameters.AddWithValue("@fatosimpo_anamneses", anamneses.fatosimpo_anamneses);
            cmd.Parameters.AddWithValue("@cod_med", anamneses.cod_med);

            cmd.ExecuteNonQuery();
            msc.Close();
        }
    }
}
