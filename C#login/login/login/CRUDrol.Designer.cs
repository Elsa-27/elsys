namespace login
{
    partial class CRUDrol
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtagregar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dg_rol = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtidrol = new System.Windows.Forms.TextBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.txtacid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rol)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD - ROLES-";
            // 
            // txtagregar
            // 
            this.txtagregar.Location = new System.Drawing.Point(84, 45);
            this.txtagregar.Name = "txtagregar";
            this.txtagregar.Size = new System.Drawing.Size(239, 20);
            this.txtagregar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dg_rol
            // 
            this.dg_rol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_rol.Location = new System.Drawing.Point(58, 99);
            this.dg_rol.Name = "dg_rol";
            this.dg_rol.Size = new System.Drawing.Size(320, 150);
            this.dg_rol.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(492, 116);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtidrol
            // 
            this.txtidrol.Location = new System.Drawing.Point(421, 118);
            this.txtidrol.Name = "txtidrol";
            this.txtidrol.Size = new System.Drawing.Size(55, 20);
            this.txtidrol.TabIndex = 6;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(492, 155);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 7;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txtacid
            // 
            this.txtacid.Location = new System.Drawing.Point(421, 157);
            this.txtacid.Name = "txtacid";
            this.txtacid.Size = new System.Drawing.Size(55, 20);
            this.txtacid.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingrese ID";
            // 
            // CRUDrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtacid);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.txtidrol);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dg_rol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtagregar);
            this.Controls.Add(this.label1);
            this.Name = "CRUDrol";
            this.Text = "CRUDrol";
            ((System.ComponentModel.ISupportInitialize)(this.dg_rol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtagregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dg_rol;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtidrol;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.TextBox txtacid;
        private System.Windows.Forms.Label label2;
    }
}