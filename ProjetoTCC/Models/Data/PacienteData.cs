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

            MySqlCommand cmd = new MySqlCommand("insert into tb_paciente values (@cod_pac, @nome_pac, @datanasc_pac, @sexo_pac, @idade_pac)", msc);

            cmd.Parameters.AddWithValue("@cod_pac", paciente.cod_pac);
            cmd.Parameters.AddWithValue("@nome_pac", paciente.nome_pac);
            cmd.Parameters.AddWithValue("@datanasc_pac", paciente.datanasc_pac);
            cmd.Parameters.AddWithValue("@sexo_pac", paciente.sexo_pac);
            cmd.Parameters.AddWithValue("@idade_pac", paciente.idade_pac);

            cmd.ExecuteNonQuery();
            msc.Close();
        }

        public List<Paciente> ListaPaciente()
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_paciente", msc);

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Paciente> lista = new List<Paciente>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Paciente item = new Paciente();

                item.cod_pac = int.Parse(dr["cod_pac"].ToString());
                item.nome_pac = dr["nome_pac"].ToString();
                item.datanasc_pac = DateTime.Parse(dr["datanasc_pac"].ToString());
                item.sexo_pac = dr["sexo_pac"].ToString();
                item.idade_pac = int.Parse(dr["idade_pac"].ToString());

                lista.Add(item);
            }

            return lista;
        }

        public Paciente DetalhesPaciente(int cod_pac)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_paciente where cod_pac = " + cod_pac, msc);

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Paciente> lista = new List<Paciente>();

            Paciente item = new Paciente();

            if (ds.Tables[0].Rows.Count > 0)
            {
                item.cod_pac = int.Parse(ds.Tables[0].Rows[0]["cod_pac"].ToString());
                item.nome_pac = ds.Tables[0].Rows[0]["nome_pac"].ToString();
                item.datanasc_pac = DateTime.Parse(ds.Tables[0].Rows[0]["datanasc_pac"].ToString());
                item.sexo_pac = ds.Tables[0].Rows[0]["sexo_pac"].ToString();
                item.idade_pac = int.Parse(ds.Tables[0].Rows[0]["idade_pac"].ToString());
            }

            return item;
        }

        public void EditarPaciente(Paciente paciente)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("update tb_paciente set cod_pac = @cod_pac, nome_pac = @nome_pac, datanasc_pac = @datanasc_pac, sexo_pac = @sexo_pac, idade_pac = @idade_pac where cod_pac = @cod_pac ", msc);

            cmd.Parameters.AddWithValue("@cod_pac", paciente.cod_pac);
            cmd.Parameters.AddWithValue("@nome_pac", paciente.nome_pac);
            cmd.Parameters.AddWithValue("@datanasc_pac", paciente.datanasc_pac);
            cmd.Parameters.AddWithValue("@sexo_pac", paciente.sexo_pac);
            cmd.Parameters.AddWithValue("@idade_pac", paciente.idade_pac);

            cmd.ExecuteNonQuery();
            msc.Close();
        }

        public void DeletarPaciente(int cod_pac)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand command = new MySqlCommand("delete from tb_paciente where cod_pac = " + cod_pac, msc);

            command.ExecuteNonQuery();

            msc.Close();
        }
    }
}
