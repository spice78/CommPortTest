using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CommPortTest
{
    public partial class Form1 : Form
    {        
        public Form1()
        {            
            InitializeComponent();            
        }

        private void btnGetSerialPorts_Click(object sender, EventArgs e)
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;
            //SerialPort ComPort = new SerialPort;           

            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                rtbIncoming.Text += ArrayComPortsNames[index] + "\n";
            }
            while (!((ArrayComPortsNames[index] == ComPortName) ||
            (index == ArrayComPortsNames.GetUpperBound(0))));
        }

    }
}
