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
    }
}
