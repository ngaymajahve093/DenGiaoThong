using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.IO.Ports;

namespace DenGiaoThong
{
    public partial class Form1 : Form
    {
        string chuoi;
        delegate void SetTextCallback(string text);

        List<Button>  btnList1;
        List<Button>  btnList1x;
        List<Button>  btnList2;
        List<Button>  btnList2x;
        List<Color> colorList;
        public Form1()
        {
            InitializeComponent();

            btnList1 = new List<Button>
            {
                btn_R1, btn_Y1, btn_G1
            };
            btnList1x = new List<Button>
            {
                btn_R1x, btn_Y1x, btn_G1x
            };
            btnList2 = new List<Button>
            {
                btn_R2, btn_Y2, btn_G2
            };
            btnList2x = new List<Button>
            {
                btn_R2x, btn_Y2x, btn_G2x
            };
            colorList = new List<Color>
            {
                Color.Red,Color.Yellow,Color.Green
            };
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = cbxComList.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
            }
            else
            {
                serialPort1.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                chuoi = serialPort1.ReadLine().ToString().Trim();
                SetText(chuoi);

            }
            catch (Exception err)
            {
                MessageBox.Show("Bạn mất kết nối lúc dữ liệu đang được đọc\n" +
                                  "Rất tiếc, dữ liệu của bạn bị mất 1 phần\n" +
                                  "Muộn rồi, đây chỉ là thông báo :)\n" +
                                  "HAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHA",
                                  "Hey MAN!!!"
                                  , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        string datakey="T";
        string keyE = "E";
        string keyD = "D";
        public void SetText(string text)
        {
            if (this.lbDataReceive2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.BeginInvoke(d, new object[] { text });
            }
            else
            {
                Console.WriteLine(text);
                if (text.Contains("T"))
                {
                    string textEdit = text;
                    textEdit = text.Replace(datakey, "");
                    textEdit = replaceforNumber(textEdit);
                    lbDataReceive1.Text = "Data1: " + textEdit;
                     if (text.Contains(keyD) && text.Contains(keyE) && text.IndexOf(keyE) - text.IndexOf(keyD) > 1)
                    {
                        int value1;
                        int value2;

                        int lengtKeyD = keyD.Length;
                        int poskN = textEdit.IndexOf(keyD);
                        int posmm = textEdit.IndexOf(keyE);

                        int.TryParse(textEdit.Substring(0, textEdit.IndexOf(keyD)), out value1);
                        int.TryParse(textEdit.Substring(poskN + lengtKeyD, posmm - poskN - lengtKeyD), out value2);
                        //Console.WriteLine(value1.ToString());   //textD
                        //Console.WriteLine(value2.ToString());
                        lbDataReceive2.Text = "D: " + value1.ToString() + " - E: " + value2.ToString();
                        lbTextD.Text = value1.ToString();
                        lbTextE.Text = value2.ToString();
                        lbTextDx.Text = value1.ToString();
                        lbTextEx.Text = value2.ToString();
                    }

                }
                else if (text.Contains("X"))
                {
                    string textEdit = text;
                    lbDataReceive0.Text = "Xdata: " + text;
                    Console.WriteLine(lbDataReceive0.Text);
                    int valuex;
                        for (int i = 0; i < 3; i++)
                        {
                            int.TryParse(textEdit.Substring(i + 1, 1), out valuex);
                            if (valuex == 1)
                            {
                                btnList1[i].BackColor = colorList[i];
                                btnList1x[i].BackColor = colorList[i];
                            }
                            else
                            {
                                btnList1[i].BackColor = Color.White;
                                btnList1x[i].BackColor = Color.White;
                            }
                        }                 
                }
                else if (text.Contains("Y"))
                {
                    string textEdit = text;
                    lbDataReceive0.Text = "Ydata: " + text;
                    Console.WriteLine(lbDataReceive0.Text);
                    int valuex;
                        for (int i = 0; i < 3; i++)
                        {
                            int.TryParse(textEdit.Substring(i + 1, 1), out valuex);
                            if (valuex == 1)
                            {
                                btnList2[i].BackColor = colorList[i];
                                btnList2x[i].BackColor = colorList[i];
                            }
                            else
                            {
                                btnList2[i].BackColor = Color.White;
                                btnList2x[i].BackColor = Color.White;
                            }
                        }                    
                }
                else if (text.Contains("W"))
                {
                    if (text=="W0")
                    {
                        btnOFF.BackColor = Color.Green;
                        btn_Sang.BackColor = Color.White;
                        btn_Toi.BackColor = Color.White;
                    }
                    else if (text == "W1")
                    {
                        btnOFF.BackColor = Color.White;
                        btn_Sang.BackColor = Color.Green;
                        btn_Toi.BackColor = Color.White;
                    }
                    else if (text == "W2")
                    {
                        btnOFF.BackColor = Color.White;
                        btn_Sang.BackColor = Color.White;
                        btn_Toi.BackColor = Color.Green;
                    }
                }
                else
                {
                    lbDataReceive1.Text = "Data2: " + text;
                }

            }
        }
        
        public string replaceforNumber(string textreplace)      //Thay dấu chấm thành phẩy cho số thập phân
        {
            //return textreplace.Replace(txtRepalce1.Text, txtReplace2.Text);
            return textreplace.Replace(",", ".");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                btnKetNoi.Text = "Ngắt kết nối";
                lbConnectionState.Text = "Connected";
                lbConnectionState.ForeColor = Color.Green;
                cbxComList.Enabled = false;
                //pnlControl.Enabled = true;
            }
            else
            {
                btnKetNoi.Text = "Kết nối";
                lbConnectionState.Text = "Disonnected";
                lbConnectionState.ForeColor = Color.Red;
                cbxComList.Enabled = true;
                //pnlControl.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("haha");
        }


        public void getPortNameFn()
        {
            Console.WriteLine("getPortName nhe");
            if (SerialPort.GetPortNames().Length > 0)
            {
                cbxComList.DataSource = SerialPort.GetPortNames();
                btnKetNoi.Enabled = true;
            }
            else
            {
                btnKetNoi.Enabled = false;
            }

        }

        private void cbxComList_DropDown(object sender, EventArgs e)
        {
            getPortNameFn();
        }

        private void lbTest_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("M0");
        }

        private void btn_Sang_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("M1");
        }

        private void btn_Toi_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("M2");
        }

    }
}
