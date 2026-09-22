using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Scanning_Ports
{
    public partial class PortsScan : Form
    {
        public PortsScan()
        {
            InitializeComponent();
        }

        private void PortsScan_Load(object sender, EventArgs e)
        {

        }

        private void button_scan_Click(object sender, EventArgs e)
        {
            int portDown = Convert.ToInt32(numeric_portDown.Value);
            int portUp = Convert.ToInt32(numeric_portUp.Value);

            int i;

            progressBar1.Maximum = portUp - portDown + 1;

            progressBar1.Value = 0;
            listView1.Items.Clear();

            IPAddress addr = IPAddress.Parse(textBox_host.Text);

            for (i = portDown; i<= portUp; i++)
            {
                // Создаем и инициализируем сокет
                IPEndPoint ep = new IPEndPoint(addr, i);
                Socket soc = new Socket(AddressFamily.InterNetwork, 
                    SocketType.Stream, 
                    ProtocolType.Tcp);

                // Пытаемся соединиться с сервером
                IAsyncResult asyncResult = soc.BeginConnect(ep, new AsyncCallback(ConnectCallback), soc);

                if (!asyncResult.AsyncWaitHandle.WaitOne(30, false))
                {
                    soc.Close();
                    listView1.Items.Add("Порт " + i.ToString());
                    listView1.Items[i - portDown].SubItems.Add("");
                    listView1.Items[i - portDown].SubItems.Add("закрыт");
                    listView1.Refresh();
                    progressBar1.Value += 1;
                }
                else 
                {
                    soc.Close();
                    listView1.Items.Add("Порт " + i.ToString());
                    listView1.Items[i - portDown].SubItems.Add("открыт");
                    progressBar1.Value += 1;
                }
            }
        }

        private static void ConnectCallback(IAsyncResult ar)
        {
            try 
            {
                Socket client = (Socket) ar.AsyncState;
                client.EndConnect(ar);
                //connectDone.Set();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
    }
}
