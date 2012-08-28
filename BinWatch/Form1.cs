using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BinWatch {
    public partial class MainForm : Form {
        private Array LEDS = Array.CreateInstance(typeof(BinWatch.LED), 6, 4);
        private String style = "green";
        private Point mousePoint;
        private int ledHeight = 10;
        private int ledWidth = 10;
    
        public MainForm() {
            int spcX = 6;
            int spcY = 6;

            for (int i = 0; i < 6; i++) {
                for(int j = 0; j < 4; j++) {
                    LEDS.SetValue(new LED((spcX + ledWidth) * i, (spcY + ledHeight) * j,ledWidth,ledHeight,spcX,spcY), i, j);
                }
            }
            InitializeComponent();
        }

        public void drawLED(LED objLED, Image imgLED) {
            using (Graphics g = pnlForm.CreateGraphics()) {
                int id = objLED.ID;
                if(id != 1 && id != 2 && id != 9 && id != 17)
                    g.DrawImage(imgLED,
                        (float)(objLED.PosX+objLED.SpcX),
                        (float)(objLED.PosY+objLED.SpcY),
                        objLED.Width,
                        objLED.Height);
            } 
        }

        public string toBin(int dec) {
            int i = 0;
            string bin = "";
            while (dec > 0) {
                i = dec % 2;
                dec = dec / 2;
                bin = i.ToString() + bin;
            }
            return bin;
        }

        public string charLFill(char c, int strLen, string str) {
            for (int i = str.Length; i < strLen; i++) {
                str = c + str;
            }
            return str;
        }

        private void timerTime_Tick(object sender, EventArgs e) {
            string time = Convert.ToString(DateTime.Now.ToLongTimeString()).Replace(":", "");

            for(int i = 0;i < 6;i++){
                string t = charLFill('0', 4, toBin(int.Parse(time[i].ToString())));
                for(int j = 0;j < 4;j++) {
                    drawLED(LEDS.GetValue(i, j) as LED,
                        imgList.Images[(t[j] == '1') ? style : "off"]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Size.Width;

            timerTime.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void greenDefaultToolStripMenuItem_Click(object sender, EventArgs e) {
            style = "green";
            menuStyleBlue.Checked = false;
            menuStyleRed.Checked = false;
            menuStyleGreen.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e) {
            style = "red";
            menuStyleBlue.Checked = false;
            menuStyleRed.Checked = true;
            menuStyleGreen.Checked = false;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e) {
            style = "blue";
            menuStyleBlue.Checked = true;
            menuStyleRed.Checked = false;
            menuStyleGreen.Checked = false;
        }

        private void pnlForm_MouseDown(object sender, MouseEventArgs e) {
            mousePoint = e.Location;
        }

        private void pnlForm_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                this.Left = this.Left + e.X - mousePoint.X;
                this.Top = this.Top + e.Y - mousePoint.Y;
            }
        }
    }
}