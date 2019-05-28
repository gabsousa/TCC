using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models.Data
{
    public class ResponsavelData
    {
        public void CadastarResponsavel(Responsavel responsavel)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("INSERIR_RESPONSAVEL", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_RESP", responsavel.COD_RESP);
            cmd.Parameters.AddWithValue("@NOME_RESP", responsavel.NOME_RESP);
            cmd.Parameters.AddWithValue("@RESP_DOIS", responsavel.RESP_DOIS);
            cmd.Parameters.AddWithValue("@TEL_RESP", responsavel.TEL_RESP);
            cmd.Parameters.AddWithValue("@TEL_DOIS", responsavel.TEL_DOIS);
            cmd.Parameters.AddWithValue("@CEL_RESP", responsavel.CEL_RESP);
            cmd.Parameters.AddWithValue("@EMAIL_RESP", responsavel.EMAIL_RESP);
            cmd.Parameters.AddWithValue("@CPF_RESP", responsavel.CPF_RESP);

            cmd.ExecuteNonQuery();
            msc.Close();
        }

        public List<Responsavel> ListaResponsavel()
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("LISTAR_RESPONSAVEL", msc);
            msda.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Responsavel> lista = new List<Responsavel>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Responsavel item = new Responsavel();

                item.COD_RESP = int.Parse(dr["COD_RESP"].ToString());
                item.NOME_RESP = dr["NOME_RESP"].ToString();
                item.RESP_DOIS = dr["RESP_DOIS"].ToString();
                item.TEL_RESP = int.Parse(dr["TEL_RESP"].ToString());
                item.TEL_DOIS = int.Parse(dr["TEL_DOIS"].ToString());
                item.CEL_RESP = int.Parse(dr["CEL_RESP"].ToString());
                item.EMAIL_RESP = dr["EMAIL_RESP"].ToString();
                item.CPF_RESP = int.Parse(dr["CPF_RESP"].ToString());

                lista.Add(item);
            }

            return lista;
        }

        public Responsavel DetalhesResponsavel(int COD_RESP)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("CONSULTAR_RESPONSAVEL" + COD_RESP, msc);
            msda.SelectCommand.CommandType = CommandType.StoredProcedure;


            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Responsavel> lista = new List<Responsavel>();

            Responsavel item = new Responsavel();

            if (ds.Tables[0].Rows.Count > 0)
            {
                item.COD_RESP = int.Parse(ds.Tables[0].Rows[0]["COD_RESP"].ToString());
                item.NOME_RESP = ds.Tables[0].Rows[0]["NOME_RESP"].ToString();
                item.RESP_DOIS = ds.Tables[0].Rows[0]["RESP_DOIS"].ToString();
                item.TEL_RESP = int.Parse(ds.Tables[0].Rows[0]["TEL_RESP"].ToString());
                item.TEL_DOIS = int.Parse(ds.Tables[0].Rows[0]["TEL_DOIS"].ToString());
                item.CEL_RESP = int.Parse(ds.Tables[0].Rows[0]["CEL_RESP"].ToString());
                item.EMAIL_RESP = ds.Tables[0].Rows[0]["EMAIL_RESP"].ToString();
                item.CPF_RESP = int.Parse(ds.Tables[0].Rows[0]["CPF_RESP"].ToString());
            }

            return item;
        }

        public void EditarResponsavel(Responsavel responsavel)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("ALTERAR_RESPONSAVEL");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_RESP", responsavel.COD_RESP);
            cmd.Parameters.AddWithValue("@NOME_RESP", responsavel.NOME_RESP);
            cmd.Parameters.AddWithValue("@RESP_DOIS", responsavel.RESP_DOIS);
            cmd.Parameters.AddWithValue("@TEL_RESP", responsavel.TEL_RESP);
            cmd.Parameters.AddWithValue("@TEL_DOIS", responsavel.TEL_DOIS);
            cmd.Parameters.AddWithValue("@CEL_RESP", responsavel.CEL_RESP);
            cmd.Parameters.AddWithValue("@EMAIL_RESP", responsavel.EMAIL_RESP);
            cmd.Parameters.AddWithValue("@CPF_RESP", responsavel.CPF_RESP);

            cmd.ExecuteNonQuery();
            msc.Close();
        }

        public void DeletarResponsavel(int COD_RESP)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("DELETAR_RESPONSAVEL" + COD_RESP, msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();

            msc.Close();
        }
    }
}
