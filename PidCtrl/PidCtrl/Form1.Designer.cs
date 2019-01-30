using System;

namespace PidCtrl {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutSet = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutP = new System.Windows.Forms.TextBox();
            this.txtOutI = new System.Windows.Forms.TextBox();
            this.txtOutD = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.txtInSet = new System.Windows.Forms.TextBox();
            this.txtInP = new System.Windows.Forms.TextBox();
            this.txtInI = new System.Windows.Forms.TextBox();
            this.txtInD = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.comboBaudrate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInSampleT = new System.Windows.Forms.TextBox();
            this.txtOutSampleT = new System.Windows.Forms.TextBox();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(276, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Setpoint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output";
            // 
            // txtOutSet
            // 
            this.txtOutSet.Enabled = false;
            this.txtOutSet.Location = new System.Drawing.Point(148, 66);
            this.txtOutSet.Name = "txtOutSet";
            this.txtOutSet.Size = new System.Drawing.Size(57, 20);
            this.txtOutSet.TabIndex = 4;
            this.txtOutSet.Text = "0";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(75, 95);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(57, 20);
            this.txtInput.TabIndex = 5;
            this.txtInput.Text = "0";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(75, 127);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(57, 20);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "P";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "I";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "D";
            // 
            // txtOutP
            // 
            this.txtOutP.Enabled = false;
            this.txtOutP.Location = new System.Drawing.Point(542, 68);
            this.txtOutP.Name = "txtOutP";
            this.txtOutP.Size = new System.Drawing.Size(57, 20);
            this.txtOutP.TabIndex = 10;
            this.txtOutP.Text = "0";
            // 
            // txtOutI
            // 
            this.txtOutI.Enabled = false;
            this.txtOutI.Location = new System.Drawing.Point(542, 95);
            this.txtOutI.Name = "txtOutI";
            this.txtOutI.Size = new System.Drawing.Size(57, 20);
            this.txtOutI.TabIndex = 11;
            this.txtOutI.Text = "0";
            // 
            // txtOutD
            // 
            this.txtOutD.Enabled = false;
            this.txtOutD.Location = new System.Drawing.Point(542, 122);
            this.txtOutD.Name = "txtOutD";
            this.txtOutD.Size = new System.Drawing.Size(57, 20);
            this.txtOutD.TabIndex = 12;
            this.txtOutD.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(211, 66);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(156, 45);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.TickFrequency = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Enabled = false;
            this.trackBar2.LargeChange = 10;
            this.trackBar2.Location = new System.Drawing.Point(604, 68);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar2.Size = new System.Drawing.Size(156, 45);
            this.trackBar2.TabIndex = 14;
            this.trackBar2.TickFrequency = 5;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Enabled = false;
            this.trackBar3.LargeChange = 10;
            this.trackBar3.Location = new System.Drawing.Point(605, 95);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar3.Size = new System.Drawing.Size(156, 45);
            this.trackBar3.TabIndex = 15;
            this.trackBar3.TickFrequency = 5;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Enabled = false;
            this.trackBar4.LargeChange = 10;
            this.trackBar4.Location = new System.Drawing.Point(605, 122);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar4.Size = new System.Drawing.Size(156, 45);
            this.trackBar4.TabIndex = 16;
            this.trackBar4.TickFrequency = 5;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // txtInSet
            // 
            this.txtInSet.Location = new System.Drawing.Point(75, 66);
            this.txtInSet.Name = "txtInSet";
            this.txtInSet.ReadOnly = true;
            this.txtInSet.Size = new System.Drawing.Size(57, 20);
            this.txtInSet.TabIndex = 17;
            this.txtInSet.Text = "0";
            // 
            // txtInP
            // 
            this.txtInP.Location = new System.Drawing.Point(469, 68);
            this.txtInP.Name = "txtInP";
            this.txtInP.ReadOnly = true;
            this.txtInP.Size = new System.Drawing.Size(57, 20);
            this.txtInP.TabIndex = 18;
            this.txtInP.Text = "0";
            // 
            // txtInI
            // 
            this.txtInI.Location = new System.Drawing.Point(469, 95);
            this.txtInI.Name = "txtInI";
            this.txtInI.ReadOnly = true;
            this.txtInI.Size = new System.Drawing.Size(57, 20);
            this.txtInI.TabIndex = 19;
            this.txtInI.Text = "0";
            // 
            // txtInD
            // 
            this.txtInD.Location = new System.Drawing.Point(469, 122);
            this.txtInD.Name = "txtInD";
            this.txtInD.ReadOnly = true;
            this.txtInD.Size = new System.Drawing.Size(57, 20);
            this.txtInD.TabIndex = 20;
            this.txtInD.Text = "0";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 195);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "Setpoint";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Input";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Lime;
            series3.Legend = "Legend1";
            series3.Name = "Output";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(753, 324);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(339, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Clear graph";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(8, 8);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 23;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // comboPort
            // 
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.comboPort.Location = new System.Drawing.Point(89, 10);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(57, 21);
            this.comboPort.TabIndex = 24;
            this.comboPort.Text = "COM1";
            // 
            // comboBaudrate
            // 
            this.comboBaudrate.FormattingEnabled = true;
            this.comboBaudrate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "31250",
            "38400",
            "57600",
            "115200"});
            this.comboBaudrate.Location = new System.Drawing.Point(152, 10);
            this.comboBaudrate.Name = "comboBaudrate";
            this.comboBaudrate.Size = new System.Drawing.Size(67, 21);
            this.comboBaudrate.TabIndex = 25;
            this.comboBaudrate.Text = "9600";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "SampleTime";
            // 
            // txtInSampleT
            // 
            this.txtInSampleT.Location = new System.Drawing.Point(469, 148);
            this.txtInSampleT.Name = "txtInSampleT";
            this.txtInSampleT.ReadOnly = true;
            this.txtInSampleT.Size = new System.Drawing.Size(57, 20);
            this.txtInSampleT.TabIndex = 27;
            this.txtInSampleT.Text = "100";
            // 
            // txtOutSampleT
            // 
            this.txtOutSampleT.Enabled = false;
            this.txtOutSampleT.Location = new System.Drawing.Point(542, 148);
            this.txtOutSampleT.Name = "txtOutSampleT";
            this.txtOutSampleT.Size = new System.Drawing.Size(57, 20);
            this.txtOutSampleT.TabIndex = 28;
            this.txtOutSampleT.Text = "100";
            // 
            // trackBar5
            // 
            this.trackBar5.Enabled = false;
            this.trackBar5.Location = new System.Drawing.Point(605, 149);
            this.trackBar5.Maximum = 500;
            this.trackBar5.Minimum = 1;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(156, 45);
            this.trackBar5.TabIndex = 29;
            this.trackBar5.TickFrequency = 25;
            this.trackBar5.Value = 1;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 528);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.txtOutSampleT);
            this.Controls.Add(this.txtInSampleT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBaudrate);
            this.Controls.Add(this.comboPort);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.txtInD);
            this.Controls.Add(this.txtInI);
            this.Controls.Add(this.txtInP);
            this.Controls.Add(this.txtInSet);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.txtOutD);
            this.Controls.Add(this.txtOutI);
            this.Controls.Add(this.txtOutP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtOutSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PidCtrl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Close);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutSet;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOutP;
        private System.Windows.Forms.TextBox txtOutI;
        private System.Windows.Forms.TextBox txtOutD;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TextBox txtInSet;
        private System.Windows.Forms.TextBox txtInP;
        private System.Windows.Forms.TextBox txtInI;
        private System.Windows.Forms.TextBox txtInD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.ComboBox comboBaudrate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInSampleT;
        private System.Windows.Forms.TextBox txtOutSampleT;
        private System.Windows.Forms.TrackBar trackBar5;
    }
}

