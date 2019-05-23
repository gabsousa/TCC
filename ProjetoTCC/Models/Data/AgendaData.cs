using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

            MySqlCommand cmd = new MySqlCommand("insert into tb_clientes values (@cod_agenda, @dia_consulta, @hora_consulta, @cod_med, @cod_pac, @confirmacao_agenda, @obs_agenda, @resp_agendamento, @data_retorno)", msc);

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

        public List<Agenda> ListaAgenda()
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("bd_clinicare.tb_clientes", msc);

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Agenda> lista = new List<Agenda>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Agenda item = new Agenda();

                item.cod_agenda = int.Parse(dr["cod_agenda"].ToString());
                item.dia_consulta = DateTime.Parse(dr["dia_consulta"].ToString());
                item.hora_consulta = DateTime.Parse(dr["hora_consulta"].ToString());
                item.cod_med = int.Parse(dr["cod_med"].ToString());
                item.cod_pac = int.Parse(dr["cod_pac"].ToString());
                item.confirmacao_agenda = dr["confirmacao_agenda"].ToString();
                item.obs_agenda = dr["obs_agenda"].ToString();
                item.resp_agendamento = dr["resp_agendamento"].ToString();
                item.data_retorno = DateTime.Parse(dr["data_retorno"].ToString());

                lista.Add(item);
            }

            return lista;
        }

        public Agenda DetalhesAgenda(int cod_agenda)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_clientes where cod_pac = " + cod_agenda, msc);

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Agenda> lista = new List<Agenda>();

            Agenda item = new Agenda();

            if (ds.Tables[0].Rows.Count > 0)
            {
                item.cod_agenda = int.Parse(ds.Tables[0].Rows[0]["cod_agenda"].ToString());
                item.dia_consulta = DateTime.Parse(ds.Tables[0].Rows[0]["dia_consulta"].ToString());
                item.hora_consulta = DateTime.Parse(ds.Tables[0].Rows[0]["hora_consulta"].ToString());
                item.cod_med = int.Parse(ds.Tables[0].Rows[0]["cod_med"].ToString());
                item.cod_pac = int.Parse(ds.Tables[0].Rows[0]["cod_pac"].ToString());
                item.confirmacao_agenda = ds.Tables[0].Rows[0]["confirmacao_agenda"].ToString();
                item.obs_agenda = ds.Tables[0].Rows[0]["obs_agenda"].ToString();
                item.resp_agendamento = ds.Tables[0].Rows[0]["resp_agendamento"].ToString();
                item.data_retorno = DateTime.Parse(ds.Tables[0].Rows[0]["data_retorno"].ToString());
            }

            return item;
        }

        public void EditarAgenda(Agenda agenda)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("INSERIR_CLIENTE");
            cmd.CommandType = CommandType.StoredProcedure;

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

        public void DeletarAgenda(int cod_agenda)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand command = new MySqlCommand("delete from tb_clientes where cod_agenda = " + cod_agenda, msc);

            command.ExecuteNonQuery();

            msc.Close();
        }
    }
}
