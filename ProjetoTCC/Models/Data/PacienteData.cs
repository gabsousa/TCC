using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models.Data
{
    public class PacienteData
    {
        public void CadastrarPaciente(Paciente paciente)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("INSERIR_PACIENTE", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_PAC", paciente.COD_PAC);
            cmd.Parameters.AddWithValue("@NOME_PAC", paciente.NOME_PAC);
            cmd.Parameters.AddWithValue("@DATANASC_PAC", paciente.DATANASC_PAC);
            cmd.Parameters.AddWithValue("@SEXO_PAC", paciente.SEXO_PAC);
            cmd.Parameters.AddWithValue("@IDADE_PAC", paciente.IDADE_PAC);
            cmd.Parameters.AddWithValue("@NOME_RESP", paciente.NOME_RESP);
            cmd.Parameters.AddWithValue("@RESP_DOIS", paciente.RESP_DOIS);
            cmd.Parameters.AddWithValue("@TEL_RESP", paciente.TEL_RESP);
            cmd.Parameters.AddWithValue("@TEL_DOIS", paciente.TEL_DOIS);
            cmd.Parameters.AddWithValue("@CEL_RESP", paciente.CEL_RESP);
            cmd.Parameters.AddWithValue("@EMAIL_RESP", paciente.EMAIL_RESP);
            cmd.Parameters.AddWithValue("@CPF_RESP", paciente.CPF_RESP);
            cmd.Parameters.AddWithValue("@RUA_PAC", paciente.RUA_PAC);
            cmd.Parameters.AddWithValue("@MUN_PAC", paciente.MUN_PAC);
            cmd.Parameters.AddWithValue("@UF_PAC", paciente.UF_PAC);
            cmd.Parameters.AddWithValue("@NUM_PAC", paciente.NUM_PAC);
            cmd.Parameters.AddWithValue("@CEP_PAC", paciente.CEP_PAC);
            cmd.Parameters.AddWithValue("@BAIRRO_PAC", paciente.BAIRRO_PAC);
            cmd.ExecuteNonQuery();

            msc.Close();
        }

        public List<Paciente> ListaPaciente()
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("LISTAR_PACIENTE", msc);
            msda.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Paciente> lista = new List<Paciente>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Paciente item = new Paciente();

                item.COD_PAC = int.Parse(dr["COD_PAC"].ToString());
                item.NOME_PAC = dr["NOME_PAC"].ToString();
                item.DATANASC_PAC = DateTime.Parse(dr["DATANASC_PAC"].ToString());
                item.SEXO_PAC = dr["SEXO_PAC"].ToString();
                item.IDADE_PAC = int.Parse(dr["IDADE_PAC"].ToString());
                item.NOME_RESP = dr["NOME_RESP"].ToString();
                item.RESP_DOIS = dr["RESP_DOIS"].ToString();
                item.TEL_RESP = int.Parse(dr["TEL_RESP"].ToString());
                item.TEL_DOIS = int.Parse(dr["TEL_DOIS"].ToString());
                item.CEL_RESP = int.Parse(dr["CEL_RESP"].ToString());
                item.CPF_RESP = dr["CPF_RESP"].ToString();
                item.RUA_PAC = dr["RUA_PAC"].ToString();
                item.NUM_PAC = int.Parse(dr["NUM_PAC"].ToString());
                item.CEP_PAC = int.Parse(dr["CEP_PAC"].ToString());
                item.BAIRRO_PAC = dr["BAIRRO_PAC"].ToString();
                item.MUN_PAC = dr["MUN_PAC"].ToString();
                item.UF_PAC = dr["UF_PAC"].ToString();
                lista.Add(item);
            }

            return lista;
        }

        public Paciente DetalhesPaciente(int COD_PAC)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_paciente where COD_PAC = " + COD_PAC, msc);

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Paciente> lista = new List<Paciente>();

            Paciente item = new Paciente();

            if (ds.Tables[0].Rows.Count > 0)
            {
                item.COD_PAC = int.Parse(ds.Tables[0].Rows[0]["COD_PAC"].ToString());
                item.NOME_PAC = ds.Tables[0].Rows[0]["NOME_PAC"].ToString();
                item.DATANASC_PAC = DateTime.Parse(ds.Tables[0].Rows[0]["DATANASC_PAC"].ToString());
                item.IDADE_PAC = int.Parse(ds.Tables[0].Rows[0]["IDADE_PAC"].ToString());
                item.SEXO_PAC = ds.Tables[0].Rows[0]["SEXO_PAC"].ToString();
                item.NOME_RESP = ds.Tables[0].Rows[0]["NOME_RESP"].ToString();
                item.TEL_RESP = int.Parse(ds.Tables[0].Rows[0]["TEL_RESP"].ToString());
                item.CEL_RESP = int.Parse(ds.Tables[0].Rows[0]["CEL_RESP"].ToString());
                item.RESP_DOIS = ds.Tables[0].Rows[0]["RESP_DOIS"].ToString();
                item.TEL_DOIS = int.Parse(ds.Tables[0].Rows[0]["TEL_DOIS"].ToString());
                item.CPF_RESP = ds.Tables[0].Rows[0]["CPF_RESP"].ToString();
                item.EMAIL_RESP = ds.Tables[0].Rows[0]["EMAIL_RESP"].ToString();
                item.RUA_PAC = ds.Tables[0].Rows[0]["RUA_PAC"].ToString();
                item.NUM_PAC = int.Parse(ds.Tables[0].Rows[0]["NUM_PAC"].ToString());
                item.CEP_PAC = int.Parse(ds.Tables[0].Rows[0]["CEP_PAC"].ToString());
                item.BAIRRO_PAC = ds.Tables[0].Rows[0]["BAIRRO_PAC"].ToString();
                item.MUN_PAC = ds.Tables[0].Rows[0]["MUN_PAC"].ToString();
                item.UF_PAC = ds.Tables[0].Rows[0]["UF_PAC"].ToString();
            }

            return item;
        }

        public void EditarPaciente(Paciente paciente)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("ALTERAR_PACIENTE", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_PAC", paciente.COD_PAC);
            cmd.Parameters.AddWithValue("@NOME_PAC", paciente.NOME_PAC);
            cmd.Parameters.AddWithValue("@DATANASC_PAC", paciente.DATANASC_PAC);
            cmd.Parameters.AddWithValue("@SEXO_PAC", paciente.SEXO_PAC);
            cmd.Parameters.AddWithValue("@IDADE_PAC", paciente.IDADE_PAC);
            cmd.Parameters.AddWithValue("@NOME_RESP", paciente.NOME_RESP);
            cmd.Parameters.AddWithValue("@TEL_RESP", paciente.TEL_RESP);
            cmd.Parameters.AddWithValue("@CEL_RESP", paciente.CEL_RESP);
            cmd.Parameters.AddWithValue("@RESP_DOIS", paciente.RESP_DOIS);
            cmd.Parameters.AddWithValue("@TEL_DOIS", paciente.TEL_DOIS);
            cmd.Parameters.AddWithValue("@EMAIL_RESP", paciente.EMAIL_RESP);
            cmd.Parameters.AddWithValue("@CPF_RESP", paciente.CPF_RESP);
            cmd.Parameters.AddWithValue("@RUA_PAC", paciente.RUA_PAC);
            cmd.Parameters.AddWithValue("@NUM_PAC", paciente.NUM_PAC);
            cmd.Parameters.AddWithValue("@CEP_PAC", paciente.CEP_PAC);
            cmd.Parameters.AddWithValue("@BAIRRO_PAC", paciente.BAIRRO_PAC);
            cmd.Parameters.AddWithValue("@MUN_PAC", paciente.MUN_PAC);
            cmd.Parameters.AddWithValue("@UF_PAC", paciente.UF_PAC);
            cmd.ExecuteNonQuery();

            msc.Close();
        }

        public void DeletarPaciente(int COD_PAC)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("call DELETAR_PACIENTE(" + COD_PAC + ");", msc);
            cmd.ExecuteNonQuery();

            msc.Close();
        }
    }
}