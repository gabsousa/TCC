using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models.Data
{
    public class EstoqueData
    {
        public void CadastrarEstoque(Estoque estoque)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("INSERIR_ESTOQUE", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_PROD", estoque.COD_PROD);
            cmd.Parameters.AddWithValue("@NOME_PROD", estoque.NOME_PROD);
            cmd.Parameters.AddWithValue("@QNT_PROD", estoque.QNT_PROD);
            cmd.Parameters.AddWithValue("@QNT_PROD", estoque.DATA_VALIDADE);
            cmd.Parameters.AddWithValue("@NOME_FORNEC", estoque.NOME_FORNEC);
            cmd.Parameters.AddWithValue("@DATA_ENTRADA", estoque.DATA_ENTRADA);
            cmd.Parameters.AddWithValue("@DATA_RETIRADA", estoque.DATA_RETIRADA);
            cmd.Parameters.AddWithValue("@HORA_RETIRADA", estoque.HORA_RETIRADA);
            cmd.Parameters.AddWithValue("@RESP_RETIRADA", estoque.RESP_RETIRADA);

            cmd.ExecuteNonQuery();
            msc.Close();
        }

        public void EditarEstoque(Estoque estoque)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("ALTERAR_ESTOQUE", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_PROD", estoque.COD_PROD);
            cmd.Parameters.AddWithValue("@NOME_PROD", estoque.NOME_PROD);
            cmd.Parameters.AddWithValue("@QNT_PROD", estoque.QNT_PROD);
            cmd.Parameters.AddWithValue("@QNT_PROD", estoque.DATA_VALIDADE);
            cmd.Parameters.AddWithValue("@NOME_FORNEC", estoque.NOME_FORNEC);
            cmd.Parameters.AddWithValue("@DATA_ENTRADA", estoque.DATA_ENTRADA);
            cmd.Parameters.AddWithValue("@DATA_RETIRADA", estoque.DATA_RETIRADA);
            cmd.Parameters.AddWithValue("@HORA_RETIRADA", estoque.HORA_RETIRADA);
            cmd.Parameters.AddWithValue("@RESP_RETIRADA", estoque.RESP_RETIRADA);

            cmd.ExecuteNonQuery();
            msc.Close();
        }

        public void DeletarEstoque(int COD_PROD)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("DELETAR_ESTOQUE");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
            msc.Close();
        }


        public List<Estoque> ListaEstoque()
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            //MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_estoque", msc);
            MySqlDataAdapter msda = new MySqlDataAdapter("bd_clinicare.CONSULTAR_ESTOQUE", msc);
            msda.SelectCommand.CommandType = CommandType.StoredProcedure;


            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Estoque> lista = new List<Estoque>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Estoque item = new Estoque();

                item.COD_PROD = int.Parse(dr["COD_PROD"].ToString());
                item.NOME_PROD = dr["NOME_PROD"].ToString();
                item.QNT_PROD = int.Parse(dr["QNT_PROD"].ToString());
                item.DATA_VALIDADE = DateTime.Parse(dr["DATA_VALIDADE"].ToString());
                item.NOME_FORNEC = dr["NOME_FORNEC"].ToString();
                item.DATA_ENTRADA = DateTime.Parse(dr["DATA_ENTRADA"].ToString());
                item.DATA_RETIRADA = DateTime.Parse(dr["DATA_RETIRADA"].ToString());
                item.HORA_RETIRADA = DateTime.Parse(dr["HORA_RETIRADA"].ToString());
                item.RESP_RETIRADA = dr["RESP_RETIRADA"].ToString();

                lista.Add(item);
            }

            return lista;
        }

        public Estoque DetalhesEstoque(int COD_PROD)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            //MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_estoque where COD_PROD = " + COD_ESTOQUE, msc);
            MySqlDataAdapter msda = new MySqlDataAdapter("bd_clinicare.CONSULTAR_ESTOQUE" + COD_PROD, msc);
            msda.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Estoque> lista = new List<Estoque>();

            Estoque item = new Estoque();

            if (ds.Tables[0].Rows.Count > 0)
            {
                item.COD_PROD = int.Parse(ds.Tables[0].Rows[0]["COD_PROD"].ToString());
                item.NOME_PROD = ds.Tables[0].Rows[0]["NOME_PROD"].ToString();
                item.QNT_PROD = int.Parse(ds.Tables[0].Rows[0]["QNT_PROD"].ToString());
                item.DATA_VALIDADE = DateTime.Parse(ds.Tables[0].Rows[0]["DATA_VALIDADE"].ToString());
                item.NOME_FORNEC = ds.Tables[0].Rows[0]["NOME_FORNEC"].ToString();
                item.DATA_ENTRADA = DateTime.Parse(ds.Tables[0].Rows[0]["DATA_ENTRADA"].ToString());
                item.DATA_RETIRADA = DateTime.Parse(ds.Tables[0].Rows[0]["DATA_RETIRADA"].ToString());
                item.HORA_RETIRADA = DateTime.Parse(ds.Tables[0].Rows[0]["HORA_RETIRADA"].ToString());
                item.RESP_RETIRADA = ds.Tables[0].Rows[0]["RESP_RETIRADA"].ToString();

            }

            return item;
        }
    }
}
