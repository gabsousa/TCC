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

            cmd.Parameters.AddWithValue("@COD_ANAMNESES", anamneses.COD_ANAMNESES);
            cmd.Parameters.AddWithValue("@COD_PAC", anamneses.COD_PAC);
            cmd.Parameters.AddWithValue("@DATA_ANAMNESES", anamneses.DATA_ANAMNESES);
            cmd.Parameters.AddWithValue("@DESC_ANAMNESES", anamneses.DESC_ANAMNESES);
            cmd.Parameters.AddWithValue("@FATOSIMPO_ANAMNESES", anamneses.FATOSIMPO_ANAMNESES);
            cmd.Parameters.AddWithValue("@COD_MED", anamneses.COD_MED);

            cmd.ExecuteNonQuery();
            msc.Close();
        }
    }
}
