namespace TxRx_SerialPort
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRx = new System.Windows.Forms.Label();
            this.txtRecibidos = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.cmbPuertos = new System.Windows.Forms.ComboBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtTx = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B2OFF = new System.Windows.Forms.PictureBox();
            this.B1OFF = new System.Windows.Forms.PictureBox();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.NmON = new System.Windows.Forms.PictureBox();
            this.NbON = new System.Windows.Forms.PictureBox();
            this.alarmaON = new System.Windows.Forms.PictureBox();
            this.B2ON = new System.Windows.Forms.PictureBox();
            this.cicloON = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.NaON = new System.Windows.Forms.PictureBox();
            this.falloON = new System.Windows.Forms.PictureBox();
            this.B1ON = new System.Windows.Forms.PictureBox();
            this.NaOFF = new System.Windows.Forms.PictureBox();
            this.NmOFF = new System.Windows.Forms.PictureBox();
            this.alarmaOFF = new System.Windows.Forms.PictureBox();
            this.falloOFF = new System.Windows.Forms.PictureBox();
            this.cicloOFF = new System.Windows.Forms.PictureBox();
            this.NbOFF = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.B2OFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1OFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmaON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2ON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicloON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NaON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1ON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NaOFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmOFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmaOFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloOFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicloOFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbOFF)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM2";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRx);
            this.groupBox2.Controls.Add(this.txtRecibidos);
            this.groupBox2.Location = new System.Drawing.Point(18, 96);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(317, 59);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // txtRx
            // 
            this.txtRx.BackColor = System.Drawing.Color.White;
            this.txtRx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRx.Font = new System.Drawing.Font("Kristen ITC", 8F);
            this.txtRx.Location = new System.Drawing.Point(70, 23);
            this.txtRx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRx.Name = "txtRx";
            this.txtRx.Size = new System.Drawing.Size(239, 23);
            this.txtRx.TabIndex = 14;
            // 
            // txtRecibidos
            // 
            this.txtRecibidos.BackColor = System.Drawing.Color.White;
            this.txtRecibidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibidos.Location = new System.Drawing.Point(8, 23);
            this.txtRecibidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRecibidos.Name = "txtRecibidos";
            this.txtRecibidos.Size = new System.Drawing.Size(100, 23);
            this.txtRecibidos.TabIndex = 15;
            this.txtRecibidos.Text = "Datos Rx";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(79, 269);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(37, 16);
            this.Label14.TabIndex = 186;
            this.Label14.Text = "Ciclo";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(146, 269);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(36, 16);
            this.Label13.TabIndex = 184;
            this.Label13.Text = "Fallo";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(211, 269);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(54, 16);
            this.Label12.TabIndex = 183;
            this.Label12.Text = "Alarma";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.SystemColors.Highlight;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Label10.Location = new System.Drawing.Point(115, 521);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(58, 23);
            this.Label10.TabIndex = 180;
            this.Label10.Text = "Agua";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(742, 294);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(70, 16);
            this.Label9.TabIndex = 176;
            this.Label9.Text = "Nivel Bajo";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(733, 196);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(80, 16);
            this.Label8.TabIndex = 175;
            this.Label8.Text = "Nivel Medio";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(741, 103);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(69, 16);
            this.Label7.TabIndex = 174;
            this.Label7.Text = "Nivel Alto";
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM2";
            // 
            // cmbPuertos
            // 
            this.cmbPuertos.Font = new System.Drawing.Font("Kristen ITC", 8F);
            this.cmbPuertos.FormattingEnabled = true;
            this.cmbPuertos.Location = new System.Drawing.Point(131, 23);
            this.cmbPuertos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.Size = new System.Drawing.Size(76, 24);
            this.cmbPuertos.TabIndex = 12;
            this.cmbPuertos.SelectedIndexChanged += new System.EventHandler(this.cmbPuertos_SelectedIndexChanged_1);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(210, 23);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 22);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // txtTx
            // 
            this.txtTx.Font = new System.Drawing.Font("Kristen ITC", 8F);
            this.txtTx.Location = new System.Drawing.Point(8, 61);
            this.txtTx.Margin = new System.Windows.Forms.Padding(4);
            this.txtTx.Name = "txtTx";
            this.txtTx.Size = new System.Drawing.Size(301, 22);
            this.txtTx.TabIndex = 14;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.White;
            this.lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(8, 26);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(122, 24);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "COM Disponibles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.txtTx);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.cmbPuertos);
            this.groupBox1.Location = new System.Drawing.Point(18, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(317, 91);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // B2OFF
            // 
            this.B2OFF.Image = global::TxRx_SerialPort.Properties.Resources.Bomba011_off;
            this.B2OFF.Location = new System.Drawing.Point(350, 354);
            this.B2OFF.Name = "B2OFF";
            this.B2OFF.Size = new System.Drawing.Size(63, 61);
            this.B2OFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.B2OFF.TabIndex = 194;
            this.B2OFF.TabStop = false;
            // 
            // B1OFF
            // 
            this.B1OFF.Image = global::TxRx_SerialPort.Properties.Resources.Bomba011_off;
            this.B1OFF.Location = new System.Drawing.Point(454, 375);
            this.B1OFF.Name = "B1OFF";
            this.B1OFF.Size = new System.Drawing.Size(63, 61);
            this.B1OFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.B1OFF.TabIndex = 193;
            this.B1OFF.TabStop = false;
            // 
            // PictureBox5
            // 
            this.PictureBox5.BackColor = System.Drawing.Color.Gray;
            this.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox5.Location = new System.Drawing.Point(316, 439);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(787, 187);
            this.PictureBox5.TabIndex = 173;
            this.PictureBox5.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(849, 49);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(177, 323);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 169;
            this.PictureBox1.TabStop = false;
            // 
            // NmON
            // 
            this.NmON.Image = global::TxRx_SerialPort.Properties.Resources.VBRILLA;
            this.NmON.Location = new System.Drawing.Point(818, 196);
            this.NmON.Name = "NmON";
            this.NmON.Size = new System.Drawing.Size(24, 26);
            this.NmON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NmON.TabIndex = 178;
            this.NmON.TabStop = false;
            this.NmON.Visible = false;
            // 
            // NbON
            // 
            this.NbON.Image = global::TxRx_SerialPort.Properties.Resources.VBRILLA;
            this.NbON.Location = new System.Drawing.Point(818, 293);
            this.NbON.Name = "NbON";
            this.NbON.Size = new System.Drawing.Size(24, 26);
            this.NbON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NbON.TabIndex = 179;
            this.NbON.TabStop = false;
            this.NbON.Visible = false;
            // 
            // alarmaON
            // 
            this.alarmaON.Image = global::TxRx_SerialPort.Properties.Resources.LUZAMA;
            this.alarmaON.Location = new System.Drawing.Point(214, 241);
            this.alarmaON.Name = "alarmaON";
            this.alarmaON.Size = new System.Drawing.Size(24, 25);
            this.alarmaON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alarmaON.TabIndex = 181;
            this.alarmaON.TabStop = false;
            this.alarmaON.Visible = false;
            // 
            // B2ON
            // 
            this.B2ON.Image = global::TxRx_SerialPort.Properties.Resources.Bomba011_on;
            this.B2ON.Location = new System.Drawing.Point(350, 354);
            this.B2ON.Name = "B2ON";
            this.B2ON.Size = new System.Drawing.Size(65, 64);
            this.B2ON.TabIndex = 171;
            this.B2ON.TabStop = false;
            this.B2ON.Visible = false;
            // 
            // cicloON
            // 
            this.cicloON.Image = global::TxRx_SerialPort.Properties.Resources.LUZVERDE;
            this.cicloON.Location = new System.Drawing.Point(82, 241);
            this.cicloON.Name = "cicloON";
            this.cicloON.Size = new System.Drawing.Size(24, 25);
            this.cicloON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cicloON.TabIndex = 185;
            this.cicloON.TabStop = false;
            this.cicloON.Visible = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(802, 369);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(269, 80);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 170;
            this.PictureBox3.TabStop = false;
            // 
            // NaON
            // 
            this.NaON.Image = global::TxRx_SerialPort.Properties.Resources.VBRILLA;
            this.NaON.Location = new System.Drawing.Point(818, 103);
            this.NaON.Name = "NaON";
            this.NaON.Size = new System.Drawing.Size(24, 26);
            this.NaON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NaON.TabIndex = 177;
            this.NaON.TabStop = false;
            this.NaON.Visible = false;
            // 
            // falloON
            // 
            this.falloON.Image = global::TxRx_SerialPort.Properties.Resources.RBRILLA;
            this.falloON.Location = new System.Drawing.Point(149, 241);
            this.falloON.Name = "falloON";
            this.falloON.Size = new System.Drawing.Size(24, 25);
            this.falloON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.falloON.TabIndex = 182;
            this.falloON.TabStop = false;
            this.falloON.Visible = false;
            // 
            // B1ON
            // 
            this.B1ON.Image = global::TxRx_SerialPort.Properties.Resources.Bomba011_on;
            this.B1ON.Location = new System.Drawing.Point(456, 375);
            this.B1ON.Name = "B1ON";
            this.B1ON.Size = new System.Drawing.Size(61, 63);
            this.B1ON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.B1ON.TabIndex = 172;
            this.B1ON.TabStop = false;
            this.B1ON.Visible = false;
            // 
            // NaOFF
            // 
            this.NaOFF.Image = global::TxRx_SerialPort.Properties.Resources.LUZOFF;
            this.NaOFF.Location = new System.Drawing.Point(818, 104);
            this.NaOFF.Name = "NaOFF";
            this.NaOFF.Size = new System.Drawing.Size(24, 25);
            this.NaOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NaOFF.TabIndex = 187;
            this.NaOFF.TabStop = false;
            // 
            // NmOFF
            // 
            this.NmOFF.Image = global::TxRx_SerialPort.Properties.Resources.LUZOFF;
            this.NmOFF.Location = new System.Drawing.Point(818, 197);
            this.NmOFF.Name = "NmOFF";
            this.NmOFF.Size = new System.Drawing.Size(24, 25);
            this.NmOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NmOFF.TabIndex = 188;
            this.NmOFF.TabStop = false;
            // 
            // alarmaOFF
            // 
            this.alarmaOFF.Image = global::TxRx_SerialPort.Properties.Resources.LUZOFF;
            this.alarmaOFF.Location = new System.Drawing.Point(214, 241);
            this.alarmaOFF.Name = "alarmaOFF";
            this.alarmaOFF.Size = new System.Drawing.Size(24, 25);
            this.alarmaOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alarmaOFF.TabIndex = 191;
            this.alarmaOFF.TabStop = false;
            // 
            // falloOFF
            // 
            this.falloOFF.Image = global::TxRx_SerialPort.Properties.Resources.LUZOFF;
            this.falloOFF.Location = new System.Drawing.Point(149, 241);
            this.falloOFF.Name = "falloOFF";
            this.falloOFF.Size = new System.Drawing.Size(24, 25);
            this.falloOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.falloOFF.TabIndex = 190;
            this.falloOFF.TabStop = false;
            // 
            // cicloOFF
            // 
            this.cicloOFF.Image = global::TxRx_SerialPort.Properties.Resources.LUZOFF;
            this.cicloOFF.Location = new System.Drawing.Point(82, 241);
            this.cicloOFF.Name = "cicloOFF";
            this.cicloOFF.Size = new System.Drawing.Size(24, 25);
            this.cicloOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cicloOFF.TabIndex = 192;
            this.cicloOFF.TabStop = false;
            // 
            // NbOFF
            // 
            this.NbOFF.Image = global::TxRx_SerialPort.Properties.Resources.LUZOFF;
            this.NbOFF.Location = new System.Drawing.Point(818, 295);
            this.NbOFF.Name = "NbOFF";
            this.NbOFF.Size = new System.Drawing.Size(24, 25);
            this.NbOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NbOFF.TabIndex = 189;
            this.NbOFF.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1102, 625);
            this.shapeContainer1.TabIndex = 195;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.SystemColors.Highlight;
            this.rectangleShape1.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(-1, 472);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(316, 153);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 10;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 348;
            this.lineShape1.X2 = 246;
            this.lineShape1.Y1 = 402;
            this.lineShape1.Y2 = 402;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 625);
            this.Controls.Add(this.B2OFF);
            this.Controls.Add(this.B1OFF);
            this.Controls.Add(this.PictureBox5);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.NmON);
            this.Controls.Add(this.NbON);
            this.Controls.Add(this.alarmaON);
            this.Controls.Add(this.B2ON);
            this.Controls.Add(this.cicloON);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.NaON);
            this.Controls.Add(this.falloON);
            this.Controls.Add(this.B1ON);
            this.Controls.Add(this.NaOFF);
            this.Controls.Add(this.NmOFF);
            this.Controls.Add(this.alarmaOFF);
            this.Controls.Add(this.falloOFF);
            this.Controls.Add(this.cicloOFF);
            this.Controls.Add(this.NbOFF);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Kristen ITC", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Comunicación Serial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.B2OFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1OFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmaON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2ON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicloON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NaON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1ON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NaOFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmOFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmaOFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloOFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicloOFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbOFF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtRx;
        private System.Windows.Forms.Label txtRecibidos;
        internal System.Windows.Forms.PictureBox B2OFF;
        internal System.Windows.Forms.PictureBox B1OFF;
        internal System.Windows.Forms.PictureBox PictureBox5;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.PictureBox NmON;
        internal System.Windows.Forms.PictureBox NbON;
        internal System.Windows.Forms.PictureBox alarmaON;
        internal System.Windows.Forms.PictureBox B2ON;
        private System.IO.Ports.SerialPort serialPort2;
        internal System.Windows.Forms.PictureBox cicloON;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.PictureBox NaON;
        internal System.Windows.Forms.PictureBox falloON;
        internal System.Windows.Forms.PictureBox B1ON;
        internal System.Windows.Forms.PictureBox NaOFF;
        internal System.Windows.Forms.PictureBox NmOFF;
        internal System.Windows.Forms.PictureBox alarmaOFF;
        internal System.Windows.Forms.PictureBox falloOFF;
        internal System.Windows.Forms.PictureBox cicloOFF;
        internal System.Windows.Forms.PictureBox NbOFF;
        private System.Windows.Forms.ComboBox cmbPuertos;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtTx;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}

