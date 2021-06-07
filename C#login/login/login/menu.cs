using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuariosE frm2 = new usuariosE();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rolese frm3 = new rolese();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUDrol frm4 = new CRUDrol();
            frm4.Show();
        }
    }
}
