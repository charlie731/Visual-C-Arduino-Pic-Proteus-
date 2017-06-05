using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TxRx_SerialPort
{
    public partial class Form1 : Form
    {
       int RA0, RA1, RA2, RA3, RA4; // Variables Globales Puerto A        
       int RB0, RB1, RB2, RB3; // Variables Globales Puerto B
       int tubo1;
      
        public Form1()
        {
            InitializeComponent();
            //Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void puertosDisponibles()
        {
            foreach (string puertoDis in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmbPuertos.Items.Add(puertoDis);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            puertosDisponibles();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string Rx; // Variable String...
            Rx = serialPort1.ReadExisting(); // Captura de Datos de trama...

            int F1 = Rx.IndexOf("$", 0); // Si es valida la trama de inicio...
            if (F1 != 0) return; // Si no es Valida sale del Private...
            /*
            string Rx1 = Rx.Substring(1, 2); // Corta primera parte del string
            //string NewRx1 =Convert.ToString(Convert.ToInt32(Rx1, 16),2); // lo convierte a numero binario.
            int NewRx1 = Convert.ToInt32(Rx1, 16); // lo convierte a numero decimal
            */
            string Rx0 = Rx.Substring(1, 2);// Corta primera parte del string 
            //textBox1.Text = textBox1.Text + Rx0;
            string Rx1 =Convert.ToString(Convert.ToInt32(Rx0)); // Convierte de string a entero decimal 
            //textBox2.Text = textBox2.Text + Rx1;
            int NewRx1 = Convert.ToByte(Rx1); // lo convierte a numero entero de 8 bits 
            //textBox3.Text = textBox3.Text + NewRx1;

            RA0 = (NewRx1 & 1) / 1 ;   // inicio           
            RA1 = (NewRx1 & 2) / 2;  // Paro           
            RA2 = (NewRx1 & 4) / 4;   // Nb           
            RA3 = (NewRx1 & 8) / 8 ;   // Na            
            RA4 = (NewRx1 & 16) / 16 ; // Termico

            /*
            string Rx2 = Rx.Substring(4, 2);
            int NewRx2 = Convert.ToInt32(Rx2, 16);
            */
            string Rx2 = Rx.Substring(4, 2);// Corta segunda parte del string  
            string Rx3 = Convert.ToString(Convert.ToInt32(Rx2)); // Convierte de string a entero decimal       
            int NewRx2 = Convert.ToByte(Rx3);// lo convierte a numero entero de 8 bits 

            RB0 = (NewRx2 & 1) / 1; // Led Inicio
            RB1 = (NewRx2 & 2) / 2; // Led Fallo
            RB2 = (NewRx2 & 4) / 4; // Led Pump
            RB3 = (NewRx2 & 8) / 8; // nada



            /* Para Habilitar otro Componente en Otra Hilo "thread"*/
            Thread t = new Thread(eventos);
            t.Start();
            /* Para Hacer Varios Eventos en distintos Hilos */

        }
        private void cmbPuertos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            serialPort1.PortName = cmbPuertos.Text;
            cmbPuertos.Enabled = false;
            try
            {
                serialPort1.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciones otro puerto", "Puerto no disponible");
                cmbPuertos.Enabled = true;
            }
        }
        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(txtTx.Text.Trim());
                txtTx.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("No se puedo enviar la información", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }


        public void eventos()
        {
            if (InvokeRequired)
            {
                if (RA0 == 1) Invoke(new Action(() => ON.Visible = true)); // Interruptor                                           
                if (RA1 == 1) // Paro
                {
                    Invoke(new Action(() => paroON.Visible = true));
                    Invoke(new Action(() => ON.Visible = false));
                    Invoke(new Action(() => B1ON.Visible = false));
                    Invoke(new Action(() => cicloON.Visible = false));
                    Invoke(new Action(() => falloON.Visible = false));
                    Invoke(new Action(() => NbON.Visible = false));
                    Invoke(new Action(() => NaON.Visible = false));
                }
                if (RA1 == 0) Invoke(new Action(() => paroON.Visible = false));

                if (RA2 == 1)
                {
                    Invoke(new Action(() => NbON.Visible = true));
                }
                else
                {
                    Invoke(new Action(() => NbON.Visible = false));
                }

                if (RA3 == 1)
                {
                    Invoke(new Action(() => NaON.Visible = true));
                }
                else
                {
                    Invoke(new Action(() => NaON.Visible = false));
                }
                if (RA4 == 1)
                {
                    Invoke(new Action(() => termico.Visible = true));
                    Invoke(new Action(() => termico1.Visible = true));
                }
                else
                {
                    Invoke(new Action(() => termico.Visible = false));
                    Invoke(new Action(() => termico1.Visible = false));
                }

                /********************** Puerto C o B *********************************/

                if (RB0 == 1) Invoke(new Action(() => cicloON.Visible = true)); // LED    
                if (RB1 == 1) Invoke(new Action(() => falloON.Visible = true));                  
                else                
                    Invoke(new Action(() => falloON.Visible = false));

                if (RB2 == 1)
                {
                    Invoke(new Action(() => B1ON.Visible = true));// Bomba de Agua...
                    Invoke(new Action(() => timer1.Enabled = true));// Bomba de Agua...
                }
                if (RB2 == 0)
                {
                    Invoke(new Action(() => B1ON.Visible = false));// Bomba de Agua...
                    Invoke(new Action(() => timer1.Enabled = false));// Bomba de Agua...
                }
            }
        }
        private void carga_progress(object sender, EventArgs e)
        {
            if (tubo1==0 && verticalProgressBar3.Value < verticalProgressBar3.Maximum)
            {
                verticalProgressBar3.Value = verticalProgressBar3.Value + 1;
                if (verticalProgressBar3.Value >= 99) tubo1 = 1;
            }
            if (tubo1==1 && colorProgressBar1.Value < colorProgressBar1.Maximum)
            {
                colorProgressBar1.Value = colorProgressBar1.Value + 1;
                if (colorProgressBar1.Value >= 99) tubo1 = 2;
            }
            if (tubo1==2 && verticalProgressBar2.Value < verticalProgressBar2.Maximum)
            {
                verticalProgressBar2.Value = verticalProgressBar2.Value + 1;
                if (verticalProgressBar2.Value >= 99) tubo1 = 3;
            }
            if (tubo1 == 3 && colorProgressBar2.Value < colorProgressBar2.Maximum)
            {
                colorProgressBar2.Value = colorProgressBar2.Value + 1;
                if (colorProgressBar2.Value >= 99) tubo1 = 4;
            }
            if (tubo1 == 4 && verticalProgressBar1.Value < verticalProgressBar1.Maximum)
            {
                verticalProgressBar1.Value = verticalProgressBar1.Value + 1;                
                if (verticalProgressBar1.Value >= 99) tubo1 = 5;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tubo1 == 5)
            {
                timer2.Enabled = true;
                consumo.Visible = true;
                //ef += 1;
                if (verticalProgressBar1.Value  < verticalProgressBar1.Maximum)
                {
                    verticalProgressBar3.Value = 0;
                    colorProgressBar1.Value =  0;
                    verticalProgressBar2.Value =  0;
                    colorProgressBar2.Value =  0;
                    
                    verticalProgressBar1.Value = verticalProgressBar1.Value - 10;                   
                    if (verticalProgressBar1.Value >=  0) verticalProgressBar1.Minimum = 1;                    
                    if (verticalProgressBar1.Value <= 10) tubo1 = 0;
                }
            }
        }

        private void consumo_agua(object sender, EventArgs e)
        {
            consumo.Visible = false;
            timer2.Enabled = false;
        }
    }
}
