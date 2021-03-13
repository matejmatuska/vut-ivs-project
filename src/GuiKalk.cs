using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVS_GUI
{
    public partial class GuiKalk : Form
    {
        private int[] Number;

        private int integer;
        private string current;
        public GuiKalk() : base()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            current += "1";
            textBoxCurrent.Text = current;

        }

        void button2_Click(object sender, EventArgs e)
        {
            current += "2";
            textBoxCurrent.Text = current;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            current += "3";
            textBoxCurrent.Text = current;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            current += "4";
            textBoxCurrent.Text = current;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            current += "5";
            textBoxCurrent.Text = current;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            current += "6";
            textBoxCurrent.Text = current;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            current += "7";
            textBoxCurrent.Text = current;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            current += "8";
            textBoxCurrent.Text = current;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            current += "9";
            textBoxCurrent.Text = current;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            current += "0";
            textBoxCurrent.Text = current;
        }






        private void GuiKalk_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    button0_Click(sender, EventArgs.Empty); 
                    break;
                case Keys.NumPad1:
                    button1_Click(sender, EventArgs.Empty);
                    break;
                case Keys.NumPad2:
                    button2_Click(sender, EventArgs.Empty);
                    break;
                case Keys.NumPad3:
                    button3_Click(sender, EventArgs.Empty);
                    break;
                case Keys.NumPad4:
                    button4_Click(sender, EventArgs.Empty);
                    break;
                case Keys.NumPad5:
                    button5_Click(sender, EventArgs.Empty);
                    break;
                case Keys.NumPad6:
                    button6_Click(sender, EventArgs.Empty);
                    break;
                case Keys.NumPad7:
                    button7_Click(sender, EventArgs.Empty);
                    break;
                case Keys.NumPad8:
                    button8_Click(sender, EventArgs.Empty);
                    break;
                case Keys.NumPad9:
                    button9_Click(sender, EventArgs.Empty);
                    break;
            }
        }
    }
}
