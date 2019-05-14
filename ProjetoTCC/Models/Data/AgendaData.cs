using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models.Data
{
    public class AgendaData
    {
        public void CadastarAgenda(Agenda agenda)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("insert into tb_clientes values (@cod_agenda, @dia_consulta, @hora_consulta, @cod_medico, @cod_pac, @confirmacao_agenda, @obs_agenda, @resp_agendamento, @data_retorno)", msc);

            cmd.Parameters.AddWithValue("@cod_agenda", agenda.cod_agenda);
            cmd.Parameters.AddWithValue("@dia_consulta", agenda.dia_consulta);
            cmd.Parameters.AddWithValue("@hora_consulta", agenda.hora_consulta);
            cmd.Parameters.AddWithValue("@cod_med", agenda.cod_med);
            cmd.Parameters.AddWithValue("@cod_pac", agenda.cod_pac);
            cmd.Parameters.AddWithValue("@confirmacao_agenda", agenda.confirmacao_agenda);
            cmd.Parameters.AddWithValue("@obs_agenda", agenda.obs_agenda);
            cmd.Parameters.AddWithValue("@resp_agendamento", agenda.resp_agendamento);
            cmd.Parameters.AddWithValue("@data_retorno", agenda.data_retorno);

            cmd.ExecuteNonQuery();
            msc.Close();
        }

        public List<Paciente> ListaPacient()
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_clientes", msc);

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

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_clientes where cod_pac = " + cod_pac, msc);

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

            MySqlCommand cmd = new MySqlCommand("insert into tb_clientes values (@cod_agenda, @dia_consulta, @hora_consulta, @cod_medico(FK), @cod_pac(FK), @confirmacao_agenda, @obs_agenda, @resp_agendamento, @data_retorno)", msc);

            cmd.Parameters.AddWithValue("@cod_agenda", Agenda.cod_agenda);
            cmd.Parameters.AddWithValue("@dia_consulta", Agenda.dia_consulta);
            cmd.Parameters.AddWithValue("@hora_consulta", Agenda.hora_consultahora_consulta);
            cmd.Parameters.AddWithValue("@cod_medico", Agenda.cod_medico);
            cmd.Parameters.AddWithValue("@cod_pac", Agenda.cod_pac);
            cmd.Parameters.AddWithValue("@confirmacao_agenda", Agenda.confirmacao_agenda);
            cmd.Parameters.AddWithValue("@obs_agenda", Agenda.obs_agenda);
            cmd.Parameters.AddWithValue("@resp_agendamento", Agenda.resp_agendamento);
            cmd.Parameters.AddWithValue("@data_retorno", Agenda.data_retorno);

            cmd.ExecuteNonQuery();
            msc.Close();
        }
    }
}
