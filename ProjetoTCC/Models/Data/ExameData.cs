using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models.Data
{
    public class ExameData
    {
        public void CadastrarExame(Exame exame)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("INSERIR_EXAME)", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_EXAME", exame.COD_EXAME);
            cmd.Parameters.AddWithValue("@COD_PAC", exame.COD_PAC);
            cmd.Parameters.AddWithValue("@NOME_EXAME", exame.NOME_EXAME);
            cmd.Parameters.AddWithValue("@DATA_EXAME", exame.DATA_EXAME);
            cmd.Parameters.AddWithValue("@NOME_LAB", exame.NOME_LAB);
            cmd.Parameters.AddWithValue("@HORA_EXAME", exame.HORA_EXAME);
            cmd.Parameters.AddWithValue("@ARQ_EXAME", exame.ARQ_EXAME);
            cmd.Parameters.AddWithValue("@COD_MED", exame.COD_MED);
            cmd.Parameters.AddWithValue("@OBS_EXAME", exame.OBS_EXAME);

            cmd.ExecuteNonQuery();
            msc.Close();
        }

        public List<Exame> ListaExame()
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            //MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_exame", msc);
            MySqlDataAdapter msda = new MySqlDataAdapter("LISTAR_EXAME", msc);
            msda.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Exame> lista = new List<Exame>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Exame item = new Exame();

                item.COD_EXAME = int.Parse(dr["COD_EXAME"].ToString());
                item.COD_PAC = int.Parse(dr["COD_PAC"].ToString());
                item.NOME_EXAME = dr["NOME_EXAME"].ToString();
                item.DATA_EXAME = DateTime.Parse(dr["DATA_EXAME"].ToString());
                item.NOME_LAB = dr["NOME_LAB"].ToString();
                item.HORA_EXAME = DateTime.Parse(dr["HORA_EXAME"].ToString());
                //item.ARQ_EXAME = Byte[].Parse(dr["ARQ_EXAME"].ToString());
                item.COD_MED = int.Parse(dr["COD_MED"].ToString());
                item.OBS_EXAME = dr["OBS_EXAME"].ToString();

                lista.Add(item);
            }

            return lista;
        }

        public Exame DetalhesExame(int COD_EXAME)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            //MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_exame where COD_EXAME = " + COD_EXAME, msc);
            MySqlDataAdapter msda = new MySqlDataAdapter("CONSULTAR_EXAME" + COD_EXAME, msc);
            msda.SelectCommand.CommandType = CommandType.StoredProcedure;


            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Exame> lista = new List<Exame>();

            Exame item = new Exame();

            if (ds.Tables[0].Rows.Count > 0)
            {
                item.COD_EXAME = int.Parse(ds.Tables[0].Rows[0]["COD_EXAME"].ToString());
                item.COD_PAC = int.Parse(ds.Tables[0].Rows[0]["COD_PAC"].ToString());
                item.NOME_EXAME = ds.Tables[0].Rows[0]["NOME_EXAME"].ToString();
                item.DATA_EXAME = DateTime.Parse(ds.Tables[0].Rows[0]["DATA_EXAME"].ToString());
                item.NOME_LAB = ds.Tables[0].Rows[0]["NOME_LAB"].ToString();
                item.HORA_EXAME = DateTime.Parse(ds.Tables[0].Rows[0]["HORA_EXAME"].ToString());
                //item.ARQ_EXAME = ds.Tables[0].Rows[0]["ARQ_EXAME"].ToString();
                item.COD_MED = int.Parse(ds.Tables[0].Rows[0]["COD_MED"].ToString());
                item.OBS_EXAME = ds.Tables[0].Rows[0]["OBS_EXAME"].ToString();
            }

            return item;
        }

        public void EditarExame(Exame exame)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("ALTERAR_EXAME", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_EXAME", exame.COD_EXAME);
            cmd.Parameters.AddWithValue("@COD_PAC", exame.COD_PAC);
            cmd.Parameters.AddWithValue("@NOME_EXAME", exame.NOME_EXAME);
            cmd.Parameters.AddWithValue("@DATA_EXAME", exame.DATA_EXAME);
            cmd.Parameters.AddWithValue("@NOME_LAB", exame.NOME_LAB);
            cmd.Parameters.AddWithValue("@HORA_EXAME", exame.HORA_EXAME);
            cmd.Parameters.AddWithValue("@ARQ_EXAME", exame.ARQ_EXAME);
            cmd.Parameters.AddWithValue("@COD_MED", exame.COD_MED);
            cmd.Parameters.AddWithValue("@OBS_EXAME", exame.OBS_EXAME);

            cmd.ExecuteNonQuery();
            msc.Close();
        }

        public void DeletarExame(int COD_EXAME)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("DELETAR_EXAME" + COD_EXAME, msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();

            msc.Close();
        }


    }
}
