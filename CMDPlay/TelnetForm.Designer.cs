﻿
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
            this.telnetAllBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IpTxtBox
            // 
            this.IpTxtBox.Location = new System.Drawing.Point(12, 35);
            this.IpTxtBox.Name = "IpTxtBox";
            this.IpTxtBox.Size = new System.Drawing.Size(149, 23);
            this.IpTxtBox.TabIndex = 0;
            this.IpTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IpTxtBox_KeyPress);
            // 
            // PortTxtBox
            // 
            this.PortTxtBox.Location = new System.Drawing.Point(179, 36);
            this.PortTxtBox.Name = "PortTxtBox";
            this.PortTxtBox.Size = new System.Drawing.Size(90, 23);
            this.PortTxtBox.TabIndex = 0;
            this.PortTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PortTxtBox_KeyPress);
            // 
            // TelnetBtn
            // 
            this.TelnetBtn.Location = new System.Drawing.Point(306, 36);
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
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // verifyLbl
            // 
            this.verifyLbl.AutoSize = true;
            this.verifyLbl.Location = new System.Drawing.Point(275, 39);
            this.verifyLbl.Name = "verifyLbl";
            this.verifyLbl.Size = new System.Drawing.Size(0, 15);
            this.verifyLbl.TabIndex = 2;
            // 
            // IpPortTxtbox
            // 
            this.IpPortTxtbox.Location = new System.Drawing.Point(13, 99);
            this.IpPortTxtbox.Multiline = true;
            this.IpPortTxtbox.Name = "IpPortTxtbox";
            this.IpPortTxtbox.Size = new System.Drawing.Size(256, 255);
            this.IpPortTxtbox.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(421, 34);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(367, 404);
            this.dataGridView.TabIndex = 4;
            // 
            // telnetAllBtn
            // 
            this.telnetAllBtn.Location = new System.Drawing.Point(306, 228);
            this.telnetAllBtn.Name = "telnetAllBtn";
            this.telnetAllBtn.Size = new System.Drawing.Size(75, 23);
            this.telnetAllBtn.TabIndex = 1;
            this.telnetAllBtn.Text = "Telnet";
            this.telnetAllBtn.UseVisualStyleBackColor = true;
            this.telnetAllBtn.Click += new System.EventHandler(this.telnetAllBtn_Click);
            // 
            // TelnetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.IpPortTxtbox);
            this.Controls.Add(this.verifyLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telnetAllBtn);
            this.Controls.Add(this.TelnetBtn);
            this.Controls.Add(this.PortTxtBox);
            this.Controls.Add(this.IpTxtBox);
            this.Name = "TelnetForm";
            this.Text = "Telnet Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button telnetAllBtn;
    }
}

