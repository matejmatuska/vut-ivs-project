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
using Calc;

namespace IVS_GUI
{
    public partial class GuiKalk : Form
    {
        private Evaluator eval = new Evaluator();
        private int[] Number;

        private string integer;
        private string current;
        private string result;
        private string history;
        private MathProb subProb;

        /**
         * MathProb
         * Numbers is a list containing numbers given by user. First number is 0 
         * Operations is a list containing ops given by user. Every operation is for number with index i+1 in numbers
         * UndeProbs is a List of MathProbs. It contains another problems contained in main problem.
         * (Brackets or operations that require own solution)
         * <methodsname="MathProb"> intAppend(char op, string number) Increase list of numbers and operands
         *          probAppend(MathProb prob) Adds underProblem to main problem
         */
        public class MathProb
        {
            private List<int> numbers = new List<int>();
            private List<char> operations = new List<char>();
            private List<MathProb> undeProbs = new List<MathProb>();
            private int Index = 0;
            public string SpecOps = null;


            public MathProb()
            {
                numbers.Add(0);
            }

            public void intAppend(char op, string number)
            {
                this.numbers.Add(int.Parse(number));
                this.operations.Add(op);
            }

            public void probAppend(MathProb prob)
            {
                prob.Index = numbers.Count;
                undeProbs.Add(prob);
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

        /*
         * EventHandler methods for Clicking on buttons
         * Adds string of number to "current" and "integer"
         * Updates Current text in GUI
         */
        private void button1_Click(object sender, EventArgs e)
        {
            current += "1";
            integer += "1";
            textBoxCurrent.Text = integer;
            textBoxFormula.Text = current;
        }

        void button2_Click(object sender, EventArgs e)
        {
            current += "2";
            integer += "2";
            textBoxCurrent.Text = integer;
            textBoxFormula.Text = current;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            current += "3";
            integer += "3";
            textBoxCurrent.Text = integer;
            textBoxFormula.Text = current;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            current += "4";
            integer += "4";
            textBoxCurrent.Text = integer;
            textBoxFormula.Text = current;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            current += "5";
            integer += "5";
            textBoxCurrent.Text = integer;
            textBoxFormula.Text = current;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            current += "6";
            integer += "6";
            textBoxCurrent.Text = integer;
            textBoxFormula.Text = current;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            current += "7";
            integer += "7";
            textBoxCurrent.Text = integer;
            textBoxFormula.Text = current;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            current += "8";
            integer += "8";
            textBoxCurrent.Text = integer;
            textBoxFormula.Text = current;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            current += "9";
            integer += "9";
            textBoxCurrent.Text = integer;
            textBoxFormula.Text = current;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            current += "0";
            integer += "0";
            textBoxCurrent.Text = integer;
            textBoxFormula.Text = current;
        }
        

        private void buttonadd_Click(object sender, EventArgs e)
        {
            current += "+";
            textBoxFormula.Text = current;
            textBoxCurrent.Text = integer;

            eval.Append(integer);
            eval.Append(Operator.Sum);

            integer = "";
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            current += "-";
            textBoxFormula.Text = current;
            textBoxCurrent.Text = integer;
            
            eval.Append(integer);
            eval.Append(Operator.Sub);
            integer = "";
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            current += "*";
            textBoxFormula.Text = current;
            textBoxCurrent.Text = integer;
            
            eval.Append(integer);
            eval.Append(Operator.Mul);
            integer = "";
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            current += "/";
            textBoxFormula.Text = current;
            textBoxCurrent.Text = integer;
            
            eval.Append(integer);
            eval.Append(Operator.Div);
            integer = "";
        }
        
        private void buttonexp_Click(object sender, EventArgs e)
        {
            current += "^";
            textBoxFormula.Text = current;
            textBoxCurrent.Text = integer;
            
            eval.Append(integer);
            eval.Append(Operator.Pow);
            integer = "";
        }

        private void buttonsqr_Click(object sender, EventArgs e)
        {
            current += "√";
            textBoxFormula.Text = current;
            textBoxCurrent.Text = integer;
            
            eval.Append(integer);
            eval.Append(Operator.Root);
            integer = "";
        }

        private void buttondot_Click(object sender, EventArgs e)
        {
            current += ",";
            integer += ",";
            textBoxCurrent.Text = current;
        }

        private void buttonend_Click(object sender, EventArgs e)
        {
            eval.Append(integer);
            integer = eval.Eval().ToString(CultureInfo.InvariantCulture);
            textBoxCurrent.Text = integer;
            
            history = Environment.NewLine + current + " = " + integer;
            textBoxHistory.AppendText(history);
            
            textBoxCurrent.SelectionStart = textBoxCurrent.Text.Length;
            textBoxFormula.Text = "";
            current = "";
            integer = "";
            eval.Reset();
            
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
                case Keys.Subtract:
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
                case Keys.Back:
                    buttonDelete_Click(sender, EventArgs.Empty);
                    break;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            eval.Reset();
            current = "";
            integer = "";
            textBoxCurrent.Text = integer;
            textBoxFormula.Text = current;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(integer.Length == 0)
                return;
            
            current = current.Remove(current.Length - 1);
            integer = integer.Remove(integer.Length - 1);
            textBoxCurrent.Text = integer;
            textBoxFormula.Text = current;
        }


    }
}