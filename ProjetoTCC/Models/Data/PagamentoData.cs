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

        public List<Pagamento> ListaPagamento()
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_pagamento", msc);
            //    MySqlDataAdapter msda = new MySqlDataAdapter("LISTAR_PAGAMENTO", msc);
            //    msda.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Pagamento> lista = new List<Pagamento>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Pagamento item = new Pagamento();

                item.COD_PGTO = int.Parse(dr["COD_PGTO"].ToString());
                item.COD_SERV = int.Parse(dr["COD_SERV"].ToString());
                item.FORMA_PGTO = dr["FORMA_PGTO"].ToString();
                item.TIPO_PGTO = dr["TIPO_PGTO"].ToString();
                item.TIPO_CARTAO = dr["TIPO_CARTAO"].ToString();
                item.QTD_PARCELA = int.Parse(dr["QTD_PARCELA"].ToString());
                item.VALOR = decimal.Parse(dr["VALOR"].ToString());
                item.STATUS_PGTO = dr["STATUS_PGTO"].ToString();
                item.OBS_PGTO = dr["OBS_PGTO"].ToString();
                

                lista.Add(item);
            }

            return lista;
        }

        public Pagamento DetalhesPagamento(int COD_PGTO)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_pagamento where COD_PGTO = " + COD_PGTO, msc);
            //    MySqlDataAdapter msda = new MySqlDataAdapter("CONSULTAR_PAGAMENTO" + COD_GTO, msc);
            //    msda.SelectCommand.CommandType = CommandType.StoredProcedure;


            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Pagamento> lista = new List<Pagamento>();

            Pagamento item = new Pagamento();

            if (ds.Tables[0].Rows.Count > 0)
            {
                item.COD_PGTO = int.Parse(ds.Tables[0].Rows[0]["COD_PGTO"].ToString());
                item.COD_SERV = int.Parse(ds.Tables[0].Rows[0]["COD_SERV"].ToString());
                item.FORMA_PGTO = ds.Tables[0].Rows[0]["FORMA_PGTO"].ToString();
                item.TIPO_PGTO = ds.Tables[0].Rows[0]["TIPO_PGTO"].ToString();
                item.TIPO_CARTAO = ds.Tables[0].Rows[0]["TIPO_CARTAO"].ToString();
                item.QTD_PARCELA = int.Parse(ds.Tables[0].Rows[0]["QTD_PARCELA"].ToString());
                item.VALOR = decimal.Parse(ds.Tables[0].Rows[0]["VALOR"].ToString());
                item.STATUS_PGTO = ds.Tables[0].Rows[0]["STATUS_PGTO"].ToString();
                item.OBS_PGTO = ds.Tables[0].Rows[0]["OBS_PGTO"].ToString(); 
            }

            return item;
        }

        public void EditarPagamento(Pagamento pagamento)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("ALTERAR_PAGAMENTO", msc);
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

        public void DeletarPagamento(int COD_PGTO)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("DELETAR_PAGAMENTO", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();

            msc.Close();
        }
    }
}
