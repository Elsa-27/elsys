using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace login
{
    class BDComun
    {
        public static SqlConnection ObtenerCOnexion()
        {
         
            SqlConnection conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=bdlogin;Integrated Security=True;");
            
            conexion.Open();

            return conexion;
        }
    }
}
