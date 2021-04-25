using System;
using System.Globalization;
using System.Windows.Forms;


namespace Calc
{
    public partial class GuiKalk : Form
    {
        private readonly Evaluator eval = new Evaluator();

        private string number = "";
        private string current = "";
        private string history = "";
        private bool inFromlast;

        public GuiKalk()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        /**
         * Method to change GUI textboxes and to send numbers to @see Evaluator.cs
         * @brief Takes given number and stores it in integer and current
         * @param number number which should be added
         */
        private void onNumber_Click(int number)
        {
            try
            {
                if (inFromlast)
                {
                    current = "";
                    this.number = "";
                }

                current += number.ToString();
                this.number += number.ToString();
                textBoxCurrent.Text = this.number;
                textBoxFormula.Text = current;
                inFromlast = false;
            }
            catch (Exception e)
            {
                showError("Chyba", "Bude doděláno");
                throw;
            }
        }

        private bool IsNumberEmpty()
        {
            return number.Length == 0 || number == "+" || number == "-";
        }

        private void onSign_Click(char symbol)
        {
            if (current == "")
            {
                current = symbol.ToString();
            }
            else if (number == "+" || number == "-")
            {
                current = current.Remove(current.Length - 1, 1);
                current += symbol;
            }
            else
            {
                current += symbol;
            }

            number = symbol.ToString();

            textBoxFormula.Text = current;
            textBoxCurrent.Text = number;
        }

        private void onOp_Click(char c, Operator op)
        {
            if (IsNumberEmpty())
                return;

            current += c;
            textBoxFormula.Text = current;
            textBoxCurrent.Text = number;

            eval.Append(number);
            eval.Append(op);

            number = "";
            inFromlast = false;
        }

        public void showError(string message, string title)
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /**
         * \defgroup EventHandlers
         * EventHandler methods for Clicking on buttons
         * Adds string of number to "current" and "integer"
         * Updates Current text in GUI
         * @param Sender who initiated action (not used)
         * @param Event which event was initiated (not used)
         */
        /**
         * @ingroup EventHandlers
         * @brief adds number 1 to current value
         */
        private void button1_Click(object sender, EventArgs e)
        {
            onNumber_Click(1);
        }

        /**
         * @ingroup EventHandlers
         * @brief adds number 2 to current value
         */
        private void button2_Click(object sender, EventArgs e)
        {
            onNumber_Click(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            onNumber_Click(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            onNumber_Click(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            onNumber_Click(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            onNumber_Click(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            onNumber_Click(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            onNumber_Click(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            onNumber_Click(9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            onNumber_Click(0);
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            if (IsNumberEmpty())
                onSign_Click('+');
            else
                onOp_Click('+', Operator.Sum);
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            if (IsNumberEmpty())
                onSign_Click('-');
            else
                onOp_Click('-', Operator.Sub);
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            onOp_Click('*', Operator.Mul);
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            onOp_Click('/', Operator.Div);
        }

        private void buttonexp_Click(object sender, EventArgs e)
        {
            onOp_Click('^', Operator.Pow);
        }

        private void buttonsqr_Click(object sender, EventArgs e)
        {
            onOp_Click('√', Operator.Root);
        }

        private void buttonmod_Click(object sender, EventArgs e)
        {
            onOp_Click('%', Operator.Mod);
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            onOp_Click('!', Operator.Fact);
        }

        private void button_sqr2_Click(object sender, EventArgs e)
        {
            if (!IsNumberEmpty())
            {
                onOp_Click('*', Operator.Mul);
            }

            button2_Click(sender, EventArgs.Empty);
            buttonsqr_Click(sender, EventArgs.Empty);
        }

        private void buttonexp2_Click(object sender, EventArgs e)
        {
            if (!IsNumberEmpty())
            {
                buttonexp_Click(sender, EventArgs.Empty);
                button2_Click(sender, EventArgs.Empty);
            }
        }

        private void buttondot_Click(object sender, EventArgs e)
        {
            if (inFromlast)
            {
                current = "";
                number = "";
            }

            if (number.Contains("."))
                return;

            current += ".";
            number += ".";
            textBoxCurrent.Text = current;
            inFromlast = false;
        }

        private void buttonend_Click(object sender, EventArgs e)
        {
            if (textBoxFormula.Text == "")
                return; // no-op when nothing is entered

            eval.Append(number);
            number = eval.Eval().ToString(CultureInfo.InvariantCulture);
            textBoxCurrent.Text = number;

            history = Environment.NewLine + current + " = " + number;
            textBoxHistory.AppendText(history);

            textBoxCurrent.SelectionStart = textBoxCurrent.Text.Length;
            textBoxFormula.Text = "";
            current = number;
            inFromlast = true;

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
            number = "";
            textBoxCurrent.Text = number;
            textBoxFormula.Text = current;
            inFromlast = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (number.Length == 0)
                return;

            current = current.Remove(current.Length - 1);
            number = number.Remove(number.Length - 1);
            textBoxCurrent.Text = number;
            textBoxFormula.Text = current;
        }
    }
}