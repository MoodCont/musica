namespace WindowsFormsApp1
{
    partial class IngresarAsiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarAsiento));
            this.flowLayoutPanelTitulo = new System.Windows.Forms.FlowLayoutPanel();
            this.labeltituloIngresarAsiento = new System.Windows.Forms.Label();
            this.panelContenidoIngresarAsiento = new System.Windows.Forms.Panel();
            this.panelEstructuraAsiento = new System.Windows.Forms.Panel();
            this.labelDenominacion = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelRUCProvedor = new System.Windows.Forms.Label();
            this.textBoxTipoProvedor = new System.Windows.Forms.TextBox();
            this.labelTipoProvedor = new System.Windows.Forms.Label();
            this.labelTituloProvedor = new System.Windows.Forms.Label();
            this.textBoxFechaVenciomiento = new System.Windows.Forms.TextBox();
            this.textBoxFechaEmision = new System.Windows.Forms.TextBox();
            this.labelFechaVencimientoDocumento = new System.Windows.Forms.Label();
            this.labelFechaEmisionDocumento = new System.Windows.Forms.Label();
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            this.textBoxSerieDocumento = new System.Windows.Forms.TextBox();
            this.labelNumeroDocumento = new System.Windows.Forms.Label();
            this.labelSerieDocumento = new System.Windows.Forms.Label();
            this.textBoxTipoDocumento = new System.Windows.Forms.TextBox();
            this.labelTipoDocumento = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelTituloDocumento = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxNroAsiento = new System.Windows.Forms.TextBox();
            this.LabelNroAsiento = new System.Windows.Forms.Label();
            this.textBoxPeriodoMes = new System.Windows.Forms.TextBox();
            this.textBoxPeriodoAnio = new System.Windows.Forms.TextBox();
            this.labelPeriodoMes = new System.Windows.Forms.Label();
            this.labelPeriodoAnio = new System.Windows.Forms.Label();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.listBoxCodigoLibro = new System.Windows.Forms.ListBox();
            this.labelTipoLibro = new System.Windows.Forms.Label();
            this.textBoxSucursal = new System.Windows.Forms.TextBox();
            this.labelSucursal = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonGuardarIngresarAsiento = new System.Windows.Forms.Button();
            this.flowLayoutPanelTitulo.SuspendLayout();
            this.panelContenidoIngresarAsiento.SuspendLayout();
            this.panelEstructuraAsiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelTitulo
            // 
            this.flowLayoutPanelTitulo.Controls.Add(this.labeltituloIngresarAsiento);
            this.flowLayoutPanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTitulo.Name = "flowLayoutPanelTitulo";
            this.flowLayoutPanelTitulo.Size = new System.Drawing.Size(1121, 48);
            this.flowLayoutPanelTitulo.TabIndex = 0;
            // 
            // labeltituloIngresarAsiento
            // 
            this.labeltituloIngresarAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltituloIngresarAsiento.Location = new System.Drawing.Point(3, 0);
            this.labeltituloIngresarAsiento.Name = "labeltituloIngresarAsiento";
            this.labeltituloIngresarAsiento.Size = new System.Drawing.Size(236, 45);
            this.labeltituloIngresarAsiento.TabIndex = 0;
            this.labeltituloIngresarAsiento.Text = "Ingresar Asiento";
            this.labeltituloIngresarAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContenidoIngresarAsiento
            // 
            this.panelContenidoIngresarAsiento.BackColor = System.Drawing.SystemColors.Control;
            this.panelContenidoIngresarAsiento.Controls.Add(this.panelEstructuraAsiento);
            this.panelContenidoIngresarAsiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenidoIngresarAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContenidoIngresarAsiento.Location = new System.Drawing.Point(0, 48);
            this.panelContenidoIngresarAsiento.Name = "panelContenidoIngresarAsiento";
            this.panelContenidoIngresarAsiento.Size = new System.Drawing.Size(1121, 620);
            this.panelContenidoIngresarAsiento.TabIndex = 2;
            // 
            // panelEstructuraAsiento
            // 
            this.panelEstructuraAsiento.Controls.Add(this.buttonGuardarIngresarAsiento);
            this.panelEstructuraAsiento.Controls.Add(this.labelDenominacion);
            this.panelEstructuraAsiento.Controls.Add(this.textBox3);
            this.panelEstructuraAsiento.Controls.Add(this.textBox2);
            this.panelEstructuraAsiento.Controls.Add(this.labelRUCProvedor);
            this.panelEstructuraAsiento.Controls.Add(this.textBoxTipoProvedor);
            this.panelEstructuraAsiento.Controls.Add(this.labelTipoProvedor);
            this.panelEstructuraAsiento.Controls.Add(this.labelTituloProvedor);
            this.panelEstructuraAsiento.Controls.Add(this.textBoxFechaVenciomiento);
            this.panelEstructuraAsiento.Controls.Add(this.textBoxFechaEmision);
            this.panelEstructuraAsiento.Controls.Add(this.labelFechaVencimientoDocumento);
            this.panelEstructuraAsiento.Controls.Add(this.labelFechaEmisionDocumento);
            this.panelEstructuraAsiento.Controls.Add(this.textBoxNumeroDocumento);
            this.panelEstructuraAsiento.Controls.Add(this.textBoxSerieDocumento);
            this.panelEstructuraAsiento.Controls.Add(this.labelNumeroDocumento);
            this.panelEstructuraAsiento.Controls.Add(this.labelSerieDocumento);
            this.panelEstructuraAsiento.Controls.Add(this.textBoxTipoDocumento);
            this.panelEstructuraAsiento.Controls.Add(this.labelTipoDocumento);
            this.panelEstructuraAsiento.Controls.Add(this.listBox1);
            this.panelEstructuraAsiento.Controls.Add(this.labelTituloDocumento);
            this.panelEstructuraAsiento.Controls.Add(this.textBox1);
            this.panelEstructuraAsiento.Controls.Add(this.textBoxNroAsiento);
            this.panelEstructuraAsiento.Controls.Add(this.LabelNroAsiento);
            this.panelEstructuraAsiento.Controls.Add(this.textBoxPeriodoMes);
            this.panelEstructuraAsiento.Controls.Add(this.textBoxPeriodoAnio);
            this.panelEstructuraAsiento.Controls.Add(this.labelPeriodoMes);
            this.panelEstructuraAsiento.Controls.Add(this.labelPeriodoAnio);
            this.panelEstructuraAsiento.Controls.Add(this.labelPeriodo);
            this.panelEstructuraAsiento.Controls.Add(this.listBoxCodigoLibro);
            this.panelEstructuraAsiento.Controls.Add(this.labelTipoLibro);
            this.panelEstructuraAsiento.Controls.Add(this.textBoxSucursal);
            this.panelEstructuraAsiento.Controls.Add(this.labelSucursal);
            this.panelEstructuraAsiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEstructuraAsiento.Location = new System.Drawing.Point(0, 0);
            this.panelEstructuraAsiento.Name = "panelEstructuraAsiento";
            this.panelEstructuraAsiento.Size = new System.Drawing.Size(1121, 620);
            this.panelEstructuraAsiento.TabIndex = 0;
            // 
            // labelDenominacion
            // 
            this.labelDenominacion.AutoSize = true;
            this.labelDenominacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenominacion.Location = new System.Drawing.Point(277, 220);
            this.labelDenominacion.Name = "labelDenominacion";
            this.labelDenominacion.Size = new System.Drawing.Size(179, 16);
            this.labelDenominacion.TabIndex = 30;
            this.labelDenominacion.Text = "Denominación/Razón Social";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(280, 239);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(106, 239);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 22);
            this.textBox2.TabIndex = 28;
            // 
            // labelRUCProvedor
            // 
            this.labelRUCProvedor.AutoSize = true;
            this.labelRUCProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRUCProvedor.Location = new System.Drawing.Point(106, 220);
            this.labelRUCProvedor.Name = "labelRUCProvedor";
            this.labelRUCProvedor.Size = new System.Drawing.Size(37, 16);
            this.labelRUCProvedor.TabIndex = 27;
            this.labelRUCProvedor.Text = "RUC";
            // 
            // textBoxTipoProvedor
            // 
            this.textBoxTipoProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTipoProvedor.Location = new System.Drawing.Point(12, 239);
            this.textBoxTipoProvedor.Name = "textBoxTipoProvedor";
            this.textBoxTipoProvedor.Size = new System.Drawing.Size(33, 22);
            this.textBoxTipoProvedor.TabIndex = 26;
            // 
            // labelTipoProvedor
            // 
            this.labelTipoProvedor.AutoSize = true;
            this.labelTipoProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoProvedor.Location = new System.Drawing.Point(12, 220);
            this.labelTipoProvedor.Name = "labelTipoProvedor";
            this.labelTipoProvedor.Size = new System.Drawing.Size(36, 16);
            this.labelTipoProvedor.TabIndex = 25;
            this.labelTipoProvedor.Text = "Tipo";
            // 
            // labelTituloProvedor
            // 
            this.labelTituloProvedor.AutoSize = true;
            this.labelTituloProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloProvedor.Location = new System.Drawing.Point(11, 191);
            this.labelTituloProvedor.Name = "labelTituloProvedor";
            this.labelTituloProvedor.Size = new System.Drawing.Size(125, 20);
            this.labelTituloProvedor.TabIndex = 24;
            this.labelTituloProvedor.Text = "Provedor/Cliente";
            // 
            // textBoxFechaVenciomiento
            // 
            this.textBoxFechaVenciomiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFechaVenciomiento.Location = new System.Drawing.Point(679, 147);
            this.textBoxFechaVenciomiento.Name = "textBoxFechaVenciomiento";
            this.textBoxFechaVenciomiento.Size = new System.Drawing.Size(139, 22);
            this.textBoxFechaVenciomiento.TabIndex = 23;
            // 
            // textBoxFechaEmision
            // 
            this.textBoxFechaEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFechaEmision.Location = new System.Drawing.Point(527, 147);
            this.textBoxFechaEmision.Name = "textBoxFechaEmision";
            this.textBoxFechaEmision.Size = new System.Drawing.Size(113, 22);
            this.textBoxFechaEmision.TabIndex = 22;
            // 
            // labelFechaVencimientoDocumento
            // 
            this.labelFechaVencimientoDocumento.AutoSize = true;
            this.labelFechaVencimientoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaVencimientoDocumento.Location = new System.Drawing.Point(676, 128);
            this.labelFechaVencimientoDocumento.Name = "labelFechaVencimientoDocumento";
            this.labelFechaVencimientoDocumento.Size = new System.Drawing.Size(142, 16);
            this.labelFechaVencimientoDocumento.TabIndex = 21;
            this.labelFechaVencimientoDocumento.Text = "Fecha de Vencimiento";
            // 
            // labelFechaEmisionDocumento
            // 
            this.labelFechaEmisionDocumento.AutoSize = true;
            this.labelFechaEmisionDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaEmisionDocumento.Location = new System.Drawing.Point(524, 128);
            this.labelFechaEmisionDocumento.Name = "labelFechaEmisionDocumento";
            this.labelFechaEmisionDocumento.Size = new System.Drawing.Size(116, 16);
            this.labelFechaEmisionDocumento.TabIndex = 20;
            this.labelFechaEmisionDocumento.Text = "Fecha de Emision";
            // 
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(434, 147);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(67, 22);
            this.textBoxNumeroDocumento.TabIndex = 19;
            // 
            // textBoxSerieDocumento
            // 
            this.textBoxSerieDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSerieDocumento.Location = new System.Drawing.Point(361, 147);
            this.textBoxSerieDocumento.Name = "textBoxSerieDocumento";
            this.textBoxSerieDocumento.Size = new System.Drawing.Size(50, 22);
            this.textBoxSerieDocumento.TabIndex = 18;
            // 
            // labelNumeroDocumento
            // 
            this.labelNumeroDocumento.AutoSize = true;
            this.labelNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDocumento.Location = new System.Drawing.Point(431, 128);
            this.labelNumeroDocumento.Name = "labelNumeroDocumento";
            this.labelNumeroDocumento.Size = new System.Drawing.Size(56, 16);
            this.labelNumeroDocumento.TabIndex = 17;
            this.labelNumeroDocumento.Text = "Número";
            // 
            // labelSerieDocumento
            // 
            this.labelSerieDocumento.AutoSize = true;
            this.labelSerieDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerieDocumento.Location = new System.Drawing.Point(358, 128);
            this.labelSerieDocumento.Name = "labelSerieDocumento";
            this.labelSerieDocumento.Size = new System.Drawing.Size(40, 16);
            this.labelSerieDocumento.TabIndex = 16;
            this.labelSerieDocumento.Text = "Serie";
            // 
            // textBoxTipoDocumento
            // 
            this.textBoxTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTipoDocumento.Location = new System.Drawing.Point(15, 147);
            this.textBoxTipoDocumento.Name = "textBoxTipoDocumento";
            this.textBoxTipoDocumento.Size = new System.Drawing.Size(33, 22);
            this.textBoxTipoDocumento.TabIndex = 15;
            // 
            // labelTipoDocumento
            // 
            this.labelTipoDocumento.AutoSize = true;
            this.labelTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDocumento.Location = new System.Drawing.Point(12, 128);
            this.labelTipoDocumento.Name = "labelTipoDocumento";
            this.labelTipoDocumento.Size = new System.Drawing.Size(36, 16);
            this.labelTipoDocumento.TabIndex = 14;
            this.labelTipoDocumento.Text = "Tipo";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "00 Otros (especificar)",
            "01 Factura",
            "02 Recibo por Honorarios",
            "03 Boleta de Venta",
            "04 Liquidación de compra",
            "05 Boleto de compañía de aviación comercial por el servicio de transporte aéreo d" +
                "e pasajeros",
            "06 Carta de porte aéreo por el servicio de transporte de carga aérea",
            "07 Nota de crédito",
            "08 Nota de débito",
            "09 Guía de remisión - Remitente",
            "10 Recibo por Arrendamiento",
            resources.GetString("listBox1.Items"),
            "12 Ticket o cinta emitido por máquina registradora",
            "13 Documento emitido por bancos, instituciones financieras, crediticias y de segu" +
                "ros que se encuentren bajo el control de la Superintendencia de Banca y Seguros",
            "14 Recibo por servicios públicos de suministro de energía eléctrica, agua, teléfo" +
                "no, telex y telegráficos y otros servicios complementarios que se incluyan en el" +
                " recibo de servicio público ",
            "15 Boleto emitido por las empresas de transporte público urbano de pasajeros",
            "16 Boleto de viaje emitido por las empresas de transporte público interprovincial" +
                " de pasajeros dentro del país",
            "17 Documento emitido por la Iglesia Católica por el arrendamiento de bienes inmue" +
                "bles",
            resources.GetString("listBox1.Items1"),
            "19 Boleto o entrada por atracciones y espectáculos públicos",
            "20 Comprobante de Retención",
            "21 Conocimiento de embarque por el servicio de transporte de carga marítima",
            "22 Comprobante por Operaciones No Habituales",
            "23 Pólizas de Adjudicación emitidas con ocasión del remate o adjudicación de bien" +
                "es por venta forzada, por los martilleros o las entidades que rematen o subasten" +
                " bienes por cuenta de terceros",
            "24 Certificado de pago de regalías emitidas por PERUPETRO S.A",
            "25 Documento de Atribución (Ley del Impuesto General a las Ventas e Impuesto Sele" +
                "ctivo al Consumo, Art. 19º, último párrafo, R.S. N° 022-98-SUNAT).",
            resources.GetString("listBox1.Items2"),
            "27 Seguro Complementario de Trabajo de Riesgo",
            "28 Tarifa Unificada de Uso de Aeropuerto",
            "29 Documentos emitidos por la COFOPRI en calidad de oferta de venta de terrenos, " +
                "los correspondientes a las subastas públicas y a la retribución de los servicios" +
                " que presta",
            "30 Documentos emitidos por las empresas que desempeñan el rol adquirente en los s" +
                "istemas de pago mediante tarjetas de crédito y débito",
            "31 Guía de Remisión - Transportista",
            resources.GetString("listBox1.Items3"),
            "34 Documento del Operador",
            "35 Documento del Partícipe",
            "36 Recibo de Distribución de Gas Natural",
            "37 Documentos que emitan los concesionarios del servicio de revisiones técnicas v" +
                "ehiculares, por la prestación de dicho servicio",
            "50 Declaración Única de Aduanas - Importación definitiva                 ",
            "52 Despacho Simplificado - Importación Simplificada                        ",
            "53 Declaración de Mensajería o Courier                                         ",
            "54 Liquidación de Cobranza                                                     ",
            "87 Nota de Crédito Especial",
            "88 Nota de Débito Especial",
            "96 Exceso de crédito fiscal por retiro de bienes",
            "99 Otros -Consolidado de Boletas de Venta"});
            this.listBox1.Location = new System.Drawing.Point(54, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 20);
            this.listBox1.TabIndex = 13;
            // 
            // labelTituloDocumento
            // 
            this.labelTituloDocumento.AutoSize = true;
            this.labelTituloDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloDocumento.Location = new System.Drawing.Point(11, 93);
            this.labelTituloDocumento.Name = "labelTituloDocumento";
            this.labelTituloDocumento.Size = new System.Drawing.Size(92, 20);
            this.labelTituloDocumento.TabIndex = 12;
            this.labelTituloDocumento.Text = "Documento";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(106, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBoxNroAsiento
            // 
            this.textBoxNroAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNroAsiento.Location = new System.Drawing.Point(527, 28);
            this.textBoxNroAsiento.Name = "textBoxNroAsiento";
            this.textBoxNroAsiento.Size = new System.Drawing.Size(86, 22);
            this.textBoxNroAsiento.TabIndex = 10;
            // 
            // LabelNroAsiento
            // 
            this.LabelNroAsiento.AutoSize = true;
            this.LabelNroAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNroAsiento.Location = new System.Drawing.Point(524, 4);
            this.LabelNroAsiento.Name = "LabelNroAsiento";
            this.LabelNroAsiento.Size = new System.Drawing.Size(78, 16);
            this.LabelNroAsiento.TabIndex = 9;
            this.LabelNroAsiento.Text = "Nro Asiento";
            // 
            // textBoxPeriodoMes
            // 
            this.textBoxPeriodoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPeriodoMes.Location = new System.Drawing.Point(434, 56);
            this.textBoxPeriodoMes.Name = "textBoxPeriodoMes";
            this.textBoxPeriodoMes.Size = new System.Drawing.Size(50, 22);
            this.textBoxPeriodoMes.TabIndex = 8;
            // 
            // textBoxPeriodoAnio
            // 
            this.textBoxPeriodoAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPeriodoAnio.Location = new System.Drawing.Point(361, 56);
            this.textBoxPeriodoAnio.Name = "textBoxPeriodoAnio";
            this.textBoxPeriodoAnio.Size = new System.Drawing.Size(50, 22);
            this.textBoxPeriodoAnio.TabIndex = 7;
            // 
            // labelPeriodoMes
            // 
            this.labelPeriodoMes.AutoSize = true;
            this.labelPeriodoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriodoMes.Location = new System.Drawing.Point(431, 25);
            this.labelPeriodoMes.Name = "labelPeriodoMes";
            this.labelPeriodoMes.Size = new System.Drawing.Size(34, 16);
            this.labelPeriodoMes.TabIndex = 6;
            this.labelPeriodoMes.Text = "Mes";
            // 
            // labelPeriodoAnio
            // 
            this.labelPeriodoAnio.AutoSize = true;
            this.labelPeriodoAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriodoAnio.Location = new System.Drawing.Point(358, 25);
            this.labelPeriodoAnio.Name = "labelPeriodoAnio";
            this.labelPeriodoAnio.Size = new System.Drawing.Size(32, 16);
            this.labelPeriodoAnio.TabIndex = 5;
            this.labelPeriodoAnio.Text = "Año";
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriodo.Location = new System.Drawing.Point(358, 4);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(56, 16);
            this.labelPeriodo.TabIndex = 4;
            this.labelPeriodo.Text = "Periodo";
            // 
            // listBoxCodigoLibro
            // 
            this.listBoxCodigoLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCodigoLibro.FormattingEnabled = true;
            this.listBoxCodigoLibro.ItemHeight = 16;
            this.listBoxCodigoLibro.Items.AddRange(new object[] {
            "01 LIBRO CAJA Y BANCOS",
            "03 LIBRO DE INVENTARIOS Y BALANCES",
            "05 LIBRO DIARIO",
            "06 LIBRO MAYOR",
            "08 REGISTRO DE COMPRAS",
            "14 REGISTRO DE VENTAS E INGRESOS",
            "31 LIBRO DE PLANILLAS"});
            this.listBoxCodigoLibro.Location = new System.Drawing.Point(162, 28);
            this.listBoxCodigoLibro.Name = "listBoxCodigoLibro";
            this.listBoxCodigoLibro.Size = new System.Drawing.Size(151, 20);
            this.listBoxCodigoLibro.TabIndex = 3;
            // 
            // labelTipoLibro
            // 
            this.labelTipoLibro.AutoSize = true;
            this.labelTipoLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoLibro.Location = new System.Drawing.Point(103, 3);
            this.labelTipoLibro.Name = "labelTipoLibro";
            this.labelTipoLibro.Size = new System.Drawing.Size(85, 16);
            this.labelTipoLibro.TabIndex = 2;
            this.labelTipoLibro.Text = "Codigo Libro";
            // 
            // textBoxSucursal
            // 
            this.textBoxSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSucursal.Location = new System.Drawing.Point(15, 28);
            this.textBoxSucursal.Name = "textBoxSucursal";
            this.textBoxSucursal.Size = new System.Drawing.Size(55, 22);
            this.textBoxSucursal.TabIndex = 1;
            // 
            // labelSucursal
            // 
            this.labelSucursal.AutoSize = true;
            this.labelSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSucursal.Location = new System.Drawing.Point(12, 3);
            this.labelSucursal.Name = "labelSucursal";
            this.labelSucursal.Size = new System.Drawing.Size(60, 16);
            this.labelSucursal.TabIndex = 0;
            this.labelSucursal.Text = "Sucursal";
            // 
            // buttonGuardarIngresarAsiento
            // 
            this.buttonGuardarIngresarAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarIngresarAsiento.Location = new System.Drawing.Point(974, 17);
            this.buttonGuardarIngresarAsiento.Name = "buttonGuardarIngresarAsiento";
            this.buttonGuardarIngresarAsiento.Size = new System.Drawing.Size(100, 33);
            this.buttonGuardarIngresarAsiento.TabIndex = 31;
            this.buttonGuardarIngresarAsiento.Text = "Guardar";
            this.buttonGuardarIngresarAsiento.UseVisualStyleBackColor = true;
            this.buttonGuardarIngresarAsiento.Click += new System.EventHandler(this.buttonGuardarIngresarAsiento_Click);
            // 
            // IngresarAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 668);
            this.Controls.Add(this.panelContenidoIngresarAsiento);
            this.Controls.Add(this.flowLayoutPanelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresarAsiento";
            this.Text = "IngresarAsiento";
            this.flowLayoutPanelTitulo.ResumeLayout(false);
            this.panelContenidoIngresarAsiento.ResumeLayout(false);
            this.panelEstructuraAsiento.ResumeLayout(false);
            this.panelEstructuraAsiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTitulo;
        private System.Windows.Forms.Label labeltituloIngresarAsiento;
        private System.Windows.Forms.Panel panelContenidoIngresarAsiento;
        private System.Windows.Forms.Panel panelEstructuraAsiento;
        private System.Windows.Forms.TextBox textBoxSucursal;
        private System.Windows.Forms.Label labelSucursal;
        private System.Windows.Forms.Label labelTipoLibro;
        private System.Windows.Forms.TextBox textBoxNroAsiento;
        private System.Windows.Forms.Label LabelNroAsiento;
        private System.Windows.Forms.TextBox textBoxPeriodoMes;
        private System.Windows.Forms.TextBox textBoxPeriodoAnio;
        private System.Windows.Forms.Label labelPeriodoMes;
        private System.Windows.Forms.Label labelPeriodoAnio;
        private System.Windows.Forms.Label labelPeriodo;
        private System.Windows.Forms.ListBox listBoxCodigoLibro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxTipoDocumento;
        private System.Windows.Forms.Label labelTipoDocumento;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelTituloDocumento;
        private System.Windows.Forms.Label labelTipoProvedor;
        private System.Windows.Forms.Label labelTituloProvedor;
        private System.Windows.Forms.TextBox textBoxFechaVenciomiento;
        private System.Windows.Forms.TextBox textBoxFechaEmision;
        private System.Windows.Forms.Label labelFechaVencimientoDocumento;
        private System.Windows.Forms.Label labelFechaEmisionDocumento;
        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
        private System.Windows.Forms.TextBox textBoxSerieDocumento;
        private System.Windows.Forms.Label labelNumeroDocumento;
        private System.Windows.Forms.Label labelSerieDocumento;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelDenominacion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelRUCProvedor;
        private System.Windows.Forms.TextBox textBoxTipoProvedor;
        private System.Windows.Forms.Button buttonGuardarIngresarAsiento;
    }
}