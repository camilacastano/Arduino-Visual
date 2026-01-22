namespace AplicacionVisual
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPuertoSerial = new System.Windows.Forms.ComboBox();
            this.btnActualizarPuertos = new System.Windows.Forms.Button();
            this.btnEstablecerConexion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTiempoTimer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatoLeido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDetenerToma = new System.Windows.Forms.Button();
            this.btnIniciarToma = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPrenderApagar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblValorScroll = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puertos Seriales Disponibles";
            // 
            // cboPuertoSerial
            // 
            this.cboPuertoSerial.FormattingEnabled = true;
            this.cboPuertoSerial.Location = new System.Drawing.Point(341, 42);
            this.cboPuertoSerial.Name = "cboPuertoSerial";
            this.cboPuertoSerial.Size = new System.Drawing.Size(148, 33);
            this.cboPuertoSerial.TabIndex = 1;
            // 
            // btnActualizarPuertos
            // 
            this.btnActualizarPuertos.Location = new System.Drawing.Point(510, 37);
            this.btnActualizarPuertos.Name = "btnActualizarPuertos";
            this.btnActualizarPuertos.Size = new System.Drawing.Size(181, 40);
            this.btnActualizarPuertos.TabIndex = 2;
            this.btnActualizarPuertos.Text = "Actualizar";
            this.btnActualizarPuertos.UseVisualStyleBackColor = true;
            this.btnActualizarPuertos.Click += new System.EventHandler(this.btnActualizarPuertos_Click);
            // 
            // btnEstablecerConexion
            // 
            this.btnEstablecerConexion.Location = new System.Drawing.Point(166, 116);
            this.btnEstablecerConexion.Name = "btnEstablecerConexion";
            this.btnEstablecerConexion.Size = new System.Drawing.Size(238, 48);
            this.btnEstablecerConexion.TabIndex = 3;
            this.btnEstablecerConexion.Text = "Establecer Conexion";
            this.btnEstablecerConexion.UseVisualStyleBackColor = true;
            this.btnEstablecerConexion.Click += new System.EventHandler(this.btnEstablecerConexion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTiempoTimer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDatoLeido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDetenerToma);
            this.groupBox1.Controls.Add(this.btnIniciarToma);
            this.groupBox1.Location = new System.Drawing.Point(52, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 284);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toma Datos";
            // 
            // txtTiempoTimer
            // 
            this.txtTiempoTimer.Location = new System.Drawing.Point(195, 225);
            this.txtTiempoTimer.Name = "txtTiempoTimer";
            this.txtTiempoTimer.Size = new System.Drawing.Size(99, 31);
            this.txtTiempoTimer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiempo Timer";
            // 
            // txtDatoLeido
            // 
            this.txtDatoLeido.Location = new System.Drawing.Point(130, 150);
            this.txtDatoLeido.Name = "txtDatoLeido";
            this.txtDatoLeido.Size = new System.Drawing.Size(164, 31);
            this.txtDatoLeido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dato\r\nLeido";
            // 
            // btnDetenerToma
            // 
            this.btnDetenerToma.Location = new System.Drawing.Point(187, 54);
            this.btnDetenerToma.Name = "btnDetenerToma";
            this.btnDetenerToma.Size = new System.Drawing.Size(124, 43);
            this.btnDetenerToma.TabIndex = 1;
            this.btnDetenerToma.Text = "Detener";
            this.btnDetenerToma.UseVisualStyleBackColor = true;
            this.btnDetenerToma.Click += new System.EventHandler(this.btnDetenerToma_Click);
            // 
            // btnIniciarToma
            // 
            this.btnIniciarToma.Location = new System.Drawing.Point(24, 54);
            this.btnIniciarToma.Name = "btnIniciarToma";
            this.btnIniciarToma.Size = new System.Drawing.Size(124, 43);
            this.btnIniciarToma.TabIndex = 0;
            this.btnIniciarToma.Text = "Iniciar";
            this.btnIniciarToma.UseVisualStyleBackColor = true;
            this.btnIniciarToma.Click += new System.EventHandler(this.btnIniciarToma_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(474, 170);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(586, 337);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPrenderApagar
            // 
            this.btnPrenderApagar.Location = new System.Drawing.Point(94, 50);
            this.btnPrenderApagar.Name = "btnPrenderApagar";
            this.btnPrenderApagar.Size = new System.Drawing.Size(124, 43);
            this.btnPrenderApagar.TabIndex = 6;
            this.btnPrenderApagar.Text = "Prender";
            this.btnPrenderApagar.UseVisualStyleBackColor = true;
            this.btnPrenderApagar.Click += new System.EventHandler(this.btnPrenderApagar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrenderApagar);
            this.groupBox2.Location = new System.Drawing.Point(52, 522);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 109);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Led";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(40, 40);
            this.hScrollBar1.Maximum = 180;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(364, 34);
            this.hScrollBar1.TabIndex = 8;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblValorScroll);
            this.groupBox3.Controls.Add(this.hScrollBar1);
            this.groupBox3.Location = new System.Drawing.Point(567, 541);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(592, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control Motor";
            // 
            // lblValorScroll
            // 
            this.lblValorScroll.AutoSize = true;
            this.lblValorScroll.Location = new System.Drawing.Point(445, 49);
            this.lblValorScroll.Name = "lblValorScroll";
            this.lblValorScroll.Size = new System.Drawing.Size(24, 25);
            this.lblValorScroll.TabIndex = 9;
            this.lblValorScroll.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 653);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEstablecerConexion);
            this.Controls.Add(this.btnActualizarPuertos);
            this.Controls.Add(this.cboPuertoSerial);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPuertoSerial;
        private System.Windows.Forms.Button btnActualizarPuertos;
        private System.Windows.Forms.Button btnEstablecerConexion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDatoLeido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetenerToma;
        private System.Windows.Forms.Button btnIniciarToma;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtTiempoTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPrenderApagar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblValorScroll;
    }
}

