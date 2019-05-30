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
            cmd.Parameters.AddWithValue("@COD_RESP", paciente.COD_RESP);
            cmd.Parameters.AddWithValue("@SEXO_PAC", paciente.SEXO_PAC);
            cmd.Parameters.AddWithValue("@IDADE_PAC", paciente.IDADE_PAC);

            cmd.ExecuteNonQuery();
            msc.Close();
        }

        public List<Paciente> ListaPaciente()
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_paciente", msc);
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

                lista.Add(item);
            }

            return lista;
        }

        public Paciente DetalhesPaciente(int COD_PAC)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("CONSULTAR_PACIENTE" + COD_PAC, msc);
            msda.SelectCommand.CommandType = CommandType.StoredProcedure;

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
                item.SEXO_PAC = ds.Tables[0].Rows[0]["SEXO_PAC"].ToString();
                item.IDADE_PAC = int.Parse(ds.Tables[0].Rows[0]["IDADE_PAC"].ToString());
            }

            return item;
        }

        public void EditarPaciente(Paciente paciente)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("ALTERAR_PACIENTE", msc);

            cmd.Parameters.AddWithValue("@COD_PAC", paciente.COD_PAC);
            cmd.Parameters.AddWithValue("@NOME_PAC", paciente.NOME_PAC);
            cmd.Parameters.AddWithValue("@DATANASC_PAC", paciente.DATANASC_PAC);
            cmd.Parameters.AddWithValue("@SEXO_PAC", paciente.SEXO_PAC);
            cmd.Parameters.AddWithValue("@IDADE_PAC", paciente.IDADE_PAC);

            cmd.ExecuteNonQuery();
            msc.Close();
        }

        public void DeletarPaciente(int COD_PAC)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("DELETAR_PACIENTE" + COD_PAC, msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();

            msc.Close();
        }
    }
}
