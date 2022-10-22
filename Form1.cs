using System;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RS232ReadandWriteApp
{
    public partial class Form1 : Form
    {
        private bool status_receiving = false;
        private Thread thread_print;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (port_printer.IsOpen)
                {
                    port_printer.Close();
                }

                //Setting the Serial Port parameter
                port_printer.PortName = "COM3";
                port_printer.BaudRate = 4800;
                port_printer.DataBits = 8;
                port_printer.StopBits = StopBits.One;

                //set the read/write timeouts
                port_printer.ReadTimeout = 500;
                port_printer.WriteTimeout = 500;

                if (!port_printer.IsOpen)
                {
                    //Open the port
                    port_printer.Open();

                    status_receiving = true;

                    thread_print = new Thread(ReceiveData);
                    thread_print.IsBackground = true;
                    thread_print.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void ReceiveData()
        {
            Byte[] buffer_receive = new Byte[1024];

            try
            {
                while (status_receiving)
                {
                     if (port_printer.BytesToRead > 0)
                     {
                         Int32 length = port_printer.Read(buffer_receive, 0, buffer_receive.Length);

                         string buffer_temp = Encoding.ASCII.GetString(buffer_receive);

                         Array.Resize(ref buffer_receive, length);
                         Console.WriteLine(buffer_temp); 
                        //Display d = new Display(ConsoleShow);
                         //this.Invoke(d, new Object[] { buf });
                         //Array.Resize(ref buffer, 1024);
                     }
                    
                    Thread.Sleep(20);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendData(Object buffer_send)
        {
            Byte[] buffer_temp = new Byte[1024];

            
            if (buffer_send != null)
            {
                buffer_temp = buffer_send as Byte[];

                try
                {
                    port_printer.Write(buffer_temp, 0, buffer_temp.Length);
                    Console.WriteLine(buffer_temp.ToString());
                }
                catch (Exception ex)
                {
                    ClosePort();
                    Console.WriteLine("SENDFAILED");
                }
            }
            else
            {
                Console.WriteLine("SENDBUFFER IS NILL");
            }
        }

        public void ClosePort()
        {
            try
            {
                port_printer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Get all ports on computer
            string[] AllPorts = SerialPort.GetPortNames();
            txtbx_portlist.Text += "The following serial ports were found"+ Environment.NewLine;
            foreach (string port in AllPorts)
            {
                txtbx_portlist.Text += port;
                txtbx_portlist.Text += Environment.NewLine;
            }

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (!port_printer.IsOpen)
            {
                //Setting the Serial Port parameter
                port_printer.PortName = "COM3";
                port_printer.BaudRate = 4800;
                port_printer.DataBits = 8;
                port_printer.StopBits = StopBits.One;

                //Open the port
                port_printer.Open();

                status_receiving = true;
                byte[] hex_ini = { 0x1B, 0x1B, 0x52, 0x0D };
                byte[] hex_paper = { 0x1B, 0x1B, 0x4C, 0x52, 0x31, 0x0D };
                byte[] hex = { 0x1B, 0x1B, 0x50, 0x42, 0x31 };
                port_printer.Write(hex_ini, 0, hex_ini.Length);
                port_printer.Write(hex_paper, 0, hex_paper.Length);
                port_printer.Write(hex, 0, hex.Length);
            
            }
            
        
        }
    }
}

