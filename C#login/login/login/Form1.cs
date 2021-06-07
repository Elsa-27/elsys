using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Security.Cryptography;



namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);

        //autenticacion
       

        public void logins()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT usuario, pass FROM usuarios where usuario='" + txtUser.Text + "' AND pass='" + txtPass.Text + "'", conexion))
                   
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                       
                        if (dr.Read())
                        {
                            txtUser.Text = "";
                            txtPass.Text = "";
                            MessageBox.Show("Login exitoso");
                            menu frm2 = new menu();
                            frm2.Show();
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           
            autenticacion();
            {
                if (UsuarioDAL.autenticacion(txtUser.Text, txtPass.Text) > 0)
                {
                    this.Hide();
                    menu ue = new menu();
                    ue.ShowDialog();
                }
                else
                    MessageBox.Show("Error al ingresar");


            }
        }

        private void autenticacion()
        {
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == txtPass.Text)
            {
                if (UsuarioDAL.CrearCuentas(txtUser.Text, txtPass.Text) > 0)
                {
                    MessageBox.Show("Acceso Concedido");
                    menu frm2 = new menu();
                    frm2.Show();
                    txtUser.Text = "";
                    txtPass.Text = "";

                }
                else
                    MessageBox.Show("Error");
            }

        }

        private void btnru_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuariosE ue = new usuariosE();
            ue.Show();
        }

}
}
