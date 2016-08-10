using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CodSQL
    {
        Conexao con = new Conexao();


        public void cadGeral(string formatted_address, string lat, string lgt)
        {
            Conexao con = new Conexao();
            con.conectarBD();
            SqlCommand command = new SqlCommand("[dbo].[uspCADASTRAR_GERAL]", con.conectarBD());

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@FORMATED_ADDRESS", SqlDbType.VarChar)).Value = formatted_address;
            command.Parameters.Add(new SqlParameter("@LAT", SqlDbType.VarChar)).Value = lat;
            command.Parameters.Add(new SqlParameter("@LONG", SqlDbType.VarChar)).Value = lgt;
            command.ExecuteNonQuery();
            con.desconectarBD();

        }

        public DataSet consultarGeral()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_GEOCODE", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
            con.desconectarBD();

        }
        public DataSet consultarGeral(string cod)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_GEOCODE where COD ="+cod, con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
            con.desconectarBD();

        }





    }
        
    
}
