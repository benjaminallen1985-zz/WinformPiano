using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Runtime.InteropServices;

namespace KeyboardPiano
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int time);
        public Form1()
        {
            InitializeComponent();
        }

        public enum sounds
        {
            C = 131, CS = 137, D = 147, DS = 156, E = 165, F = 175, FS = 185, G = 196, GS = 208, 
            A = 220, AS = 233, B = 247, C2 = 262, CS2 = 277, D2 = 294, DS2 = 311, E2 = 330, 
            F2 = 349, FS2 = 370, G2 = 392, GS2 = 415, A2 = 440, AS2 = 466, B2 = 494, C3 = 523,
            CS3 = 554, D3 = 587, DS3 = 622, E3 = 659, F3 = 699, FS3 = 740, G3 = 784, GS3 = 831, 
            A3 = 880, AS3 = 932, B3 = 988

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case '1': Beep((int)sounds.C, 150); this.statusStrip1.Items[0].Text = "C";
                    break;
                case '2':
                    Beep((int)sounds.CS, 150); this.statusStrip1.Items[0].Text = "CS";
                    break;
                case '3':
                    Beep((int)sounds.D, 150); this.statusStrip1.Items[0].Text = "D";
                    break;
                case '4':
                    Beep((int)sounds.DS, 150); this.statusStrip1.Items[0].Text = "DS";
                    break;
                case '5':
                    Beep((int)sounds.E, 150); this.statusStrip1.Items[0].Text = "E";
                    break;
                case '6':
                    Beep((int)sounds.F, 150); this.statusStrip1.Items[0].Text = "F";
                    break;
                case '7':
                    Beep((int)sounds.FS, 150); this.statusStrip1.Items[0].Text = "FS";
                    break;
                case '8':
                    Beep((int)sounds.G, 150); this.statusStrip1.Items[0].Text = "G";
                    break;
                case '9':
                    Beep((int)sounds.GS, 150); this.statusStrip1.Items[0].Text = "GS";
                    break;
                case '0':
                    Beep((int)sounds.A, 150); this.statusStrip1.Items[0].Text = "A";
                    break;
                case '-':
                    Beep((int)sounds.AS, 150); this.statusStrip1.Items[0].Text = "AS";
                    break;
                case '=':
                    Beep((int)sounds.B, 150); this.statusStrip1.Items[0].Text = "B";
                    break;
                case 'q':
                    Beep((int)sounds.C2, 150); this.statusStrip1.Items[0].Text = "C2";
                    break;
                case 'w':
                    Beep((int)sounds.CS2, 150); this.statusStrip1.Items[0].Text = "CS2";
                    break;
                case 'e':
                    Beep((int)sounds.D2, 150); this.statusStrip1.Items[0].Text = "D2";
                    break;
                case 'r':
                    Beep((int)sounds.DS2, 150); this.statusStrip1.Items[0].Text = "DS2";
                    break;
                case 't':
                    Beep((int)sounds.E2, 150); this.statusStrip1.Items[0].Text = "E2";
                    break;
                case 'y':
                    Beep((int)sounds.F2, 150); this.statusStrip1.Items[0].Text = "F2";
                    break;
                case 'u':
                    Beep((int)sounds.FS2, 150); this.statusStrip1.Items[0].Text = "FS2";
                    break;
                case 'i':
                    Beep((int)sounds.G2, 150); this.statusStrip1.Items[0].Text = "G2";
                    break;
                case 'o':
                    Beep((int)sounds.GS2, 150); this.statusStrip1.Items[0].Text = "GS2";
                    break;
                case 'p':
                    Beep((int)sounds.A2, 150); this.statusStrip1.Items[0].Text = "A2";
                    break;
                case '[':
                    Beep((int)sounds.AS2, 150); this.statusStrip1.Items[0].Text = "AS2";
                    break;
                case ']':
                    Beep((int)sounds.B2, 150); this.statusStrip1.Items[0].Text = "B2";
                    break;
                case 'a':
                    Beep((int)sounds.C3, 150); this.statusStrip1.Items[0].Text = "C3";
                    break;
                case 's':
                    Beep((int)sounds.CS3, 150); this.statusStrip1.Items[0].Text = "CS3";
                    break;
                case 'd':
                    Beep((int)sounds.D3, 150); this.statusStrip1.Items[0].Text = "D3";
                    break;
                case 'f':
                    Beep((int)sounds.DS3, 150); this.statusStrip1.Items[0].Text = "DS3";
                    break;
                case 'g':
                    Beep((int)sounds.E3, 150); this.statusStrip1.Items[0].Text = "E3";
                    break;
                case 'h':
                    Beep((int)sounds.F3, 150); this.statusStrip1.Items[0].Text = "F3";
                    break;
                case 'j':
                    Beep((int)sounds.FS3, 150); this.statusStrip1.Items[0].Text = "FS3";
                    break;
                case 'k':
                    Beep((int)sounds.G3, 150); this.statusStrip1.Items[0].Text = "G3";
                    break;
                case 'l':
                    Beep((int)sounds.GS3, 150); this.statusStrip1.Items[0].Text = "GS3";
                    break;
                case ';':
                    Beep((int)sounds.A3, 150); this.statusStrip1.Items[0].Text = "A3";
                    break;
                case '\'':
                    Beep((int)sounds.AS3, 150); this.statusStrip1.Items[0].Text = "AS3";
                    break;
                case '/':
                    Beep((int)sounds.B3, 150); this.statusStrip1.Items[0].Text = "B3";
                    break;
                
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void ClickButtons(object sender, EventArgs e)
        {
            string name = ((Button)sender).Text;
            switch (name)
            {
                case "C":
                    Beep((int)sounds.C, 150); this.statusStrip1.Items[0].Text = "C";
                    break;
                case "CS":
                    Beep((int)sounds.CS, 150); this.statusStrip1.Items[0].Text = "CS";
                    break;
                case "D":
                    Beep((int)sounds.D, 150); this.statusStrip1.Items[0].Text = "D";
                    break;
                case "DS":
                    Beep((int)sounds.DS, 150); this.statusStrip1.Items[0].Text = "DS";
                    break;
                case "E":
                    Beep((int)sounds.E, 150); this.statusStrip1.Items[0].Text = "E";
                    break;
                case "F":
                    Beep((int)sounds.F, 150); this.statusStrip1.Items[0].Text = "F";
                    break;
                case "FS":
                    Beep((int)sounds.FS, 150); this.statusStrip1.Items[0].Text = "FS";
                    break;
                case "G":
                    Beep((int)sounds.G, 150); this.statusStrip1.Items[0].Text = "G";
                    break;
                case "GS":
                    Beep((int)sounds.GS, 150); this.statusStrip1.Items[0].Text = "GS";
                    break;
                case "A":
                    Beep((int)sounds.A, 150); this.statusStrip1.Items[0].Text = "A";
                    break;
                case "AS":
                    Beep((int)sounds.AS, 150); this.statusStrip1.Items[0].Text = "AS";
                    break;
                case "B":
                    Beep((int)sounds.B, 150); this.statusStrip1.Items[0].Text = "B";
                    break;
                case "C2":
                    Beep((int)sounds.C2, 150); this.statusStrip1.Items[0].Text = "C2";
                    break;
                case "CS2":
                    Beep((int)sounds.CS2, 150); this.statusStrip1.Items[0].Text = "CS2";
                    break;
                case "D2":
                    Beep((int)sounds.D2, 150); this.statusStrip1.Items[0].Text = "D2";
                    break;
                case "DS2":
                    Beep((int)sounds.DS2, 150); this.statusStrip1.Items[0].Text = "DS2";
                    break;
                case "E2":
                    Beep((int)sounds.E2, 150); this.statusStrip1.Items[0].Text = "E2";
                    break;
                case "F2":
                    Beep((int)sounds.F2, 150); this.statusStrip1.Items[0].Text = "F2";
                    break;
                case "FS2":
                    Beep((int)sounds.FS2, 150); this.statusStrip1.Items[0].Text = "FS2";
                    break;
                case "G2":
                    Beep((int)sounds.G2, 150); this.statusStrip1.Items[0].Text = "G2";
                    break;
                case "GS2":
                    Beep((int)sounds.GS2, 150); this.statusStrip1.Items[0].Text = "GS2";
                    break;
                case "A2":
                    Beep((int)sounds.A2, 150); this.statusStrip1.Items[0].Text = "A2";
                    break;
                case "AS2":
                    Beep((int)sounds.AS2, 150); this.statusStrip1.Items[0].Text = "AS2";
                    break;
                case "B2":
                    Beep((int)sounds.B2, 150); this.statusStrip1.Items[0].Text = "B2";
                    break;
                case "C3":
                    Beep((int)sounds.C3, 150); this.statusStrip1.Items[0].Text = "C3";
                    break;
                case "CS3":
                    Beep((int)sounds.CS3, 150); this.statusStrip1.Items[0].Text = "CS3";
                    break;
                case "D3":
                    Beep((int)sounds.D3, 150); this.statusStrip1.Items[0].Text = "D3";
                    break;
                case "DS3":
                    Beep((int)sounds.DS3, 150); this.statusStrip1.Items[0].Text = "DS3";
                    break;
                case "E3":
                    Beep((int)sounds.E3, 150); this.statusStrip1.Items[0].Text = "E3";
                    break;
                case "F3":
                    Beep((int)sounds.F3, 150); this.statusStrip1.Items[0].Text = "F3";
                    break;
                case "FS3":
                    Beep((int)sounds.FS3, 150); this.statusStrip1.Items[0].Text = "FS3";
                    break;
                case "G3":
                    Beep((int)sounds.G3, 150); this.statusStrip1.Items[0].Text = "G3";
                    break;
                case "GS3":
                    Beep((int)sounds.GS3, 150); this.statusStrip1.Items[0].Text = "GS3";
                    break;
                case "A3":
                    Beep((int)sounds.A3, 150); this.statusStrip1.Items[0].Text = "A3";
                    break;
                case "AS3":
                    Beep((int)sounds.AS3, 150); this.statusStrip1.Items[0].Text = "AS3";
                    break;
                case "B3":
                    Beep((int)sounds.B3, 150); this.statusStrip1.Items[0].Text = "B3";
                    break;
            }
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dialog.Color;
            }
        }
    }
}
