using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace port
{
    public partial class Form1 : Form
    {

        SerialPort sp = null;
        bool isOpen = false;
        bool isSetProperty = false;
        bool isRxHex = false;
        //bool isTxHex = false;
       
        public Form1()
        {
            InitializeComponent();
        }


        //界面设置
        private void Form1_Load(object sender, EventArgs e)
        {
            //窗体大小设置
            this.MaximizeBox = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;


            //添加Com列表元素
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                cbxCOMPort.Items.AddRange(ports);
                cbxCOMPort.SelectedIndex = 0;
            }
            //else
            //{
            //    MessageBox.Show("No serial port available", "error");
            //}


            //for (int i = 0; i < 8; i++)
            //{
            //    cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
            //}

            //cbxCOMPort.SelectedIndex = 0;


            //添加Baud列表元素
            cbxBaudRate.Items.Add("1200");
            cbxBaudRate.Items.Add("2400");
            cbxBaudRate.Items.Add("4800");
            cbxBaudRate.Items.Add("9600");
            cbxBaudRate.Items.Add("19200");
            cbxBaudRate.Items.Add("38400");
            cbxBaudRate.Items.Add("115200");
            cbxBaudRate.SelectedIndex = 3;

            //添加Stop列表元素
            cbxStopBits.Items.Add("1");
            cbxStopBits.Items.Add("1.5");
            cbxStopBits.Items.Add("2");
            cbxStopBits.SelectedIndex = 0;

            //添加Data列表元素
            cbxDataBits.Items.Add("5");
            cbxDataBits.Items.Add("6");
            cbxDataBits.Items.Add("7");
            cbxDataBits.Items.Add("8");
            cbxDataBits.SelectedIndex = 3;

            //添加Parity列表元素
            cbxParity.Items.Add("None");
            cbxParity.Items.Add("Even");
            cbxParity.Items.Add("Odd");
            cbxParity.SelectedIndex = 0;

            //默认开启char
            rbnRxChar.Checked = false;
            //rbnTxChar.Checked = true;

        }


        //检测有无可用串口
        private void btmCheckCom_Click(object sender,EventArgs e)
        {


            bool comExistence = false;
            cbxCOMPort.Items.Clear();
            for (int i = 0; i < 8; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
                    comExistence = true;
                }
                catch (Exception)
                {
                    continue;
                }
            }
            if (comExistence)
            {
                //第一个串口
                cbxCOMPort.SelectedIndex = 0;
            }
            else
            {
                //提示无可用串口
                MessageBox.Show("No serial port available", "error");
            }
        }


        //检测串口有无完成设置
        private bool CheckPortSetting()
        {
            if (cbxCOMPort.Text.Trim() == "") return false;
            if (cbxBaudRate.Text.Trim() == "") return false;
            if (cbxDataBits.Text.Trim() == "") return false;
            if (cbxParity.Text.Trim() == "") return false;
            if (cbxStopBits.Text.Trim() == "") return false;
            return true;
        }


        //检测发送窗口有无内容
        private bool CheckSendData()
        {
            if (tbxSendData.Text.Trim() == "") return false;
            return true;
        }


        //串口设置
        private void SetPortProperty()
        {
            sp = new SerialPort();
            sp.PortName = cbxCOMPort.Text.Trim();//COM名字
            sp.BaudRate = Convert.ToInt32(cbxBaudRate.Text.Trim());//波特率
                

            //停止位
            if(cbxStopBits.Text.Trim()=="1")
            {
                sp.StopBits = StopBits.One;
            }
            else if(cbxStopBits.Text.Trim() == "1.5")
            {
                sp.StopBits = StopBits.OnePointFive;
            }
            else if (cbxStopBits.Text.Trim() == "2")
            {
                sp.StopBits = StopBits.Two;
            }

            sp.DataBits = Convert.ToInt32(cbxDataBits.Text.Trim());//数据位

            //校验位
            if(cbxParity.Text.Trim()=="Odd")
            {
                sp.Parity = Parity.Odd;
            }
            else if (cbxParity.Text.Trim() == "Even")
            {
                sp.Parity = Parity.Even;
            }
            else if (cbxParity.Text.Trim() == "None")
            {
                sp.Parity = Parity.None;
            }

            sp.ReadTimeout = -1;
            sp.RtsEnable = true;//开启发送

            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);//关联接收事件

            if(rbnRxChar.Checked)
            {
                isRxHex = true;
            }
            else
            {
                isRxHex = false;
            }

            //
            //if (rbnTxChar.Checked)
            //{
            //    isTxHex = true;
            //}
            //else
            //{
            //    isTxHex = false;
            //}


        }


        //控件开关
        private void btnOpenCom_Click(object sender,EventArgs e)
        {
            if(isOpen == false)
            {
                if(!CheckPortSetting())
                {
                    MessageBox.Show("Port srtting", "error");
                    return;
                }
                if(!isSetProperty)
                {
                    SetPortProperty();
                    isSetProperty = true;
                }
                try
                {
                    sp.Open();
                    isOpen = true;
                    btnOpenCom.Text = "Close port";

                    cbxCOMPort.Enabled = false;
                    cbxBaudRate.Enabled = false;
                    cbxDataBits.Enabled = false;
                    cbxStopBits.Enabled = false;
                    cbxParity.Enabled = false;
                    rbnRxChar.Enabled = false;
                    rbnRxHex.Enabled = false;
                    //rbnTxChar.Enabled = false;
                    //rbnTxHex.Enabled = false;
                }
                catch(Exception)
                {
                    isSetProperty = false;
                    isOpen = false;
                    MessageBox.Show("Port invalid", "error");
                }
            }
            else
            {
                try
                {
                    sp.Close();
                    isOpen = false;
                    isSetProperty = false;
                    btnOpenCom.Text = "Open port";

                    cbxCOMPort.Enabled = true;
                    cbxBaudRate.Enabled = true;
                    cbxDataBits.Enabled = true;
                    cbxStopBits.Enabled = true;
                    cbxParity.Enabled = true;
                    rbnRxChar.Enabled = true;
                    rbnRxHex.Enabled = true;
                    //rbnTxChar.Enabled = true;
                    //rbnTxHex.Enabled = true;
                }
                catch(Exception)
                {
                    MessageBox.Show("Closs port error", "error");
                }
            }
        }


        //发送内容        
        private void btnSendData_Click(object sender,EventArgs e)
        {
            if(isOpen)
            {
                try
                {
                        //System.Text.UTF8Encoding utf8 = new System.Text.UTF8Encoding();
                        //Byte[] writeBytes = utf8.GetBytes(tbxSendData.Text);
                        //sp.Write(writeBytes, 0, writeBytes.Length);
                        sp.WriteLine(textBox1.Text);                 
                }
                catch
                {
                    MessageBox.Show("Send error", "error");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Port no open", "error");
                return;
            }
            if(!CheckSendData())
            {
                MessageBox.Show("Input data", "error");
                return;
            }
        }


        //接收内容       
        private void sp_DataReceived(object sender,SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(100);

            this.Invoke((EventHandler)(delegate
            {
                if (isRxHex == true)
                {                                    
                    //string str = serialPort1.ReadExisting();
                    //tbxRecvData.AppendText(str);
                    //tbxRecvData.Text += sp.ReadLine();
                    string str = sp.ReadExisting();
                    tbxRecvData.Text += str;


                }
                else
                {
                    //Byte[] ReceivedData = new byte[sp.BytesToRead];
                    //sp.Read(ReceivedData, 0, ReceivedData.Length);
                    //string RecvDataText = null;
                    //string s = string.Empty;
                    //for (int i = 0; i < ReceivedData.Length; i++)
                    //{
                    //    RecvDataText += (ReceivedData[i].ToString("x2") + " ");
                    //    s += (char)ReceivedData[i];
                    //}
                    //tbxRecvData.Text += RecvDataText;
                    //RecvDataText = s;



                    byte data;
                    data = (byte)sp.ReadByte();
                    string str = Convert.ToString(data, 16);
                    tbxRecvData.AppendText("0x" + (str.Length == 1 ? "0" + str : str) + " ");

                }
                sp.DiscardInBuffer();
            }));
            
        }



        //接收内容清空
        private void btnClearData_Click(object sender, EventArgs e)
        {
            tbxRecvData.Text = "";
            //tbxSendData.Text = "";
            //RecvDataTextL = "";
        }

    }
}
