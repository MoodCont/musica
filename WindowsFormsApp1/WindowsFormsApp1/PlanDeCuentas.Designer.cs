namespace WindowsFormsApp1
{
    partial class PlanDeCuentas
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
            this.panelPlanDeCuentas = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelPlanDeCuentas = new System.Windows.Forms.Label();
            this.panelAgregarPlanDeCuentas = new System.Windows.Forms.Panel();
            this.labelEstructuraCodigoCuenta = new System.Windows.Forms.Label();
            this.buttonGrabarPlanCuentas = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelClase = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelDenominacionCuenta = new System.Windows.Forms.Label();
            this.textBoxCodigoCuenta = new System.Windows.Forms.TextBox();
            this.labelCodigoCuenta = new System.Windows.Forms.Label();
            this.labelAgregarPlanDeCuentas = new System.Windows.Forms.Label();
            this.panelPlanCuentasTitulo = new System.Windows.Forms.Panel();
            this.panelPlanDeCuentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAgregarPlanDeCuentas.SuspendLayout();
            this.panelPlanCuentasTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlanDeCuentas
            // 
            this.panelPlanDeCuentas.Controls.Add(this.panelPlanCuentasTitulo);
            this.panelPlanDeCuentas.Controls.Add(this.dataGridView1);
            this.panelPlanDeCuentas.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPlanDeCuentas.Location = new System.Drawing.Point(0, 0);
            this.panelPlanDeCuentas.Name = "panelPlanDeCuentas";
            this.panelPlanDeCuentas.Size = new System.Drawing.Size(523, 450);
            this.panelPlanDeCuentas.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // labelPlanDeCuentas
            // 
            this.labelPlanDeCuentas.AutoSize = true;
            this.labelPlanDeCuentas.Location = new System.Drawing.Point(211, 10);
            this.labelPlanDeCuentas.Name = "labelPlanDeCuentas";
            this.labelPlanDeCuentas.Size = new System.Drawing.Size(87, 13);
            this.labelPlanDeCuentas.TabIndex = 0;
            this.labelPlanDeCuentas.Text = "Plan De Cuentas";
            // 
            // panelAgregarPlanDeCuentas
            // 
            this.panelAgregarPlanDeCuentas.Controls.Add(this.labelEstructuraCodigoCuenta);
            this.panelAgregarPlanDeCuentas.Controls.Add(this.buttonGrabarPlanCuentas);
            this.panelAgregarPlanDeCuentas.Controls.Add(this.listBox1);
            this.panelAgregarPlanDeCuentas.Controls.Add(this.labelClase);
            this.panelAgregarPlanDeCuentas.Controls.Add(this.textBox1);
            this.panelAgregarPlanDeCuentas.Controls.Add(this.labelDenominacionCuenta);
            this.panelAgregarPlanDeCuentas.Controls.Add(this.textBoxCodigoCuenta);
            this.panelAgregarPlanDeCuentas.Controls.Add(this.labelCodigoCuenta);
            this.panelAgregarPlanDeCuentas.Controls.Add(this.labelAgregarPlanDeCuentas);
            this.panelAgregarPlanDeCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAgregarPlanDeCuentas.Location = new System.Drawing.Point(523, 0);
            this.panelAgregarPlanDeCuentas.Name = "panelAgregarPlanDeCuentas";
            this.panelAgregarPlanDeCuentas.Size = new System.Drawing.Size(277, 450);
            this.panelAgregarPlanDeCuentas.TabIndex = 1;
            // 
            // labelEstructuraCodigoCuenta
            // 
            this.labelEstructuraCodigoCuenta.AutoSize = true;
            this.labelEstructuraCodigoCuenta.Location = new System.Drawing.Point(126, 60);
            this.labelEstructuraCodigoCuenta.Name = "labelEstructuraCodigoCuenta";
            this.labelEstructuraCodigoCuenta.Size = new System.Drawing.Size(139, 13);
            this.labelEstructuraCodigoCuenta.TabIndex = 9;
            this.labelEstructuraCodigoCuenta.Text = "Estructura: XX-X-X-X-XX-XX";
            // 
            // buttonGrabarPlanCuentas
            // 
            this.buttonGrabarPlanCuentas.Location = new System.Drawing.Point(20, 380);
            this.buttonGrabarPlanCuentas.Name = "buttonGrabarPlanCuentas";
            this.buttonGrabarPlanCuentas.Size = new System.Drawing.Size(75, 23);
            this.buttonGrabarPlanCuentas.TabIndex = 8;
            this.buttonGrabarPlanCuentas.Text = "Grabar";
            this.buttonGrabarPlanCuentas.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Activo",
            "Pasivo"});
            this.listBox1.Location = new System.Drawing.Point(10, 230);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 7;
            // 
            // labelClase
            // 
            this.labelClase.AutoSize = true;
            this.labelClase.Location = new System.Drawing.Point(10, 200);
            this.labelClase.Name = "labelClase";
            this.labelClase.Size = new System.Drawing.Size(125, 13);
            this.labelClase.TabIndex = 6;
            this.labelClase.Text = "Clase a la que pertenece";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // labelDenominacionCuenta
            // 
            this.labelDenominacionCuenta.AutoSize = true;
            this.labelDenominacionCuenta.Location = new System.Drawing.Point(10, 130);
            this.labelDenominacionCuenta.Name = "labelDenominacionCuenta";
            this.labelDenominacionCuenta.Size = new System.Drawing.Size(127, 13);
            this.labelDenominacionCuenta.TabIndex = 4;
            this.labelDenominacionCuenta.Text = "Denominación de Cuenta";
            // 
            // textBoxCodigoCuenta
            // 
            this.textBoxCodigoCuenta.Location = new System.Drawing.Point(10, 90);
            this.textBoxCodigoCuenta.Name = "textBoxCodigoCuenta";
            this.textBoxCodigoCuenta.Size = new System.Drawing.Size(124, 20);
            this.textBoxCodigoCuenta.TabIndex = 3;
            // 
            // labelCodigoCuenta
            // 
            this.labelCodigoCuenta.AutoSize = true;
            this.labelCodigoCuenta.Location = new System.Drawing.Point(10, 60);
            this.labelCodigoCuenta.Name = "labelCodigoCuenta";
            this.labelCodigoCuenta.Size = new System.Drawing.Size(92, 13);
            this.labelCodigoCuenta.TabIndex = 2;
            this.labelCodigoCuenta.Text = "Codigo de Cuenta";
            // 
            // labelAgregarPlanDeCuentas
            // 
            this.labelAgregarPlanDeCuentas.AutoSize = true;
            this.labelAgregarPlanDeCuentas.Location = new System.Drawing.Point(10, 10);
            this.labelAgregarPlanDeCuentas.Name = "labelAgregarPlanDeCuentas";
            this.labelAgregarPlanDeCuentas.Size = new System.Drawing.Size(127, 13);
            this.labelAgregarPlanDeCuentas.TabIndex = 1;
            this.labelAgregarPlanDeCuentas.Text = "Agregar Plan De Cuentas";
            // 
            // panelPlanCuentasTitulo
            // 
            this.panelPlanCuentasTitulo.Controls.Add(this.labelPlanDeCuentas);
            this.panelPlanCuentasTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlanCuentasTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelPlanCuentasTitulo.Name = "panelPlanCuentasTitulo";
            this.panelPlanCuentasTitulo.Size = new System.Drawing.Size(523, 47);
            this.panelPlanCuentasTitulo.TabIndex = 2;
            // 
            // PlanDeCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAgregarPlanDeCuentas);
            this.Controls.Add(this.panelPlanDeCuentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanDeCuentas";
            this.Text = "PlanDeCuentas";
            this.panelPlanDeCuentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAgregarPlanDeCuentas.ResumeLayout(false);
            this.panelAgregarPlanDeCuentas.PerformLayout();
            this.panelPlanCuentasTitulo.ResumeLayout(false);
            this.panelPlanCuentasTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPlanDeCuentas;
        private System.Windows.Forms.Panel panelAgregarPlanDeCuentas;
        private System.Windows.Forms.Label labelPlanDeCuentas;
        private System.Windows.Forms.Label labelAgregarPlanDeCuentas;
        private System.Windows.Forms.Label labelCodigoCuenta;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelClase;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelDenominacionCuenta;
        private System.Windows.Forms.TextBox textBoxCodigoCuenta;
        private System.Windows.Forms.Label labelEstructuraCodigoCuenta;
        private System.Windows.Forms.Button buttonGrabarPlanCuentas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelPlanCuentasTitulo;
    }
}