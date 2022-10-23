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
           // port_printer = new SerialPort("COM3", 4800, Parity.None, 8, StopBits.One);
            if (!port_printer.IsOpen)
            {
                //Setting the Serial Port parameter
                port_printer.PortName = "COM3";
                port_printer.BaudRate = 9600;
                port_printer.DataBits = 8;
                port_printer.StopBits = StopBits.One;

                port_printer.Encoding = Encoding.Default;
                Console.WriteLine(port_printer.Encoding.EncodingName.ToString());
                //set the read/write timeouts
                port_printer.ReadTimeout = 500;
                port_printer.WriteTimeout = 500;

                //Open the port
                port_printer.Open();

                status_receiving = true;
                Console.WriteLine(port_printer.IsOpen.ToString());
                try
                {
                    byte[] hex_askstatus = new byte[]{0x1B, 0x1B, 0x1B, 0x4F, 0x0D };
                    byte[] hex_ini = new byte[] { 0x1B, 0x1B, 0x52, 0x0D };
                    byte[] hex_paper = new byte[] { 0x1B, 0x1B, 0x4C, 0x42, 0x39, 0x0D };//送紙測試OK
                    byte[] hex = new byte[] { 0x1B, 0x1B, 0x50, 0x42, 0x31 };
                    byte[] hex_print = new byte[] {0x1B, 0x1B, 0x50, 0x52, 0x31, 0x32, 0x33, 0x20, 0x0E, 0x31, 0x0E, 0x32, 0x0E, 0x0D};
                    byte[] hex_printtest_1 = new byte[] { 0x1B, 0x50, 0x42, 0x31, 0x0B, 0xA4, 0xA4, 0xA4, 0xE5, 0x0B, 0xA4, 0xA4, 0xA4, 0xE5, 0x0D };
                    byte[] hex_printtest_2 = new byte[] { 0x1B, 0x1B, 0x54, 0x31, 0x20, 0x20, 0x20, 0x20, 0x0B, 0xB0, 0xD3, 0xA9, 0xB1, 0xA6, 0x57, 0xBA, 0xD9, 0x0D };
                    byte[] hex_printtest_3 = new byte[] { };
                    byte[] hex_cut = new byte[] { 0x1B, 0x1B, 0x56, 0x52, 0x0D };

                    //port_printer.Write(hex_askstatus, 0, hex_askstatus.Length);
                    //port_printer.Write(hex_ini, 0, hex_ini.Length);

                    //port_printer.Write(hex_paper, 0, hex_paper.Length);//TESTOK
                    //  port_printer.Write(hex, 0, hex.Length);
                    //port_printer.Write(hex_print, 0, hex_print.Length);
                    //port_printer.Write(hex_printtest_1, 0, hex_printtest_1.Length);
                    //port_printer.Write(hex_printtest_2, 0, hex_printtest_2.Length);
                    //Thread.Sleep(500);

                    port_printer.Write(hex_cut, 0, hex_cut.Length);
                    Thread.Sleep(500);

                    byte[] dec_ini = new byte[] { 27, 27, 82, 13 };
                    byte[] dec_paper = new byte[] { 27, 27, 76, 68, 57, 13 };
                    byte[] dec = new byte[] { };
                    //  port_printer.Write(dec_ini, 0, dec_ini.Length);
                    //  port_printer.Write(dec_paper, 0, dec_paper.Length);

                    /*string[] str_paper = new string[] { "ESC", "ESC", "L", "B", "1", "CR" };
                    for(int i=0; i<str_paper.Length; i++) 
                    {
                        port_printer.Write(str_paper[i]);
                    }*/
                    Console.WriteLine("Send OK!");
                    port_printer.Close();
                 }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        
        }
    }
}

