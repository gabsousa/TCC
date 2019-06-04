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
        public void CadastrarAgenda(Agenda agenda)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("INSERIR_AGENDA", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_AGENDA", agenda.COD_AGENDA);
            cmd.Parameters.AddWithValue("@DIA_CONSULTA", agenda.DIA_CONSULTA);
            cmd.Parameters.AddWithValue("@HORA_CONSULTA", agenda.HORA_CONSULTA);
            cmd.Parameters.AddWithValue("@COD_MED", agenda.COD_MED);
            cmd.Parameters.AddWithValue("@COD_PAC", agenda.COD_PAC);
            cmd.Parameters.AddWithValue("@CONFIRMACAO_AGENDA", agenda.CONFIRMACAO_AGENDA);
            cmd.Parameters.AddWithValue("@OBS_AGENDA", agenda.OBS_AGENDA);
            cmd.Parameters.AddWithValue("@RESP_AGENDAMENTO", agenda.RESP_AGENDAMENTO);
            cmd.Parameters.AddWithValue("@DATA_RETORNO", agenda.DATA_RETORNO);

            cmd.ExecuteNonQuery();
            msc.Close();
        }

        public List<Agenda> ListaAgenda()
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("bd_clinicare.tb_clientes", msc);
            msda.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Agenda> lista = new List<Agenda>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Agenda item = new Agenda();

                item.COD_AGENDA = int.Parse(dr["COD_AGENDA"].ToString());
                item.DIA_CONSULTA = DateTime.Parse(dr["DIA_CONSULTA"].ToString());
                item.HORA_CONSULTA = DateTime.Parse(dr["HORA_CONSULTA"].ToString());
                item.COD_MED = int.Parse(dr["COD_MED"].ToString());
                item.COD_PAC = int.Parse(dr["COD_PAC"].ToString());
                item.CONFIRMACAO_AGENDA = dr["CONFIRMACAO_AGENDA"].ToString();
                item.OBS_AGENDA = dr["OBS_AGENDA"].ToString();
                item.RESP_AGENDAMENTO = dr["RESP_AGENDAMENTO"].ToString();
                item.DATA_RETORNO = DateTime.Parse(dr["DATA_RETORNO"].ToString());

                lista.Add(item);
            }

            return lista;
        }

        public Agenda DetalhesAgenda(int COD_AGENDA)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("CONSULTAR_AGENDA" + COD_AGENDA, msc);
            msda.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Agenda> lista = new List<Agenda>();

            Agenda item = new Agenda();

            if (ds.Tables[0].Rows.Count > 0)
            {
                item.COD_AGENDA = int.Parse(ds.Tables[0].Rows[0]["COD_AGENDA"].ToString());
                item.DIA_CONSULTA = DateTime.Parse(ds.Tables[0].Rows[0]["DIA_CONSULTA"].ToString());
                item.HORA_CONSULTA = DateTime.Parse(ds.Tables[0].Rows[0]["HORA_CONSULTA"].ToString());
                item.COD_MED = int.Parse(ds.Tables[0].Rows[0]["COD_MED"].ToString());
                item.COD_PAC = int.Parse(ds.Tables[0].Rows[0]["COD_PAC"].ToString());
                item.CONFIRMACAO_AGENDA = ds.Tables[0].Rows[0]["CONFIRMACAO_AGENDA"].ToString();
                item.OBS_AGENDA = ds.Tables[0].Rows[0]["OBS_AGENDA"].ToString();
                item.RESP_AGENDAMENTO = ds.Tables[0].Rows[0]["RESP_AGENDAMENTO"].ToString();
                item.DATA_RETORNO = DateTime.Parse(ds.Tables[0].Rows[0]["DATA_RETORNO"].ToString());
            }

            return item;
        }

        public void EditarAgenda(Agenda agenda)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("ALTERAR_CONSULTA", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_AGENDA", agenda.COD_AGENDA);
            cmd.Parameters.AddWithValue("@DIA_CONSULTA", agenda.DIA_CONSULTA);
            cmd.Parameters.AddWithValue("@HORA_CONSULTA", agenda.HORA_CONSULTA);
            cmd.Parameters.AddWithValue("@COD_MED", agenda.COD_MED);
            cmd.Parameters.AddWithValue("@COD_PAC", agenda.COD_PAC);
            cmd.Parameters.AddWithValue("@CONFIRMACAO_AGENDA", agenda.CONFIRMACAO_AGENDA);
            cmd.Parameters.AddWithValue("@OBS_AGENDA", agenda.OBS_AGENDA);
            cmd.Parameters.AddWithValue("@RESP_AGENDAMENTO", agenda.RESP_AGENDAMENTO);
            cmd.Parameters.AddWithValue("@DATA_RETORNO", agenda.DATA_RETORNO);

            cmd.ExecuteNonQuery();
            msc.Close();
        }

        public void DeletarAgenda(int COD_AGENDA)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("delete from tb_clientes where COD_AGENDA = " + COD_AGENDA, msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();

            msc.Close();
        }
    }
}
