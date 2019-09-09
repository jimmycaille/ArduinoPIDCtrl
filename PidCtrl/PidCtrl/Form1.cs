using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PidCtrl {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            String output = txtOutSet.Text + " " + txtOutP.Text + " " + txtOutI.Text + " " + txtOutD.Text + " " + txtOutSampleT.Text ;
            Console.WriteLine(output);
            
            if (connected) {
                port.Write(output);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            txtOutSet.Text = trackBar1.Value.ToString();
        }
        
        bool connected = false;
        double pid_div = 10.0;
        int port_timeout = 2000;
        SerialPort port;
        Thread serialThread;
        bool firstConnect = true;
        bool continueSerialThread = true;

        private void trackBar2_Scroll(object sender, EventArgs e) {
            txtOutP.Text = (trackBar2.Value/pid_div).ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e) {
            txtOutI.Text = (trackBar3.Value / pid_div).ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e) {
            txtOutD.Text = (trackBar4.Value / pid_div).ToString();
        }

        private void trackBar5_Scroll(object sender, EventArgs e) {
            txtOutSampleT.Text = trackBar5.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            chart1.Series["Setpoint"].Points.Clear();
            chart1.Series["Input"].Points.Clear();
            chart1.Series["Output"].Points.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e) {
            if (!connected) {
                port = new SerialPort(comboPort.Text, Int32.Parse(comboBaudrate.Text));
                port.ReadTimeout = port_timeout;
                try {
                    port.Open();
                    connected = true;
                    btnConnect.Text = "Disconnect";
                    //enable controls
                    enableControls();
                    //start thread
                    firstConnect = true;
                    serialThread = new Thread(new ThreadStart(serialThreadFct));
                    continueSerialThread = true;
                    serialThread.Start();
                } catch {
                    //get ports
                    string[] ports = SerialPort.GetPortNames();
                    //empty list and add them to the list
                    this.comboPort.Items.Clear();
                    for (int i = 0; i < ports.Length; i++) {
                        comboPort.Items.Add(ports[i]);
                    }
                    //if there is items
                    if (comboPort.Items.Count > 0) {
                        //select first
                        comboPort.SelectedIndex = 0;
                    }
                }
            } else {
                continueSerialThread = false;
                port.Close();
                connected = false;
                btnConnect.Text = "Connect";
                //disable controls
                enableControls(false);
            }
        }

        private void enableControls(bool enable=true) {
            comboPort.Enabled = !enable;
            comboBaudrate.Enabled = !enable;

            button1.Enabled = enable;
            button2.Enabled = enable;

            txtOutSet.Enabled = enable;
            txtOutP.Enabled = enable;
            txtOutI.Enabled = enable;
            txtOutD.Enabled = enable;
            txtOutSampleT.Enabled = enable;

            trackBar1.Enabled = enable;
            trackBar2.Enabled = enable;
            trackBar3.Enabled = enable;
            trackBar4.Enabled = enable;
            trackBar5.Enabled = enable;
        }

        private void serialThreadFct() {
            while (continueSerialThread) {
                try {
                    String input = port.ReadLine();
                    String[] split = input.Split(' ');

                    if (split.Length == 7) {
                        //update ui
                        this.Invoke((MethodInvoker)delegate {
                            //boxes
                            txtInSet.Text = split[0];
                            txtInput.Text = split[1];
                            txtOutput.Text = split[2];
                            txtInP.Text = split[3];
                            txtInI.Text = split[4];
                            txtInD.Text = split[5];
                            txtInSampleT.Text = split[6];
                            if (firstConnect) {
                                firstConnect = false;
                                txtOutSet.Text = split[0];
                                trackBar1.Value = Int32.Parse(split[0]);

                                txtOutP.Text = split[3];
                                trackBar2.Value = (int)(double.Parse(split[3])*10);


                                txtOutI.Text = split[4];
                                trackBar3.Value = (int)(double.Parse(split[4]) * 10);


                                txtOutD.Text = split[5];
                                trackBar4.Value = (int)(double.Parse(split[5]) * 10);
                                
                                txtOutSampleT.Text = split[6];
                                trackBar5.Value = Int32.Parse(split[6]);
                            }
                            //chart
                            chart1.Series["Setpoint"].Points.AddY(split[0]);
                            chart1.Series["Input"].Points.AddY(split[1]);
                            chart1.Series["Output"].Points.AddY(split[2]);
                        });
                    }
                } catch {
                    //timeout
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            chart1.ChartAreas[0].AxisY.Maximum = 256;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Interval = 32;


            chart2.ChartAreas[0].AxisY.Maximum = 1024;
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Interval = 128;
        }
        private void Form1_Close(object sender, EventArgs e) {
            continueSerialThread = false;
            continueSerialThread2 = false;
        }


        //######################################################################### PANEL 2 #########################################################################

        bool connected2 = false;
        bool firstConnect2 = true;
        bool[] showSeries = new bool[8] {true, true, true, true, true, true, true, true};
        SerialPort port2;
        Thread serialThread2;
        bool continueSerialThread2 = true;
        private void btnConnect2_Click(object sender, EventArgs e) {
            if (!connected2) {
                port2 = new SerialPort(comboPort2.Text, Int32.Parse(comboBaudrate.Text));
                port2.ReadTimeout = port_timeout;
                try {
                    port2.Open();
                    connected2 = true;
                    btnConnect2.Text = "Disconnect";
                    //enable controls
                    enableControls2();
                    //start thread
                    firstConnect2 = true;
                    serialThread2 = new Thread(new ThreadStart(serialThreadFct2));
                    continueSerialThread2 = true;
                    serialThread2.Start();
                } catch {
                    //get ports
                    string[] ports = SerialPort.GetPortNames();
                    //empty list and add them to the list
                    this.comboPort2.Items.Clear();
                    for (int i = 0; i < ports.Length; i++) {
                        comboPort2.Items.Add(ports[i]);
                    }
                    //if there is items
                    if (comboPort2.Items.Count > 0) {
                        //select first
                        comboPort2.SelectedIndex = 0;
                    }
                }
            } else {
                continueSerialThread2 = false;
                port2.Close();
                connected2 = false;
                btnConnect2.Text = "Connect";
                //disable controls
                enableControls2(false);
            }
        }
        private void serialThreadFct2() {
            while (continueSerialThread2) {
                try {
                    String input = port2.ReadLine();
                    String[] split = input.Split(' ');

                    if (split.Length == 9) {
                        //update ui
                        this.Invoke((MethodInvoker)delegate {
                            //boxes
                            txtVal0.Text = split[0];
                            txtVal1.Text = split[1];
                            txtVal2.Text = split[2];
                            txtVal2.Text = split[3];
                            txtVal3.Text = split[4];
                            txtVal5.Text = split[5];
                            txtVal6.Text = split[6];
                            txtVal7.Text = split[7];
                            txtInSampleT2.Text = split[8];
                            if (firstConnect2) {
                                firstConnect2 = false;

                                txtOutSampleT2.Text = split[8];
                                trackBar5_2.Value = Int32.Parse(split[8]);
                            }
                            //chart
                            chart2.Series["val0"].Points.AddY(split[0]);
                            chart2.Series["val1"].Points.AddY(split[1]);
                            chart2.Series["val2"].Points.AddY(split[2]);
                            chart2.Series["val3"].Points.AddY(split[3]);
                            chart2.Series["val4"].Points.AddY(split[4]);
                            chart2.Series["val5"].Points.AddY(split[5]);
                            chart2.Series["val6"].Points.AddY(split[6]);
                            chart2.Series["val7"].Points.AddY(split[7]);
                        });
                    }
                } catch {
                    //timeout
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            chart2.Series["val0"].Points.Clear();
            chart2.Series["val1"].Points.Clear();
            chart2.Series["val2"].Points.Clear();
            chart2.Series["val3"].Points.Clear();
            chart2.Series["val4"].Points.Clear();
            chart2.Series["val5"].Points.Clear();
            chart2.Series["val6"].Points.Clear();
            chart2.Series["val7"].Points.Clear();
        }
        private void enableControls2(bool enable=true) {
            comboPort2.Enabled = !enable;
            comboBaudrate2.Enabled = !enable;

            button1_2.Enabled = enable;
            button2_2.Enabled = enable;

            txtOutSampleT2.Enabled = enable;
            
            trackBar5_2.Enabled = enable;
        }

        private void button1_2_Click(object sender, EventArgs e) {
            String output = txtOutSampleT2.Text;
            Console.WriteLine(output);

            if (connected2) {
                port2.Write(output);
            }
        }

        private void trackBar5_2_Scroll(object sender, EventArgs e) {
            txtOutSampleT2.Text = trackBar5_2.Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            showSeries[0] = checkBox1.Checked;
            chart2.Series["val0"].Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            showSeries[1] = checkBox1.Checked;
            chart2.Series["val1"].Enabled = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            showSeries[2] = checkBox1.Checked;
            chart2.Series["val2"].Enabled = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) {
            showSeries[3] = checkBox1.Checked;
            chart2.Series["val3"].Enabled = checkBox4.Checked;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e) {
            showSeries[4] = checkBox1.Checked;
            chart2.Series["val4"].Enabled = checkBox8.Checked;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e) {
            showSeries[5] = checkBox1.Checked;
            chart2.Series["val5"].Enabled = checkBox7.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e) {
            showSeries[6] = checkBox1.Checked;
            chart2.Series["val6"].Enabled = checkBox6.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e) {
            showSeries[7] = checkBox1.Checked;
            chart2.Series["val7"].Enabled = checkBox5.Checked;
        }
    }
}
