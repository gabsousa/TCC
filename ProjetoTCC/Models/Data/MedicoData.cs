﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models.Data
{
    public class MedicoData
    {
        public void CadastrarMedico(Medico medico)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("INSERIR_MEDICO", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_MED", medico.COD_MED);
            cmd.Parameters.AddWithValue("@NOME_MED", medico.NOME_MED);
            cmd.Parameters.AddWithValue("@TEL_MED", medico.TEL_MED);
            cmd.Parameters.AddWithValue("@CEL_MED", medico.CEL_MED);
            cmd.Parameters.AddWithValue("@EMAIL_MED", medico.EMAIL_MED);
            cmd.Parameters.AddWithValue("@CPF_MED", medico.CPF_MED);
            cmd.Parameters.AddWithValue("@CRM", medico.CRM);
            cmd.Parameters.AddWithValue("@VALIDADE_CRM", medico.VALIDADE_CRM);
            cmd.Parameters.AddWithValue("@SEXO_MED", medico.SEXO_MED);
            cmd.Parameters.AddWithValue("@COD_ESPEC", medico.COD_ESPEC);
            cmd.Parameters.AddWithValue("@COD_CARGO", medico.COD_CARGO);
            cmd.ExecuteNonQuery();

            msc.Close();
        }

        public List<Medico> ListaMedico()
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("LISTAR_MEDICO", msc);
            msda.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Medico> lista = new List<Medico>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Medico item = new Medico();

                item.COD_MED = int.Parse(dr["COD_MED"].ToString());
                item.NOME_MED = dr["NOME_MED"].ToString();
                item.TEL_MED = int.Parse(dr["TEL_MED"].ToString());
                item.CEL_MED = int.Parse(dr["CEL_MED"].ToString());
                item.EMAIL_MED = dr["EMAIL_MED"].ToString();
                item.CPF_MED = dr["CPF_MED"].ToString();
                item.CRM = dr["CRM"].ToString();
                item.VALIDADE_CRM = DateTime.Parse(dr["VALIDADE_CRM"].ToString());
                item.SEXO_MED = dr["SEXO_MED"].ToString();
                item.COD_ESPEC = int.Parse(dr["COD_ESPEC"].ToString());
                item.COD_CARGO = int.Parse(dr["COD_CARGO"].ToString());

                lista.Add(item);
            }

            return lista;
        }

        public Medico DetalhesMedico(int COD_MED)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_medico where COD_MED = " + COD_MED, msc);

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Medico> lista = new List<Medico>();

            Medico item = new Medico();

            if (ds.Tables[0].Rows.Count > 0)
            {
                item.COD_MED = int.Parse(ds.Tables[0].Rows[0]["COD_MED"].ToString());
                item.NOME_MED = ds.Tables[0].Rows[0]["NOME_MED"].ToString();
                item.TEL_MED = int.Parse(ds.Tables[0].Rows[0]["TEL_MED"].ToString());
                item.CEL_MED = int.Parse(ds.Tables[0].Rows[0]["CEL_MED"].ToString());
                item.EMAIL_MED = ds.Tables[0].Rows[0]["EMAIL_MED"].ToString();
                item.CPF_MED = ds.Tables[0].Rows[0]["CPF_MED"].ToString();
                item.CRM = ds.Tables[0].Rows[0]["CRM"].ToString();
                item.VALIDADE_CRM = DateTime.Parse(ds.Tables[0].Rows[0]["VALIDADE_CRM"].ToString());
                item.SEXO_MED = ds.Tables[0].Rows[0]["SEXO_MED"].ToString();
                item.COD_ESPEC = int.Parse(ds.Tables[0].Rows[0]["COD_ESPEC"].ToString());
                item.COD_CARGO = int.Parse(ds.Tables[0].Rows[0]["COD_CARGO"].ToString());
            }

            return item;

        }

        public void EditarMedico(Medico medico)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("ALTERAR_MEDICO", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@COD_MED", medico.COD_MED);
            cmd.Parameters.AddWithValue("@NOME_MED", medico.NOME_MED);
            cmd.Parameters.AddWithValue("@TEL_MED", medico.TEL_MED);
            cmd.Parameters.AddWithValue("@CEL_MED", medico.CEL_MED);
            cmd.Parameters.AddWithValue("@EMAIL_MED", medico.EMAIL_MED);
            cmd.Parameters.AddWithValue("@CPF_MED", medico.CPF_MED);
            cmd.Parameters.AddWithValue("@CRM", medico.CRM);
            cmd.Parameters.AddWithValue("@VALIDADE_CRM", medico.VALIDADE_CRM);
            cmd.Parameters.AddWithValue("@SEXO_MED", medico.SEXO_MED);
            cmd.Parameters.AddWithValue("@COD_ESPEC", medico.COD_ESPEC);
            cmd.Parameters.AddWithValue("@COD_CARGO", medico.COD_CARGO);
            cmd.ExecuteNonQuery();

            msc.Close();
        }

        public void DeletarMedico(int COD_MED)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("delete from tb_medico where COD_MED = " + COD_MED, msc);
            cmd.ExecuteNonQuery();

            msc.Close();
        }
    }
}