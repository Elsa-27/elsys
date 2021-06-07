using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace login
{
    public partial class usuariosE : Form
    {
        public usuariosE()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=bdlogin;Integrated Security=True");

        private void usuariosE_Load(object sender, EventArgs e)
        {
            
            dg_datos.AllowUserToAddRows = false;

            //llamado al comboBox tabla roles 
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=bdlogin;Integrated Security=True";
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select *from roles";


            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);

            //combobox
            comborol.DataSource = tabla;
            comborol.DisplayMember = "roles";
            comborol.ValueMember = "nombrerol";
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            SqlCommand agregar = new SqlCommand("insert into usuariose values (@nombre, @telefono, @usuario, @pass, @rol, @empresa)", conexion);
            conexion.Open();
            dg_datos.Rows.Add(txtnombre.Text, txttelefono.Text, txtusuario.Text, txtpass.Text, comborol.Text, txtempresa.Text);
            txtnombre.Text = "";
            txttelefono.Text = string.Empty;
            txtusuario.Text = "";
            txtpass.Text = "";
            comborol.Text = "";
            txtempresa.Text = "";

            try
            {

                foreach (DataGridViewRow row in dg_datos.Rows)
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@nombre", Convert.ToString(row.Cells["Columna1"].Value));
                    agregar.Parameters.AddWithValue("@telefono", Convert.ToString(row.Cells["Columna2"].Value));
                    agregar.Parameters.AddWithValue("@usuario", Convert.ToString(row.Cells["Columna3"].Value));
                    agregar.Parameters.AddWithValue("@pass", Convert.ToString(row.Cells["Columna4"].Value));
                    agregar.Parameters.AddWithValue("@rol", Convert.ToString(row.Cells["Columna5"].Value));
                    agregar.Parameters.AddWithValue("@empresa", Convert.ToString(row.Cells["Columna6"].Value));
                    agregar.ExecuteNonQuery();
                }
                MessageBox.Show("Datos agregados");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar");
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string query = "Delete from usuariose where iduser=@iduser";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@iduser", txtiduser.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            txtiduser.Text = "";
            MessageBox.Show("Usuario Eliminado");   
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string query = "update usuariose set nombre =@nombre, telefono =@telefono, usuario=@usuario, pass=@pass, rol=@rol, empresa=@empresa where iduser=@iduser";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", txtnombre.Text);
            comando.Parameters.AddWithValue("@telefono", txttelefono.Text);
            comando.Parameters.AddWithValue("@usuario", txtusuario.Text);
            comando.Parameters.AddWithValue("@pass", txtpass.Text);
            comando.Parameters.AddWithValue("@rol", comborol.Text);
            comando.Parameters.AddWithValue("@empresa", txtempresa.Text);
            comando.Parameters.AddWithValue("@iduser", txtac.Text);
        
            comando.ExecuteNonQuery();

            conexion.Close();
            MessageBox.Show("Actualizado correctamente");
            txtac.Text = "";
            txtnombre.Text = "";
            txttelefono.Text = string.Empty;
            txtusuario.Text = "";
            txtpass.Text = "";
            comborol.Text = "";
            txtempresa.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select iduser,nombre,telefono,usuario,rol,empresa from usuariose", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_2.DataSource = tabla;

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
        }

        private void btnserch_Click(object sender, EventArgs e)
        {
            string cadSql = "Select * from usuariose where iduser='" + txtbuscar.Text + "' ";
            SqlCommand comando = new SqlCommand(cadSql, conexion);
            conexion.Open();
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txtnombre.Text = leer["nombre"].ToString();
                txttelefono.Text = leer["telefono"].ToString();
                txtusuario.Text = leer["usuario"].ToString();
                txtpass.Text = leer["pass"].ToString();
                comborol.Text = leer["rol"].ToString();
                txtempresa.Text = leer["empresa"].ToString();

            }
            else
            {
                txtnombre.Text = "";
                txttelefono.Text = string.Empty;
                txtusuario.Text = "";
                txtpass.Text = "";
                comborol.Text = "";
                txtempresa.Text = "";
            }
            conexion.Close();

        }

        private void btnregistrar_u_Click(object sender, EventArgs e)
        {

            if (txtpass.Text == txtpass.Text)
            {
                if (UsuarioDAL.CrearUsuarios(txtnombre.Text, txttelefono.Text, txtusuario.Text, txtpass.Text, comborol.Text, txtempresa.Text) > 0)
                {
                    MessageBox.Show("Acceso Concedido");
                    menu frm2 = new menu();
                    frm2.Show();

                }
                else
                    MessageBox.Show("Error");
            }
        }
       
        
        }
    }
