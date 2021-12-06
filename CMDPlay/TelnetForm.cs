using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMDPlay
{
    public partial class TelnetForm : Form
    {
        public TelnetForm()
        {
            InitializeComponent();
        }

        private void TelnetBtn_Click(object sender, EventArgs e)
        {
            var ip = IpTxtBox.Text;
            var port = int.Parse(PortTxtBox.Text);

            bool IsConnected = Telnet(ip, port);
            if (IsConnected)
            {
                verifyLbl.Text = "✓";
                verifyLbl.ForeColor = Color.Green;
            }
            else
            {
                verifyLbl.Text = "X";
                verifyLbl.ForeColor = Color.Red;
            }

        }

        private bool Telnet(string ip, int port)
        {
            TcpClient tc = null;
            try
            {
                tc = new TcpClient(ip, port);
                return true;
            }
            catch (SocketException se)
            {
                return false;
            }
            finally
            {
                if (tc != null)
                {
                    tc.Close();
                }
            }
        }

        private void PortTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void IpTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void telnetAllBtn_Click(object sender, EventArgs e)
        {
            List<Telnet> telnets = new List<Telnet>();
            var ipPortText = IpPortTxtbox.Text;
            var ipPorts= Regex.Split(ipPortText, "\r\n|\r|\n");
            foreach(var ipPort in ipPorts)
            {
                var ipPortAr = ipPort.Split(" ");
                var ip = ipPortAr[0];
                var port = int.Parse(ipPortAr[1]);
                telnets.Add(new Telnet { Ip = ip, Port = port });
                

            }
            dataGridView.DataSource = telnets;
            foreach (var telnet in telnets)
            {
                telnet.IsConnected= Telnet(telnet.Ip, telnet.Port);
                dataGridView.Refresh();
            }
            


            ;// bool IsConnected = Telnet(ip, port);


        }

        public void t()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }
    }

    public class Telnet
    {
        public string Ip { get; set; }
        public int Port { get; set; }
        public bool IsConnected { get; set; }
    }
}
