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

        public void EditarAnamneses(Anamneses anamneses)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("ALTERAR_ANAMNESES");
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

        public void DeletarAnamneses(Anamneses anamneses)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("DELETAR_ANAMNESES");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
            msc.Close();
        }


        public List<Anamneses> ListaAnamneses()
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("bd_clinicare.CONSULTAR_ANAMNESES", msc);
            msda.SelectCommand.CommandType = CommandType.StoredProcedure;


            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Anamneses> lista = new List<Anamneses>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Anamneses item = new Anamneses();

                item.cod_anamneses = int.Parse(dr["cod_anamneses"].ToString());
                item.cod_pac = int.Parse(dr["cod_pac"].ToString());
                item.data_anamneses = DateTime.Parse(dr["data_anamneses"].ToString());
                item.desc_anamneses = dr["desc_anamneses"].ToString();
                item.fatosimpo_anamneses = dr["fatosimpo_anamneses"].ToString();
                item.cod_med = int.Parse(dr["cod_med"].ToString());

                lista.Add(item);
            }

            return lista;
        }

        public Anamneses DetalhesAnamneses(int cod_anamneses)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("bd_clinicare.CONSULTAR_ANAMNESES" + cod_anamneses, msc);
            msda.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Anamneses> lista = new List<Anamneses>();

            Anamneses item = new Anamneses();

            if (ds.Tables[0].Rows.Count > 0)
            {
                item.cod_anamneses = int.Parse(ds.Tables[0].Rows[0]["cod_anamneses"].ToString());
                item.cod_pac = int.Parse(ds.Tables[0].Rows[0]["cod_pac"].ToString());
                item.data_anamneses = DateTime.Parse(ds.Tables[0].Rows[0]["data_anamneses"].ToString());
                item.desc_anamneses = ds.Tables[0].Rows[0]["desc_anamneses"].ToString();
                item.fatosimpo_anamneses = ds.Tables[0].Rows[0]["fatosimpo_anamneses"].ToString();
                item.cod_med = int.Parse(ds.Tables[0].Rows[0]["cod_med"].ToString());
                
            }

            return item;
        }
    }
}
