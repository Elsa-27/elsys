using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login
{
    public partial class CRUDrol : Form
    {
        public CRUDrol()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=bdlogin;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into roles(nombrerol) values(@nombre)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", txtagregar.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Rol agregado");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select idrol,nombrerol from roles", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_rol.DataSource = tabla;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string query = "Delete from roles where idrol=@idrol";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@idrol", txtidrol.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            txtidrol.Text = "";
            MessageBox.Show("Rol Eliminado");   
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string query = "update roles set nombrerol =@nombrerol where idrol=@idrol";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombrerol", txtagregar.Text);
            comando.Parameters.AddWithValue("@idrol", txtacid.Text);

            comando.ExecuteNonQuery();

            conexion.Close();
            MessageBox.Show("Actualizado correctamente");
            txtacid.Text = "";
            txtagregar.Text = "";
        }
    }
}
