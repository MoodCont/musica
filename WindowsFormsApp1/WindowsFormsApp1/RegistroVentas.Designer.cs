namespace WindowsFormsApp1
{
    partial class RegistroVentas
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
            this.NumeroRegistro = new System.Windows.Forms.TextBox();
            this.FechaEmision = new System.Windows.Forms.TextBox();
            this.FechaVencimiento = new System.Windows.Forms.TextBox();
            this.Comprobante = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.TextBox();
            this.NumeroSerie = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumeroRegistro
            // 
            this.NumeroRegistro.Location = new System.Drawing.Point(-2, -2);
            this.NumeroRegistro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumeroRegistro.Multiline = true;
            this.NumeroRegistro.Name = "NumeroRegistro";
            this.NumeroRegistro.Size = new System.Drawing.Size(162, 47);
            this.NumeroRegistro.TabIndex = 0;
            this.NumeroRegistro.Text = "NUMERO CORRELATIVO DEL REGISTRO O CODIGO UNICO DE LA OPERACION";
            // 
            // FechaEmision
            // 
            this.FechaEmision.Location = new System.Drawing.Point(166, -2);
            this.FechaEmision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FechaEmision.Multiline = true;
            this.FechaEmision.Name = "FechaEmision";
            this.FechaEmision.Size = new System.Drawing.Size(162, 47);
            this.FechaEmision.TabIndex = 1;
            this.FechaEmision.Text = "FECHA DE EMISION DEL COMPROBANTE DE PAGO O DOCUMENTO";
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.Location = new System.Drawing.Point(334, -2);
            this.FechaVencimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FechaVencimiento.Multiline = true;
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.Size = new System.Drawing.Size(162, 47);
            this.FechaVencimiento.TabIndex = 2;
            this.FechaVencimiento.Text = "FECHA DE VENCIMIENTO Y/O PAGO\r\n";
            // 
            // Comprobante
            // 
            this.Comprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comprobante.Location = new System.Drawing.Point(502, -2);
            this.Comprobante.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Comprobante.Multiline = true;
            this.Comprobante.Name = "Comprobante";
            this.Comprobante.Size = new System.Drawing.Size(162, 24);
            this.Comprobante.TabIndex = 3;
            this.Comprobante.Text = "COMPROBANTE DE PAGO O DOCUMENTO";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(670, -2);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 47);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "NUMERO CORRELATIVO DEL REGISTRO O CODIGO UNICO DE LA OPERACION";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(502, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 24);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "TIPO\r\n(TABLA 10)";
            // 
            // Numero
            // 
            this.Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Location = new System.Drawing.Point(610, 21);
            this.Numero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Numero.Multiline = true;
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(54, 24);
            this.Numero.TabIndex = 6;
            this.Numero.Text = "NUMERO";
            // 
            // NumeroSerie
            // 
            this.NumeroSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroSerie.Location = new System.Drawing.Point(556, 21);
            this.NumeroSerie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumeroSerie.Multiline = true;
            this.NumeroSerie.Name = "NumeroSerie";
            this.NumeroSerie.Size = new System.Drawing.Size(54, 24);
            this.NumeroSerie.TabIndex = 7;
            this.NumeroSerie.Text = "N DE SERIE O N DE SERIE DE LA MAQUINA REGISTRADORA";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1174, -2);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(162, 47);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "NUMERO CORRELATIVO DEL REGISTRO O CODIGO UNICO DE LA OPERACION";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1006, -2);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(162, 47);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "NUMERO CORRELATIVO DEL REGISTRO O CODIGO UNICO DE LA OPERACION";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(838, -2);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(162, 47);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "NUMERO CORRELATIVO DEL REGISTRO O CODIGO UNICO DE LA OPERACION";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-2, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "NUMERO CORRELATIVO DEL REGISTRO O CODIGO UNICO DE LA OPERACION";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(166, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 47);
            this.label2.TabIndex = 12;
            this.label2.Text = "FECHA DE EMISION DEL COMPROBANTE DE PAGO O DOCUMENTO";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(334, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 47);
            this.label3.TabIndex = 13;
            this.label3.Text = "NUMERO CORRELATIVO DEL REGISTRO O CODIGO UNICO DE LA OPERACION";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(499, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 47);
            this.label4.TabIndex = 14;
            this.label4.Text = "NUMERO CORRELATIVO DEL REGISTRO O CODIGO UNICO DE LA OPERACION";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(667, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 47);
            this.label5.TabIndex = 15;
            this.label5.Text = "NUMERO CORRELATIVO DEL REGISTRO O CODIGO UNICO DE LA OPERACION";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(838, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 47);
            this.label6.TabIndex = 16;
            this.label6.Text = "NUMERO CORRELATIVO DEL REGISTRO O CODIGO UNICO DE LA OPERACION";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(1006, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 47);
            this.label7.TabIndex = 17;
            this.label7.Text = "NUMERO CORRELATIVO DEL REGISTRO O CODIGO UNICO DE LA OPERACION";
            // 
            // RegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 449);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.NumeroSerie);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Comprobante);
            this.Controls.Add(this.FechaVencimiento);
            this.Controls.Add(this.FechaEmision);
            this.Controls.Add(this.NumeroRegistro);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegistroVentas";
            this.Text = "RegistroVentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumeroRegistro;
        private System.Windows.Forms.TextBox FechaEmision;
        private System.Windows.Forms.TextBox FechaVencimiento;
        private System.Windows.Forms.TextBox Comprobante;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.TextBox NumeroSerie;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}