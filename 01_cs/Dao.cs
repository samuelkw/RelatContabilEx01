using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace _01_cs
{
    public class Dao
    {
        public static SqlConnection con;
        private AppConfigReader appCfg;

        public Dao()
        {
            try
            {
                appCfg = new AppConfigReader();
            }
            catch (Exception e)
            {
                throw e;
            }
            if (appCfg.strConn!= null) {
                con = new SqlConnection(appCfg.strConn);
            }
        }

        public List<Lancamento> listarLancamentos(DateTime dtini, DateTime dtfim) {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
            con.Open();
            List<Lancamento> lista = new List<Lancamento> { };
            SqlCommand sql = new SqlCommand("Listar1" , con);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@dtini",dtini);
            sql.Parameters.AddWithValue("@dtfim", dtfim);
            try
            {
                SqlDataReader ler = sql.ExecuteReader();
                while (ler.Read())
                {
                    Lancamento l = new Lancamento();
                    l.Conta=ler.GetString(0);
                    l.Descr = ler.GetString(1);
                    l.Saldo = Convert.ToDouble(ler.GetDecimal(2).ToString());
                    lista.Add(l);
                }
            }
            catch (SqlException e)
            {
                con.Close();
                throw e;
            }
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
            return lista;
        }

    }
}
