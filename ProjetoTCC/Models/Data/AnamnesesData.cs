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
        public void CadastrarAnamneses(Anamneses anamneses)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("INSERIR_ANAMNESES", msc);
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

        


        public List<Anamneses> ListaAnamneses()
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("LISTAR_ANAMNESES", msc);
            msda.SelectCommand.CommandType = CommandType.StoredProcedure;


            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Anamneses> lista = new List<Anamneses>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Anamneses item = new Anamneses();

                item.COD_ANAMNESES = int.Parse(dr["COD_ANAMNESES"].ToString());
                item.COD_PAC = int.Parse(dr["COD_PAC"].ToString());
                item.DATA_ANAMNESES = DateTime.Parse(dr["DATA_ANAMNESES"].ToString());
                item.DESC_ANAMNESES = dr["DESC_ANAMNESES"].ToString();
                item.FATOSIMPO_ANAMNESES = dr["FATOSIMPO_ANAMNESES"].ToString();
                item.COD_MED = int.Parse(dr["COD_MED"].ToString());

                lista.Add(item);
            }

            return lista;
        }

        public Anamneses DetalhesAnamneses(int COD_ANAMNESES)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_anamneses where COD_ANAMNESES = " + COD_ANAMNESES, msc);
            
            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Anamneses> lista = new List<Anamneses>();

            Anamneses item = new Anamneses();

            if (ds.Tables[0].Rows.Count > 0)
            {
                item.COD_ANAMNESES = int.Parse(ds.Tables[0].Rows[0]["COD_ANAMNESES"].ToString());
                item.COD_PAC = int.Parse(ds.Tables[0].Rows[0]["COD_PAC"].ToString());
                item.DATA_ANAMNESES = DateTime.Parse(ds.Tables[0].Rows[0]["data_anamneses"].ToString());
                item.DESC_ANAMNESES = ds.Tables[0].Rows[0]["DATA_ANAMNESES"].ToString();
                item.FATOSIMPO_ANAMNESES = ds.Tables[0].Rows[0]["FATOSIMPO_ANAMNESES"].ToString();
                item.COD_MED = int.Parse(ds.Tables[0].Rows[0]["COD_MED"].ToString());

            }

            return item;
        }

        public void EditarAnamneses(Anamneses anamneses)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("ALTERAR_ANAMNESES" + msc);
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

        public void DeletarAnamneses(int COD_ANAMNESES)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("call DELETAR_ANAMNESES (" + COD_ANAMNESES + ");", msc);
            
            cmd.ExecuteNonQuery();
            msc.Close();
        }
    }
}
