
namespace CMDPlay
{
    partial class TelnetForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IpTxtBox = new System.Windows.Forms.TextBox();
            this.PortTxtBox = new System.Windows.Forms.TextBox();
            this.TelnetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.verifyLbl = new System.Windows.Forms.Label();
            this.IpPortTxtbox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.writeOutputBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.outputTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telnetAllBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // IpTxtBox
            // 
            this.IpTxtBox.Location = new System.Drawing.Point(6, 42);
            this.IpTxtBox.Name = "IpTxtBox";
            this.IpTxtBox.Size = new System.Drawing.Size(149, 23);
            this.IpTxtBox.TabIndex = 0;
            this.IpTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IpTxtBox_KeyPress);
            // 
            // PortTxtBox
            // 
            this.PortTxtBox.Location = new System.Drawing.Point(173, 43);
            this.PortTxtBox.Name = "PortTxtBox";
            this.PortTxtBox.Size = new System.Drawing.Size(90, 23);
            this.PortTxtBox.TabIndex = 0;
            this.PortTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PortTxtBox_KeyPress);
            // 
            // TelnetBtn
            // 
            this.TelnetBtn.Location = new System.Drawing.Point(300, 43);
            this.TelnetBtn.Name = "TelnetBtn";
            this.TelnetBtn.Size = new System.Drawing.Size(75, 23);
            this.TelnetBtn.TabIndex = 1;
            this.TelnetBtn.Text = "Telnet";
            this.TelnetBtn.UseVisualStyleBackColor = true;
            this.TelnetBtn.Click += new System.EventHandler(this.TelnetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // verifyLbl
            // 
            this.verifyLbl.AutoSize = true;
            this.verifyLbl.Location = new System.Drawing.Point(279, 45);
            this.verifyLbl.Name = "verifyLbl";
            this.verifyLbl.Size = new System.Drawing.Size(0, 15);
            this.verifyLbl.TabIndex = 2;
            // 
            // IpPortTxtbox
            // 
            this.IpPortTxtbox.Location = new System.Drawing.Point(8, 36);
            this.IpPortTxtbox.Multiline = true;
            this.IpPortTxtbox.Name = "IpPortTxtbox";
            this.IpPortTxtbox.Size = new System.Drawing.Size(256, 233);
            this.IpPortTxtbox.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(464, 17);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(324, 421);
            this.dataGridView.TabIndex = 4;
            // 
            // writeOutputBtn
            // 
            this.writeOutputBtn.Location = new System.Drawing.Point(301, 300);
            this.writeOutputBtn.Name = "writeOutputBtn";
            this.writeOutputBtn.Size = new System.Drawing.Size(75, 23);
            this.writeOutputBtn.TabIndex = 1;
            this.writeOutputBtn.Text = "Write";
            this.writeOutputBtn.UseVisualStyleBackColor = true;
            this.writeOutputBtn.Click += new System.EventHandler(this.writeOutputBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "output.txt";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.ShowHelp = true;
            this.openFileDialog1.Title = "Output File Location";
            this.openFileDialog1.ValidateNames = false;
            // 
            // outputTxtBox
            // 
            this.outputTxtBox.Location = new System.Drawing.Point(7, 300);
            this.outputTxtBox.Name = "outputTxtBox";
            this.outputTxtBox.Size = new System.Drawing.Size(257, 23);
            this.outputTxtBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output File";
            // 
            // telnetAllBtn
            // 
            this.telnetAllBtn.Location = new System.Drawing.Point(301, 148);
            this.telnetAllBtn.Name = "telnetAllBtn";
            this.telnetAllBtn.Size = new System.Drawing.Size(75, 23);
            this.telnetAllBtn.TabIndex = 1;
            this.telnetAllBtn.Text = "Telnet";
            this.telnetAllBtn.UseVisualStyleBackColor = true;
            this.telnetAllBtn.Click += new System.EventHandler(this.telnetAllBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IpTxtBox);
            this.groupBox1.Controls.Add(this.verifyLbl);
            this.groupBox1.Controls.Add(this.PortTxtBox);
            this.groupBox1.Controls.Add(this.TelnetBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Single Telnet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputTxtBox);
            this.groupBox2.Controls.Add(this.IpPortTxtbox);
            this.groupBox2.Controls.Add(this.telnetAllBtn);
            this.groupBox2.Controls.Add(this.writeOutputBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 339);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Multiple Telnet";
            // 
            // TelnetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "TelnetForm";
            this.Text = "Telnet Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox IpTxtBox;
        private System.Windows.Forms.TextBox PortTxtBox;
        private System.Windows.Forms.Button TelnetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label verifyLbl;
        private System.Windows.Forms.TextBox IpPortTxtbox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button writeOutputBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox outputTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button telnetAllBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

