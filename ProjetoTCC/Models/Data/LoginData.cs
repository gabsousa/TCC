using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTCC.Models.Data
{
    public class LoginData
    {

        public void LoginFunc(Login login)
        {
            MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("INSERIR_LOGIN", msc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@LOGIN", login.LOGIN);
            cmd.Parameters.AddWithValue("@SENHA", login.SENHA);
            cmd.Parameters.AddWithValue("@COD_PAC", login.COD_PAC);
            cmd.Parameters.AddWithValue("@COD_MED", login.COD_MED);
            cmd.Parameters.AddWithValue("@COD_RESP", login.COD_RESP);
            cmd.Parameters.AddWithValue("@COD_FUNC", login.COD_FUNC);
            cmd.ExecuteReader();

            msc.Close();

        }



        /*public string RetornaNomeFunc(string LOGIN)
        {
            Login login = new Login();
            Funcionario funcionario = new Funcionario();

            try
            {
                MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
                msc.Open();

                MySqlCommand cmd = new MySqlCommand("INSERIR_LOGIN", msc);
                cmd.CommandType = CommandType.StoredProcedure;

                {
                    cmd.Parameters.AddWithValue("@LOGIN", LOGIN);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        funcionario.COD_FUNC = Convert.ToInt32(dr["COD_FUNC"]);
                        funcionario.NOME_FUNC = dr["NOME_FUNC"].ToString();
                    }
                    dr.Close();
                    return funcionario.NOME_FUNC;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int RetornaIdFunc(string LOGIN)
        {
            Login login = new Login();
            Funcionario funcionario = new Funcionario();
            try
            {
                MySqlConnection msc = new MySqlConnection("server=localhost; uid=root; pwd=123456789; database=bd_clinicare");
                msc.Open();

                MySqlCommand cmd = new MySqlCommand("INSERIR_LOGIN", msc);
                cmd.CommandType = CommandType.StoredProcedure;

                {
                    cmd.Parameters.AddWithValue("@usuario", LOGIN);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        funcionario.COD_FUNC = Convert.ToInt32(dr["id_Cliente"]);
                    }
                    dr.Close();
                    return funcionario.COD_FUNC;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }*/

    }
}
