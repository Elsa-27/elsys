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
    public partial class rolese : Form
    {
        public rolese()
        {
            InitializeComponent();
        }
            SqlConnection conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=bdlogin;Integrated Security=True");
       

        private void rolese_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=bdlogin;Integrated Security=True";
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select *from usuariose";
            

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);

            //combobox
            combo.DataSource = tabla;
            combo.DisplayMember = "usuariose";
            combo.ValueMember = "usuario";

            //combo2
            SqlCommand comand = new SqlCommand();
            DataTable tabla2 = new DataTable();
            comand.Connection = conexion;
            comand.CommandType = CommandType.Text;
            comand.CommandText = "select *from roles";

            SqlDataAdapter adaptador2 = new SqlDataAdapter(comand);
            adaptador2.Fill(tabla2);

            combo2.DataSource = tabla2;
            combo2.DisplayMember = "roles";
            combo2.ValueMember = "nombrerol";
            //
        }


        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void combo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
          
            dg_roles.Rows.Add(combo.Text, combo2.Text);
            
          
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string query = "insert into permisos (usuario,rol) values (@usuario,@rol)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@usuario", combo.Text);
            comando.Parameters.AddWithValue("@rol", combo2.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Agregado a la BD");
            dg_roles.Text = "";
            conexion.Close();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select idpermiso,usuario,rol from permisos", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dt_mostrar.DataSource = tabla;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string query = "Delete from permisos where idpermiso=@idpermiso";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@idpermiso", txtid.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            txtid.Text = "";
            MessageBox.Show("Usuario Eliminado");  
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            
        }
      

    }
    
}
