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
