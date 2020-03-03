namespace port
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SettinggroupBox = new System.Windows.Forms.GroupBox();
            this.btnOpenCom = new System.Windows.Forms.Button();
            this.btnCheckCom = new System.Windows.Forms.Button();
            this.cbxStopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDataBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCOMPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbnRxHex = new System.Windows.Forms.RadioButton();
            this.rbnRxChar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxRecvData = new System.Windows.Forms.TextBox();
            this.tbxSendData = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnTxChar = new System.Windows.Forms.RadioButton();
            this.rbnTxHex = new System.Windows.Forms.RadioButton();
            this.btnSendData = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SettinggroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbxSendData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettinggroupBox
            // 
            this.SettinggroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettinggroupBox.Controls.Add(this.btnOpenCom);
            this.SettinggroupBox.Controls.Add(this.btnCheckCom);
            this.SettinggroupBox.Controls.Add(this.cbxStopBits);
            this.SettinggroupBox.Controls.Add(this.label5);
            this.SettinggroupBox.Controls.Add(this.cbxDataBits);
            this.SettinggroupBox.Controls.Add(this.label4);
            this.SettinggroupBox.Controls.Add(this.cbxParity);
            this.SettinggroupBox.Controls.Add(this.label3);
            this.SettinggroupBox.Controls.Add(this.cbxBaudRate);
            this.SettinggroupBox.Controls.Add(this.label2);
            this.SettinggroupBox.Controls.Add(this.cbxCOMPort);
            this.SettinggroupBox.Controls.Add(this.label1);
            this.SettinggroupBox.Location = new System.Drawing.Point(12, 12);
            this.SettinggroupBox.Name = "SettinggroupBox";
            this.SettinggroupBox.Size = new System.Drawing.Size(850, 156);
            this.SettinggroupBox.TabIndex = 0;
            this.SettinggroupBox.TabStop = false;
            this.SettinggroupBox.Text = "Setting";       // 
            // btnOpenCom
            // 
            this.btnOpenCom.Location = new System.Drawing.Point(627, 66);
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.Size = new System.Drawing.Size(114, 23);
            this.btnOpenCom.TabIndex = 11;
            this.btnOpenCom.Text = "OpenCom";
            this.btnOpenCom.UseVisualStyleBackColor = true;
            this.btnOpenCom.Click += new System.EventHandler(this.btnOpenCom_Click);
            // 
            // btnCheckCom
            // 
            this.btnCheckCom.Location = new System.Drawing.Point(627, 23);
            this.btnCheckCom.Name = "btnCheckCom";
            this.btnCheckCom.Size = new System.Drawing.Size(114, 23);
            this.btnCheckCom.TabIndex = 10;
            this.btnCheckCom.Text = "CheckCom";
            this.btnCheckCom.UseVisualStyleBackColor = true;
            this.btnCheckCom.Click += new System.EventHandler(this.btmCheckCom_Click);
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.FormattingEnabled = true;
            this.cbxStopBits.Location = new System.Drawing.Point(469, 23);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Size = new System.Drawing.Size(121, 23);
            this.cbxStopBits.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stop";
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.FormattingEnabled = true;
            this.cbxDataBits.Location = new System.Drawing.Point(276, 63);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Size = new System.Drawing.Size(121, 23);
            this.cbxDataBits.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data";
            // 
            // cbxParity
            // 
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Location = new System.Drawing.Point(276, 23);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(121, 23);
            this.cbxParity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parity";
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(63, 63);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(121, 23);
            this.cbxBaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud";
            // 
            // cbxCOMPort
            // 
            this.cbxCOMPort.FormattingEnabled = true;
            this.cbxCOMPort.Location = new System.Drawing.Point(63, 23);
            this.cbxCOMPort.Name = "cbxCOMPort";
            this.cbxCOMPort.Size = new System.Drawing.Size(121, 23);
            this.cbxCOMPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "PORT";
            // 
            // rbnRxHex
            // 
            this.rbnRxHex.AutoSize = true;
            this.rbnRxHex.Location = new System.Drawing.Point(74, 16);
            this.rbnRxHex.Name = "rbnRxHex";
            this.rbnRxHex.Size = new System.Drawing.Size(52, 19);
            this.rbnRxHex.TabIndex = 13;
            this.rbnRxHex.Text = "Hex";
            this.rbnRxHex.UseVisualStyleBackColor = true;
            // 
            // rbnRxChar
            // 
            this.rbnRxChar.AutoSize = true;
            this.rbnRxChar.Checked = true;
            this.rbnRxChar.Location = new System.Drawing.Point(3, 16);
            this.rbnRxChar.Name = "rbnRxChar";
            this.rbnRxChar.Size = new System.Drawing.Size(60, 19);
            this.rbnRxChar.TabIndex = 12;
            this.rbnRxChar.TabStop = true;
            this.rbnRxChar.Text = "Char";
            this.rbnRxChar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.tbxRecvData);
            this.groupBox1.Location = new System.Drawing.Point(12, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 187);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Received Data";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbnRxHex);
            this.panel2.Controls.Add(this.rbnRxChar);
            this.panel2.Location = new System.Drawing.Point(6, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 44);
            this.panel2.TabIndex = 14;
            // 
            // tbxRecvData
            // 
            this.tbxRecvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRecvData.Location = new System.Drawing.Point(9, 62);
            this.tbxRecvData.Multiline = true;
            this.tbxRecvData.Name = "tbxRecvData";
            this.tbxRecvData.ReadOnly = true;
            this.tbxRecvData.Size = new System.Drawing.Size(833, 119);
            this.tbxRecvData.TabIndex = 0;
            // 
            // tbxSendData
            // 
            this.tbxSendData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSendData.Controls.Add(this.panel1);
            this.tbxSendData.Controls.Add(this.btnSendData);
            this.tbxSendData.Controls.Add(this.btnClearData);
            this.tbxSendData.Controls.Add(this.textBox1);
            this.tbxSendData.Location = new System.Drawing.Point(16, 359);
            this.tbxSendData.Name = "tbxSendData";
            this.tbxSendData.Size = new System.Drawing.Size(846, 181);
            this.tbxSendData.TabIndex = 2;
            this.tbxSendData.TabStop = false;
            this.tbxSendData.Text = "Transmitted Data";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnTxChar);
            this.panel1.Controls.Add(this.rbnTxHex);
            this.panel1.Location = new System.Drawing.Point(592, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 73);
            this.panel1.TabIndex = 16;
            // 
            // rbnTxChar
            // 
            this.rbnTxChar.AutoSize = true;
            this.rbnTxChar.Checked = true;
            this.rbnTxChar.Location = new System.Drawing.Point(16, 14);
            this.rbnTxChar.Name = "rbnTxChar";
            this.rbnTxChar.Size = new System.Drawing.Size(60, 19);
            this.rbnTxChar.TabIndex = 14;
            this.rbnTxChar.TabStop = true;
            this.rbnTxChar.Text = "Char";
            this.rbnTxChar.UseVisualStyleBackColor = true;
            // 
            // rbnTxHex
            // 
            this.rbnTxHex.AutoSize = true;
            this.rbnTxHex.Location = new System.Drawing.Point(16, 39);
            this.rbnTxHex.Name = "rbnTxHex";
            this.rbnTxHex.Size = new System.Drawing.Size(52, 19);
            this.rbnTxHex.TabIndex = 15;
            this.rbnTxHex.Text = "Hex";
            this.rbnTxHex.UseVisualStyleBackColor = true;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(722, 82);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(114, 23);
            this.btnSendData.TabIndex = 13;
            this.btnSendData.Text = "SendData";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(722, 53);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(114, 23);
            this.btnClearData.TabIndex = 12;
            this.btnClearData.Text = "ClearData";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(580, 113);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSendData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 563);
            this.Controls.Add(this.tbxSendData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SettinggroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SettinggroupBox.ResumeLayout(false);
            this.SettinggroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tbxSendData.ResumeLayout(false);
            this.tbxSendData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SettinggroupBox;
        private System.Windows.Forms.ComboBox cbxCOMPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxStopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxDataBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxRecvData;
        private System.Windows.Forms.GroupBox tbxSendData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbnRxHex;
        private System.Windows.Forms.RadioButton rbnRxChar;
        private System.Windows.Forms.Button btnOpenCom;
        private System.Windows.Forms.Button btnCheckCom;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button btnClearData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton rbnTxHex;
        private System.Windows.Forms.RadioButton rbnTxChar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

