﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models.Data
{
    public class FuncionarioData
    {
        public void CadastrarFuncionario(Funcionario funcionario)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("INSERIR_FUNCIONARIO", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_FUNC", funcionario.COD_FUNC);
            cmd.Parameters.AddWithValue("@NOME_FUNC", funcionario.NOME_FUNC);
            cmd.Parameters.AddWithValue("@TEL_FUNC", funcionario.TEL_FUNC);
            cmd.Parameters.AddWithValue("@CEL_FUNC", funcionario.CEL_FUNC);
            cmd.Parameters.AddWithValue("@EMAIL_FUNC", funcionario.EMAIL_FUNC);
            cmd.Parameters.AddWithValue("@COD_CARGO", funcionario.COD_CARGO);
            cmd.ExecuteNonQuery();

            msc.Close();
        }

        public List<Funcionario> ListaFuncionario()
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("LISTAR_FUNCIONARIO", msc);
            msda.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Funcionario> lista = new List<Funcionario>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Funcionario item = new Funcionario();

                item.COD_FUNC = int.Parse(dr["COD_FUNC"].ToString());
                item.NOME_FUNC = dr["NOME_FUNC"].ToString();
                item.TEL_FUNC = dr["TEL_FUNC"].ToString();
                item.CEL_FUNC = dr["CEL_FUNC"].ToString();
                item.EMAIL_FUNC = dr["EMAIL_FUNC"].ToString();
                item.COD_CARGO = int.Parse(dr["COD_CARGO"].ToString());

                lista.Add(item);
            }

            return lista;
        }

        public Funcionario DetalhesFuncionario(int COD_FUNC)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_funcionario where COD_FUNC = " + COD_FUNC, msc);

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Funcionario> lista = new List<Funcionario>();

            Funcionario item = new Funcionario();

            if (ds.Tables[0].Rows.Count > 0)
            {
                item.COD_FUNC = int.Parse(ds.Tables[0].Rows[0]["COD_FUNC"].ToString());
                item.NOME_FUNC = ds.Tables[0].Rows[0]["NOME_FUNC"].ToString();
                item.TEL_FUNC = ds.Tables[0].Rows[0]["TEL_FUNC"].ToString();
                item.CEL_FUNC = ds.Tables[0].Rows[0]["CEL_FUNC"].ToString();
                item.EMAIL_FUNC = ds.Tables[0].Rows[0]["EMAIL_FUNC"].ToString();
                item.COD_CARGO = int.Parse(ds.Tables[0].Rows[0]["COD_CARGO"].ToString());
            }

            return item;
        }


        public void EditarFuncionario(Funcionario funcionario)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("ALTERAR_FUNCIONARIO", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_FUNC", funcionario.COD_FUNC);
            cmd.Parameters.AddWithValue("@NOME_FUNC", funcionario.NOME_FUNC);
            cmd.Parameters.AddWithValue("@TEL_FUNC", funcionario.TEL_FUNC);
            cmd.Parameters.AddWithValue("@CEL_FUNC", funcionario.CEL_FUNC);
            cmd.Parameters.AddWithValue("@EMAIL_FUNC", funcionario.EMAIL_FUNC);
            cmd.Parameters.AddWithValue("@COD_CARGO", funcionario.COD_CARGO);
            cmd.ExecuteNonQuery();

            msc.Close();
        }

        public void DeletarFuncionario(int COD_FUNC)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("delete from tb_funcionario where COD_FUNC = " + COD_FUNC, msc);
            cmd.ExecuteNonQuery();

            msc.Close();
        }

    }
}
