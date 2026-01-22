using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace AplicacionVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SerialPort puertoSerial;
        bool conexionDefinida = false;
        bool ledEncendido = false;

        private void btnActualizarPuertos_Click(object sender, EventArgs e)
        {
            CargarPuertos();
        }

        public void CargarPuertos()
        {
            cboPuertoSerial.Items.Clear();
            string[] puertos = SerialPort.GetPortNames();

            foreach (string puerto in puertos)
            {
                cboPuertoSerial.Items.Add(puerto);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarPuertos();
        }

        private void btnEstablecerConexion_Click(object sender, EventArgs e)
        {
            if (cboPuertoSerial.Items.Count > 0)
            {
                if (cboPuertoSerial.SelectedIndex > -1)
                {
                    try
                    {
                        conexionDefinida = IniciarComunicacion(cboPuertoSerial.Text, 9600);
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo establecer comunicacion!!!");
                    }
                }
            }
        }

        public bool IniciarComunicacion(string nombrePuerto, int bauds)
        {
            try
            {
                puertoSerial = new SerialPort(nombrePuerto, bauds);
                if (!puertoSerial.IsOpen)
                    puertoSerial.Open();
                puertoSerial.ReadTimeout = 95;
                puertoSerial.Write("probar");
                if (puertoSerial.ReadChar() == 'c')
                {
                    MessageBox.Show("Conexion Establecida!!!");
                }
                return (true);
            }
            catch
            {
                MessageBox.Show("No se pudo establecer comunicacion!!!");
                return (false);
            }
        }

        private void btnIniciarToma_Click(object sender, EventArgs e)
        {
            if (conexionDefinida)
            {
                if (txtTiempoTimer.Text != string.Empty)
                {
                    timer1.Interval = Convert.ToInt32(txtTiempoTimer.Text);
                }
                else
                {
                    timer1.Interval = 100;
                }
                timer1.Enabled = true;
                TomarDatos();
            }
        }

        public void TomarDatos()
        {
            double datoDouble = 0.0;
            int datoEntero = 0;

            if (conexionDefinida)
            {
                datoEntero = TomarDatoArduino();
                datoDouble = datoEntero / 10.0;

                if (chart1.Series[0].Points.Count > 50)
                    chart1.Series[0].Points.RemoveAt(0);

                chart1.Series[0].Points.AddY(datoDouble);
                txtDatoLeido.Text = datoDouble.ToString();
            }
        }

        public int TomarDatoArduino()
        {
            int dato = -1;
            try
            {
                if (conexionDefinida)
                {
                    puertoSerial.Write("l");
                    dato = puertoSerial.ReadChar();
                }
                return (dato);
            }
            catch
            {
                MessageBox.Show("No se pudo leer el dato");
                return (dato);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (conexionDefinida)
            {
                if (txtTiempoTimer.Text != string.Empty)
                {
                    timer1.Interval = Convert.ToInt32(txtTiempoTimer.Text);
                }
                else
                {
                    timer1.Interval = 100;
                }
                TomarDatos();
            }
        }

        private void btnPrenderApagar_Click(object sender, EventArgs e)
        {
            if (!ledEncendido)
            {
                //vaya y lo encienda
                if (conexionDefinida)
                {
                    try
                    {
                        puertoSerial.Write("p");
                        if (puertoSerial.ReadChar() == 'p')
                        {
                            MessageBox.Show("Led encendido!!!");
                            btnPrenderApagar.Text = "Apagar";
                            ledEncendido = true;
                        }
                        else
                        {
                            MessageBox.Show("No se encendio el Led!!!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("No se encendio el Led!!!");
                    }
                }
            }
            else
            {
                //vaya y lo apague
                if (conexionDefinida)
                {
                    try
                    {
                        puertoSerial.Write("a");
                        if (puertoSerial.ReadChar() == 'a')
                        {
                            MessageBox.Show("Led apagado!!!");
                            btnPrenderApagar.Text = "Prender";
                            ledEncendido = false;
                        }
                        else
                        {
                            MessageBox.Show("No se apago el Led!!!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("No se apago el Led!!!");
                    }
                }
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lblValorScroll.Text = hScrollBar1.Value.ToString();

            if (conexionDefinida)
            {
                try
                {
                    puertoSerial.Write("m");
                    if (puertoSerial.ReadChar() == 'm')
                    {
                        puertoSerial.WriteLine(Convert.ToString(hScrollBar1.Value));
                    }
                }
                catch
                {
                    //MessageBox.Show("No se movio el motor");
                }
            }
        }

        private void btnDetenerToma_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
