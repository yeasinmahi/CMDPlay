using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMDPlay
{
    public partial class PowerShellForm : Form
    {
        public PowerShellForm()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            //var path = logTxtBox.Text;
            //if (string.IsNullOrWhiteSpace(path))
            //{
            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        path = openFileDialog1.FileName;
            //        logTxtBox.Text = path;
            //    }
            //}
            LoadLog();
        }
        public void LoadLog()
        {
            //string path = logTxtBox.Text;
            string path = "C:\\Users\\my.arafat\\u_ex211222_x.log";
            string cmd = "Import-Csv -Delimiter ' ' -Header ((Get-Content "+ path+" -ReadCount 4 -TotalCount 4)[3].split(' ') | Where-Object { $_ -ne '#Fields:' }) -Path "+path+" | Where-Object { $_.date -notlike '#*' }";
            Collection<PSObject> obj = ExecutePowershell<Collection<PSObject>>(cmd);
            ArrayList objects = new ArrayList();
            objects.AddRange(obj);
            dataGridView.DataSource = objects;
        }
        public T ExecutePowershell<T>(string command) 
        {

            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                PowerShellInstance.AddScript(command);
                if(typeof(T) == typeof(Collection<PSObject>))
                {
                    Collection<PSObject>  result = PowerShellInstance.Invoke();
                    return (T)Convert.ChangeType(result, typeof(T));
                }
            }
            return default;
        }
    }
}
