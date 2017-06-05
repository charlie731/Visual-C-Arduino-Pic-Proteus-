using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace TxRx_SerialPort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
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
            string datorx=serialPort1.ReadExisting();
            txtRx.Text = txtRx.Text+ datorx.Trim();
        }
        private void cmbPuertos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            serialPort1.PortName = cmbPuertos.Text;
            cmbPuertos.Enabled = false;
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo enviar la información", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
