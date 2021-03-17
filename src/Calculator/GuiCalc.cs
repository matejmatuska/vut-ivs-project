using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVS_GUI
{
    public partial class GuiKalk : Form
    {
        private int[] Number;

        private string integer;
        private string current;
        private string history;

        
        public class MathProb
        {
            private List<int> numbers = new List<int>();
            private List<char> operations = new List<char>();
            private ushort[] indOp;
            private List<MathProb> undeProbs =  new List<MathProb>();
            private int Index = 0;

            public MathProb()
            {
                numbers.Add(0);
            }

            public void intAppend (char op, string number)
            {
                this.numbers.Add(int.Parse(number));
                this.operations.Add(op);
            }

            public void probAppend(MathProb prob)
            {
                prob.Index = numbers.Count;
                undeProbs.Append(prob);
            }

            public List<int> getNumbers()
            {
                return numbers;
            }

            public List<char> getOps()
            {
                return operations;
            }

            public List<MathProb> getUnderProb()
            {
                return undeProbs;
            }
            
        }

        private MathProb prob = new MathProb();
        
        public GuiKalk() : base()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            current += "1";
            integer += "1";
            textBoxCurrent.Text = current;

        }

        void button2_Click(object sender, EventArgs e)
        {
            current += "2";
            integer += "2";
            textBoxCurrent.Text = current;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            current += "3";
            integer += "3";
            textBoxCurrent.Text = current;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            current += "4";
            integer += "4";
            textBoxCurrent.Text = current;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            current += "5";
            integer += "5";
            textBoxCurrent.Text = current;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            current += "6";
            integer += "6";
            textBoxCurrent.Text = current;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            current += "7";
            integer += "7";
            textBoxCurrent.Text = current;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            current += "8";
            integer += "8";
            textBoxCurrent.Text = current;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            current += "9";
            integer += "9";
            textBoxCurrent.Text = current;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            current += "0";
            integer += "0";
            textBoxCurrent.Text = current;
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            current += "+";
            prob.intAppend('+', integer);
            textBoxCurrent.Text = current;
            integer = "";
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            current += "-";
            prob.intAppend('-', integer);
            textBoxCurrent.Text = current;
            integer = "";
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            current += "*";
            prob.intAppend('*', integer);
            textBoxCurrent.Text = current;
            integer = "";
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            current += "/";
            prob.intAppend('/', integer);
            textBoxCurrent.Text = current;
            integer = "";
        }

        private void buttondot_Click(object sender, EventArgs e)
        {
            current += ".";
            textBoxCurrent.Text = current;
        }

        private void buttonend_Click(object sender, EventArgs e)
        {
            history = Environment.NewLine + current;
            textBoxHistory.AppendText(history);
            current = "";
            textBoxCurrent.Text = current;
            textBoxCurrent.SelectionStart = textBoxCurrent.Text.Length;
            
            //TODO poslat do process layeru
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
                case Keys.D0:
                    button0_Click(sender, EventArgs.Empty);
                    break;
                case Keys.D1:
                    button1_Click(sender, EventArgs.Empty);
                    break;
                case Keys.D2:
                    button2_Click(sender, EventArgs.Empty);
                    break;
                case Keys.D3:
                    button3_Click(sender, EventArgs.Empty);
                    break;
                case Keys.D4:
                    button4_Click(sender, EventArgs.Empty);
                    break;
                case Keys.D5:
                    button5_Click(sender, EventArgs.Empty);
                    break;
                case Keys.D6:
                    button6_Click(sender, EventArgs.Empty);
                    break;
                case Keys.D7:
                    button7_Click(sender, EventArgs.Empty);
                    break;
                case Keys.D8:
                    button8_Click(sender, EventArgs.Empty);
                    break;
                case Keys.D9:
                    button9_Click(sender, EventArgs.Empty);
                    break;
                case Keys.Add:
                    buttonadd_Click(sender, EventArgs.Empty);
                    break;
                case Keys.Back:
                    buttonsub_Click(sender, EventArgs.Empty);
                    break;
                case Keys.Divide:
                    buttondiv_Click(sender, EventArgs.Empty);
                    break;
                case Keys.Multiply:
                    buttonmul_Click(sender, EventArgs.Empty);
                    break;
                case Keys.Oemplus:
                    if (e.Shift)
                        buttonend_Click(sender, EventArgs.Empty);
                    break;
            }
        }


        private void buttonrb_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
