using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace login
{
    class UsuarioDAL
    {
        public static int CrearCuentas(string pUsuario, string pContraseña)
        {
            int resultado = 0;
            SqlConnection conexion = BDComun.ObtenerCOnexion();
            SqlCommand Comando = new SqlCommand(string.Format("Insert Into usuarios (usuario, pass) values ('{0}', PwdEncrypt('{1}') )", pUsuario, pContraseña), conexion);
            resultado = Comando.ExecuteNonQuery();
            conexion.Close();
            return resultado;

        }
        public static int autenticacion(String pUsuarios, String pContra)
        {
            int resultado = -1;
            SqlConnection conexion = BDComun.ObtenerCOnexion();
            SqlCommand comando = new SqlCommand(string.Format(
                "Select * From usuarios where usuario = '{0}' and PwdCompare('{1}',pass) = 1 ", pUsuarios, pContra), conexion);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                resultado = 50;
            }
            conexion.Close();
            return resultado;
        }
        public static int CrearUsuarios(string nombre, string telefono, string usuario, string pass, string rol, string empresa)
        {
            int resultado = 0;
            SqlConnection conexion = BDComun.ObtenerCOnexion();
            SqlCommand Comando = new SqlCommand(string.Format("Insert Into usuariose (nombre, telefono, usuario, pass, rol, empresa) values ('{0}','{0}','{0}', PwdEncrypt('{1}'),'{0}','{0}' )", nombre, telefono, usuario, pass, rol, empresa), conexion);
            resultado = Comando.ExecuteNonQuery();
            conexion.Close();
            return resultado;

        }

    }
}
