namespace login
{
    partial class usuariosE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_datos = new System.Windows.Forms.DataGridView();
            this.Columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dg_2 = new System.Windows.Forms.DataGridView();
            this.txtiduser = new System.Windows.Forms.TextBox();
            this.txtac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comborol = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnserch = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnregistrar_u = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_2)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_datos
            // 
            this.dg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna1,
            this.Columna2,
            this.Columna3,
            this.Columna4,
            this.Columna5,
            this.Columna6});
            this.dg_datos.Location = new System.Drawing.Point(25, 207);
            this.dg_datos.Name = "dg_datos";
            this.dg_datos.Size = new System.Drawing.Size(645, 150);
            this.dg_datos.TabIndex = 0;
            // 
            // Columna1
            // 
            this.Columna1.HeaderText = "Nombre";
            this.Columna1.Name = "Columna1";
            // 
            // Columna2
            // 
            this.Columna2.HeaderText = "Teléfono";
            this.Columna2.Name = "Columna2";
            // 
            // Columna3
            // 
            this.Columna3.HeaderText = "Usuario";
            this.Columna3.Name = "Columna3";
            // 
            // Columna4
            // 
            this.Columna4.HeaderText = "Password";
            this.Columna4.Name = "Columna4";
            // 
            // Columna5
            // 
            this.Columna5.HeaderText = "Rol";
            this.Columna5.Name = "Columna5";
            // 
            // Columna6
            // 
            this.Columna6.HeaderText = "Empresa";
            this.Columna6.Name = "Columna6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CRUD DE USUARIOS ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Usuario: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rol: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Empresa:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(75, 59);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(160, 20);
            this.txtnombre.TabIndex = 8;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(75, 91);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(160, 20);
            this.txttelefono.TabIndex = 9;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(76, 137);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(159, 20);
            this.txtusuario.TabIndex = 10;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(316, 59);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(130, 20);
            this.txtpass.TabIndex = 11;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // txtempresa
            // 
            this.txtempresa.Location = new System.Drawing.Point(316, 136);
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(130, 20);
            this.txtempresa.TabIndex = 13;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(234, 174);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 14;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(965, 174);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 15;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(465, 61);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 16;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(595, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dg_2
            // 
            this.dg_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_2.Location = new System.Drawing.Point(676, 12);
            this.dg_2.Name = "dg_2";
            this.dg_2.Size = new System.Drawing.Size(487, 150);
            this.dg_2.TabIndex = 20;
            // 
            // txtiduser
            // 
            this.txtiduser.Location = new System.Drawing.Point(838, 177);
            this.txtiduser.Name = "txtiduser";
            this.txtiduser.Size = new System.Drawing.Size(100, 20);
            this.txtiduser.TabIndex = 21;
            // 
            // txtac
            // 
            this.txtac.Location = new System.Drawing.Point(546, 64);
            this.txtac.Name = "txtac";
            this.txtac.Size = new System.Drawing.Size(100, 20);
            this.txtac.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(729, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ingrese ID a eliminar";
            // 
            // comborol
            // 
            this.comborol.FormattingEnabled = true;
            this.comborol.Location = new System.Drawing.Point(316, 95);
            this.comborol.Name = "comborol";
            this.comborol.Size = new System.Drawing.Size(128, 21);
            this.comborol.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(543, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ingrese ID a actualizar";
            // 
            // btnserch
            // 
            this.btnserch.Location = new System.Drawing.Point(465, 115);
            this.btnserch.Name = "btnserch";
            this.btnserch.Size = new System.Drawing.Size(75, 23);
            this.btnserch.TabIndex = 26;
            this.btnserch.Text = "Buscar";
            this.btnserch.UseVisualStyleBackColor = true;
            this.btnserch.Click += new System.EventHandler(this.btnserch_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(546, 115);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(543, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Ingrese ID a Buscar";
            // 
            // btnregistrar_u
            // 
            this.btnregistrar_u.Location = new System.Drawing.Point(339, 174);
            this.btnregistrar_u.Name = "btnregistrar_u";
            this.btnregistrar_u.Size = new System.Drawing.Size(75, 23);
            this.btnregistrar_u.TabIndex = 29;
            this.btnregistrar_u.Text = "Registrar";
            this.btnregistrar_u.UseVisualStyleBackColor = true;
            this.btnregistrar_u.Click += new System.EventHandler(this.btnregistrar_u_Click);
            // 
            // usuariosE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 374);
            this.Controls.Add(this.btnregistrar_u);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnserch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comborol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtac);
            this.Controls.Add(this.txtiduser);
            this.Controls.Add(this.dg_2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtempresa);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_datos);
            this.Name = "usuariosE";
            this.Text = "usuariosE";
            this.Load += new System.EventHandler(this.usuariosE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_datos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtempresa;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dg_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna6;
        private System.Windows.Forms.TextBox txtiduser;
        private System.Windows.Forms.TextBox txtac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comborol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnserch;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnregistrar_u;
    }
}