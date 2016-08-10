using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Conexao
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLARQUIVO;Initial Catalog=DB_GEOCODEAPI;Integrated Security=SSPI;Persist Security Info=False");

        public SqlConnection conectarBD()
        {
            try
            {
                con.Open();
            }
            catch
            {
            }
            return con;
        }
        public SqlConnection desconectarBD()
        {
            con.Close();
            return con;
        }
    }
}
