using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
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
        public List<Telnet> telnets;
        private void telnetAllBtn_Click(object sender, EventArgs e)
        {
            telnets = new List<Telnet>();
            var ipPortText = IpPortTxtbox.Text;
            var ipPorts = Regex.Split(ipPortText, "\r\n|\r|\n");
            foreach (var ipPort in ipPorts)
            {
                var ipPortAr = ipPort.Split(" ");
                var ip = ipPortAr[0];
                var port = int.Parse(ipPortAr[1]);
                telnets.Add(new Telnet { Ip = ip, Port = port });
            }
            dataGridView.DataSource = telnets;
            foreach (var telnet in telnets)
            {
                telnet.IsConnected = Telnet(telnet.Ip, telnet.Port);
                dataGridView.Refresh();
            }
        }

        private void writeOutputBtn_Click(object sender, EventArgs e)
        {
            var path = outputTxtBox.Text;
            if (string.IsNullOrWhiteSpace(path))
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog1.FileName;
                    outputTxtBox.Text = path;
                }
            }

            var mesage = WriteInPath(path, ToString(telnets));
            MessageBox.Show(mesage);

        }
        public string ToString(List<Telnet> telnets)
        {
            var s = string.Empty;
            if (telnets != null)
                foreach (var telnet in telnets)
                {
                    s += $"{telnet.Ip} {telnet.Port} {telnet.IsConnected}\n";
                }
            return s;
        }
        public string WriteInPath(string path, string message)
        {
            try
            {
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(message);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                    return "Your request has been processed successfully.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
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
