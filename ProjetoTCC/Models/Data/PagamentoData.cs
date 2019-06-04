using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models.Data
{
    public class PagamentoData
    {
        public void CadastrarPagamento(Pagamento pagamento)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("INSERIR_PAGAMENTO", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_PGTO", pagamento.COD_PGTO);
            cmd.Parameters.AddWithValue("@COD_SERV", pagamento.COD_SERV);
            cmd.Parameters.AddWithValue("@FORMA_PGTO", pagamento.FORMA_PGTO);
            cmd.Parameters.AddWithValue("@TIPO_PGTO", pagamento.TIPO_PGTO);
            cmd.Parameters.AddWithValue("@TIPO_CARTAO", pagamento.TIPO_CARTAO);
            cmd.Parameters.AddWithValue("@QTD_PARCELA", pagamento.QTD_PARCELA);
            cmd.Parameters.AddWithValue("@VALOR", pagamento.VALOR);
            cmd.Parameters.AddWithValue("@STATUS_PGTO", pagamento.STATUS_PGTO);
            cmd.Parameters.AddWithValue("@OBS_PGTO", pagamento.OBS_PGTO);
           
            cmd.ExecuteNonQuery();

            msc.Close();
        }
    }
}
