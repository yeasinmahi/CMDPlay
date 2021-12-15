using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMDPlay
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            DisplayForm(new TelnetForm());
        }
        public void DisplayForm(Form form)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "HomeForm")
                    f.Close();
            }

            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.BringToFront();
        }

        private void telnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm(new TelnetForm());
        }

        private void pingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm(new PingForm());
        }

        private void powerShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm(new PowerShellForm());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
