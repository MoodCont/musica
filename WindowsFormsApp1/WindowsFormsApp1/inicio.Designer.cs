namespace WindowsFormsApp1
{
    partial class inicio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonBuscarRUC = new System.Windows.Forms.Button();
            this.textBoxBuscarRUC = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelMes = new System.Windows.Forms.Label();
            this.labelAnio = new System.Windows.Forms.Label();
            this.textBoxMes = new System.Windows.Forms.TextBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxLibrosElectronicos = new System.Windows.Forms.TextBox();
            this.textBoxRegimenTri = new System.Windows.Forms.TextBox();
            this.labelLibrosElectronicos = new System.Windows.Forms.Label();
            this.labelRegimenTributario = new System.Windows.Forms.Label();
            this.textBoxAnio = new System.Windows.Forms.TextBox();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxRUC = new System.Windows.Forms.TextBox();
            this.labelRUC = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIngresarRUC = new System.Windows.Forms.Button();
            this.textBoxIngresarRUC = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 461);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(500, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 461);
            this.panel3.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.dataGridViewLista);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 114);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(494, 347);
            this.panel8.TabIndex = 2;
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLista.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.Size = new System.Drawing.Size(492, 345);
            this.dataGridViewLista.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.textBoxIngresarRUC);
            this.panel7.Controls.Add(this.buttonIngresarRUC);
            this.panel7.Controls.Add(this.buttonBuscarRUC);
            this.panel7.Controls.Add(this.textBoxBuscarRUC);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 63);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(494, 51);
            this.panel7.TabIndex = 1;
            // 
            // buttonBuscarRUC
            // 
            this.buttonBuscarRUC.Location = new System.Drawing.Point(19, 15);
            this.buttonBuscarRUC.Name = "buttonBuscarRUC";
            this.buttonBuscarRUC.Size = new System.Drawing.Size(85, 23);
            this.buttonBuscarRUC.TabIndex = 14;
            this.buttonBuscarRUC.Text = "Buscar RUC";
            this.buttonBuscarRUC.UseVisualStyleBackColor = true;
            this.buttonBuscarRUC.Click += new System.EventHandler(this.mostrar);
            // 
            // textBoxBuscarRUC
            // 
            this.textBoxBuscarRUC.Location = new System.Drawing.Point(119, 15);
            this.textBoxBuscarRUC.Name = "textBoxBuscarRUC";
            this.textBoxBuscarRUC.Size = new System.Drawing.Size(227, 20);
            this.textBoxBuscarRUC.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(494, 63);
            this.panel6.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Listado de Empresas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 461);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.labelMes);
            this.panel5.Controls.Add(this.labelAnio);
            this.panel5.Controls.Add(this.textBoxMes);
            this.panel5.Controls.Add(this.buttonRegistrar);
            this.panel5.Controls.Add(this.textBoxLibrosElectronicos);
            this.panel5.Controls.Add(this.textBoxRegimenTri);
            this.panel5.Controls.Add(this.labelLibrosElectronicos);
            this.panel5.Controls.Add(this.labelRegimenTributario);
            this.panel5.Controls.Add(this.textBoxAnio);
            this.panel5.Controls.Add(this.labelPeriodo);
            this.panel5.Controls.Add(this.textBoxDireccion);
            this.panel5.Controls.Add(this.labelDireccion);
            this.panel5.Controls.Add(this.textBoxRUC);
            this.panel5.Controls.Add(this.labelRUC);
            this.panel5.Controls.Add(this.textBoxNombre);
            this.panel5.Controls.Add(this.labelNombre);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 398);
            this.panel5.TabIndex = 2;
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Location = new System.Drawing.Point(292, 151);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(27, 13);
            this.labelMes.TabIndex = 17;
            this.labelMes.Text = "Mes";
            // 
            // labelAnio
            // 
            this.labelAnio.AutoSize = true;
            this.labelAnio.Location = new System.Drawing.Point(117, 153);
            this.labelAnio.Name = "labelAnio";
            this.labelAnio.Size = new System.Drawing.Size(26, 13);
            this.labelAnio.TabIndex = 16;
            this.labelAnio.Text = "Año";
            // 
            // textBoxMes
            // 
            this.textBoxMes.Location = new System.Drawing.Point(335, 150);
            this.textBoxMes.Name = "textBoxMes";
            this.textBoxMes.Size = new System.Drawing.Size(112, 20);
            this.textBoxMes.TabIndex = 15;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(215, 266);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrar.TabIndex = 13;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxLibrosElectronicos
            // 
            this.textBoxLibrosElectronicos.Location = new System.Drawing.Point(120, 240);
            this.textBoxLibrosElectronicos.Name = "textBoxLibrosElectronicos";
            this.textBoxLibrosElectronicos.Size = new System.Drawing.Size(358, 20);
            this.textBoxLibrosElectronicos.TabIndex = 12;
            // 
            // textBoxRegimenTri
            // 
            this.textBoxRegimenTri.Location = new System.Drawing.Point(120, 195);
            this.textBoxRegimenTri.Name = "textBoxRegimenTri";
            this.textBoxRegimenTri.Size = new System.Drawing.Size(358, 20);
            this.textBoxRegimenTri.TabIndex = 11;
            // 
            // labelLibrosElectronicos
            // 
            this.labelLibrosElectronicos.AutoSize = true;
            this.labelLibrosElectronicos.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibrosElectronicos.Location = new System.Drawing.Point(10, 240);
            this.labelLibrosElectronicos.Name = "labelLibrosElectronicos";
            this.labelLibrosElectronicos.Size = new System.Drawing.Size(104, 32);
            this.labelLibrosElectronicos.TabIndex = 10;
            this.labelLibrosElectronicos.Text = "Libros\r\nelectrónicos";
            // 
            // labelRegimenTributario
            // 
            this.labelRegimenTributario.AutoSize = true;
            this.labelRegimenTributario.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegimenTributario.Location = new System.Drawing.Point(10, 195);
            this.labelRegimenTributario.Name = "labelRegimenTributario";
            this.labelRegimenTributario.Size = new System.Drawing.Size(88, 32);
            this.labelRegimenTributario.TabIndex = 9;
            this.labelRegimenTributario.Text = "Régimen\r\ntributario";
            // 
            // textBoxAnio
            // 
            this.textBoxAnio.Location = new System.Drawing.Point(149, 150);
            this.textBoxAnio.Name = "textBoxAnio";
            this.textBoxAnio.Size = new System.Drawing.Size(112, 20);
            this.textBoxAnio.TabIndex = 8;
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriodo.Location = new System.Drawing.Point(10, 150);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(64, 16);
            this.labelPeriodo.TabIndex = 7;
            this.labelPeriodo.Text = "Periodo";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(120, 105);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(358, 20);
            this.textBoxDireccion.TabIndex = 6;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(10, 105);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(80, 16);
            this.labelDireccion.TabIndex = 5;
            this.labelDireccion.Text = "Dirección";
            // 
            // textBoxRUC
            // 
            this.textBoxRUC.Location = new System.Drawing.Point(120, 60);
            this.textBoxRUC.Name = "textBoxRUC";
            this.textBoxRUC.Size = new System.Drawing.Size(141, 20);
            this.textBoxRUC.TabIndex = 4;
            // 
            // labelRUC
            // 
            this.labelRUC.AutoSize = true;
            this.labelRUC.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRUC.Location = new System.Drawing.Point(10, 60);
            this.labelRUC.Name = "labelRUC";
            this.labelRUC.Size = new System.Drawing.Size(32, 16);
            this.labelRUC.TabIndex = 3;
            this.labelRUC.Text = "RUC";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(120, 15);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(358, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(10, 15);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 63);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Empresa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonIngresarRUC
            // 
            this.buttonIngresarRUC.Location = new System.Drawing.Point(363, 15);
            this.buttonIngresarRUC.Name = "buttonIngresarRUC";
            this.buttonIngresarRUC.Size = new System.Drawing.Size(79, 23);
            this.buttonIngresarRUC.TabIndex = 15;
            this.buttonIngresarRUC.Text = "Ingresar RUC";
            this.buttonIngresarRUC.UseVisualStyleBackColor = true;
            this.buttonIngresarRUC.Click += new System.EventHandler(this.buttonIngresarRUC_Click);
            // 
            // textBoxIngresarRUC
            // 
            this.textBoxIngresarRUC.Location = new System.Drawing.Point(457, 15);
            this.textBoxIngresarRUC.Name = "textBoxIngresarRUC";
            this.textBoxIngresarRUC.Size = new System.Drawing.Size(100, 20);
            this.textBoxIngresarRUC.TabIndex = 16;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(994, 461);
            this.Controls.Add(this.panel1);
            this.Name = "inicio";
            this.Text = "inicio";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxRUC;
        private System.Windows.Forms.Label labelRUC;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxLibrosElectronicos;
        private System.Windows.Forms.TextBox textBoxRegimenTri;
        private System.Windows.Forms.Label labelLibrosElectronicos;
        private System.Windows.Forms.Label labelRegimenTributario;
        private System.Windows.Forms.TextBox textBoxAnio;
        private System.Windows.Forms.Label labelPeriodo;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.TextBox textBoxBuscarRUC;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBoxMes;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.Label labelAnio;
        private System.Windows.Forms.Button buttonBuscarRUC;
        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.Button buttonIngresarRUC;
        private System.Windows.Forms.TextBox textBoxIngresarRUC;
    }
}