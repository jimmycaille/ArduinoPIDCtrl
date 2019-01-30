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
                    enableControls(true);
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

        private void enableControls(bool enable) {
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
        }
        private void Form1_Close(object sender, EventArgs e) {
            continueSerialThread = false;
        }

    }
}
