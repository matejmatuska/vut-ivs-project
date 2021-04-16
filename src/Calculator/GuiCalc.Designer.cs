
using System.ComponentModel;
using System.Security.AccessControl;

namespace Calc
{
    partial class GuiKalk
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuiKalk));
            this.Outcome = new System.Windows.Forms.Label();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonsub = new System.Windows.Forms.Button();
            this.buttondiv = new System.Windows.Forms.Button();
            this.buttonmul = new System.Windows.Forms.Button();
            this.buttondot = new System.Windows.Forms.Button();
            this.buttonend = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxCurrent = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.textBoxHistory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxFormula = new System.Windows.Forms.TextBox();
            this.buttonmod = new System.Windows.Forms.Button();
            this.buttonsqr = new System.Windows.Forms.Button();
            this.button_sqr2 = new System.Windows.Forms.Button();
            this.buttonexp = new System.Windows.Forms.Button();
            this.buttonexp2 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonlb = new System.Windows.Forms.Button();
            this.buttonFact = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Outcome
            // 
            this.Outcome.AutoSize = true;
            this.Outcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.Outcome.Location = new System.Drawing.Point(549, 72);
            this.Outcome.Name = "Outcome";
            this.Outcome.Size = new System.Drawing.Size(0, 32);
            this.Outcome.TabIndex = 18;
            this.Outcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonadd
            // 
            this.buttonadd.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonadd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonadd.Location = new System.Drawing.Point(420, 468);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(134, 42);
            this.buttonadd.TabIndex = 10;
            this.buttonadd.Text = "+";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonsub
            // 
            this.buttonsub.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonsub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonsub.Location = new System.Drawing.Point(420, 420);
            this.buttonsub.Name = "buttonsub";
            this.buttonsub.Size = new System.Drawing.Size(134, 42);
            this.buttonsub.TabIndex = 11;
            this.buttonsub.Text = "-";
            this.buttonsub.UseVisualStyleBackColor = false;
            this.buttonsub.Click += new System.EventHandler(this.buttonsub_Click);
            // 
            // buttondiv
            // 
            this.buttondiv.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttondiv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttondiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttondiv.Location = new System.Drawing.Point(420, 324);
            this.buttondiv.Name = "buttondiv";
            this.buttondiv.Size = new System.Drawing.Size(134, 42);
            this.buttondiv.TabIndex = 12;
            this.buttondiv.Text = "/";
            this.buttondiv.UseVisualStyleBackColor = false;
            this.buttondiv.Click += new System.EventHandler(this.buttondiv_Click);
            // 
            // buttonmul
            // 
            this.buttonmul.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonmul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonmul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonmul.Location = new System.Drawing.Point(420, 372);
            this.buttonmul.Name = "buttonmul";
            this.buttonmul.Size = new System.Drawing.Size(134, 42);
            this.buttonmul.TabIndex = 13;
            this.buttonmul.Text = "*";
            this.buttonmul.UseVisualStyleBackColor = false;
            this.buttonmul.Click += new System.EventHandler(this.buttonmul_Click);
            // 
            // buttondot
            // 
            this.buttondot.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttondot.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttondot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondot.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttondot.Location = new System.Drawing.Point(3, 516);
            this.buttondot.Name = "buttondot";
            this.buttondot.Size = new System.Drawing.Size(133, 45);
            this.buttondot.TabIndex = 14;
            this.buttondot.Text = ".";
            this.buttondot.UseVisualStyleBackColor = false;
            this.buttondot.Click += new System.EventHandler(this.buttondot_Click);
            // 
            // buttonend
            // 
            this.buttonend.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonend.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonend.Location = new System.Drawing.Point(420, 516);
            this.buttonend.Name = "buttonend";
            this.buttonend.Size = new System.Drawing.Size(134, 45);
            this.buttonend.TabIndex = 15;
            this.buttonend.Text = "=";
            this.buttonend.UseVisualStyleBackColor = false;
            this.buttonend.Click += new System.EventHandler(this.buttonend_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.button7.Location = new System.Drawing.Point(3, 468);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 42);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.button5.Location = new System.Drawing.Point(142, 420);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.button6.Location = new System.Drawing.Point(281, 420);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 42);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.button2.Location = new System.Drawing.Point(142, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.button8.Location = new System.Drawing.Point(142, 468);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 42);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.button4.Location = new System.Drawing.Point(3, 420);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.button3.Location = new System.Drawing.Point(281, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxCurrent
            // 
            this.textBoxCurrent.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxCurrent, 4);
            this.textBoxCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxCurrent.Location = new System.Drawing.Point(3, 197);
            this.textBoxCurrent.Name = "textBoxCurrent";
            this.textBoxCurrent.ReadOnly = true;
            this.textBoxCurrent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCurrent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCurrent.Size = new System.Drawing.Size(551, 39);
            this.textBoxCurrent.TabIndex = 16;
            this.textBoxCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.button9.Location = new System.Drawing.Point(281, 468);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 42);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBoxHistory
            // 
            this.textBoxHistory.AcceptsReturn = true;
            this.textBoxHistory.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHistory.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxHistory, 4);
            this.textBoxHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxHistory.Location = new System.Drawing.Point(3, 3);
            this.textBoxHistory.Multiline = true;
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.ReadOnly = true;
            this.textBoxHistory.Size = new System.Drawing.Size(551, 107);
            this.textBoxHistory.TabIndex = 17;
            this.textBoxHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(3, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button0
            // 
            this.button0.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button0.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.button0.Location = new System.Drawing.Point(142, 516);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(133, 45);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxFormula, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHistory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCurrent, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.button0, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.buttonmod, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonsqr, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_sqr2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonexp, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonexp2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttondot, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.buttondiv, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonmul, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonsub, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonadd, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonend, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.buttonReset, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonFact, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.49646F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.28588F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.94753F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.894832F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.894832F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.894832F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.894832F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.894832F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.89799F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.89799F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(557, 564);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // textBoxFormula
            // 
            this.textBoxFormula.AcceptsReturn = true;
            this.textBoxFormula.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFormula.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxFormula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxFormula, 4);
            this.textBoxFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxFormula.Location = new System.Drawing.Point(3, 116);
            this.textBoxFormula.Multiline = true;
            this.textBoxFormula.Name = "textBoxFormula";
            this.textBoxFormula.ReadOnly = true;
            this.textBoxFormula.Size = new System.Drawing.Size(551, 75);
            this.textBoxFormula.TabIndex = 25;
            this.textBoxFormula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonmod
            // 
            this.buttonmod.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonmod.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (128)))));
            this.buttonmod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonmod.Location = new System.Drawing.Point(281, 324);
            this.buttonmod.Name = "buttonmod";
            this.buttonmod.Size = new System.Drawing.Size(133, 42);
            this.buttonmod.TabIndex = 28;
            this.buttonmod.Text = "mod";
            this.buttonmod.UseVisualStyleBackColor = false;
            this.buttonmod.Click += new System.EventHandler(this.buttonmod_Click);
            // 
            // buttonsqr
            // 
            this.buttonsqr.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsqr.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (128)))));
            this.buttonsqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonsqr.Location = new System.Drawing.Point(3, 324);
            this.buttonsqr.Name = "buttonsqr";
            this.buttonsqr.Size = new System.Drawing.Size(133, 42);
            this.buttonsqr.TabIndex = 24;
            this.buttonsqr.Text = "√";
            this.buttonsqr.UseVisualStyleBackColor = false;
            this.buttonsqr.Click += new System.EventHandler(this.buttonsqr_Click);
            // 
            // button_sqr2
            // 
            this.button_sqr2.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sqr2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (128)))));
            this.button_sqr2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sqr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.button_sqr2.Location = new System.Drawing.Point(3, 276);
            this.button_sqr2.Name = "button_sqr2";
            this.button_sqr2.Size = new System.Drawing.Size(133, 42);
            this.button_sqr2.TabIndex = 26;
            this.button_sqr2.Text = "2√";
            this.button_sqr2.UseVisualStyleBackColor = false;
            this.button_sqr2.Click += new System.EventHandler(this.button_sqr2_Click);
            // 
            // buttonexp
            // 
            this.buttonexp.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonexp.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (128)))));
            this.buttonexp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonexp.Location = new System.Drawing.Point(142, 324);
            this.buttonexp.Name = "buttonexp";
            this.buttonexp.Size = new System.Drawing.Size(133, 42);
            this.buttonexp.TabIndex = 23;
            this.buttonexp.Text = "^n";
            this.buttonexp.UseVisualStyleBackColor = false;
            this.buttonexp.Click += new System.EventHandler(this.buttonexp_Click);
            // 
            // buttonexp2
            // 
            this.buttonexp2.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonexp2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (128)))));
            this.buttonexp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonexp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonexp2.Location = new System.Drawing.Point(142, 276);
            this.buttonexp2.Name = "buttonexp2";
            this.buttonexp2.Size = new System.Drawing.Size(133, 42);
            this.buttonexp2.TabIndex = 27;
            this.buttonexp2.Text = "^2";
            this.buttonexp2.UseVisualStyleBackColor = false;
            this.buttonexp2.Click += new System.EventHandler(this.buttonexp2_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonReset.Location = new System.Drawing.Point(420, 276);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(134, 42);
            this.buttonReset.TabIndex = 21;
            this.buttonReset.Text = "CE";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonDelete.Location = new System.Drawing.Point(281, 516);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDelete.Size = new System.Drawing.Size(133, 45);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "←";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonlb
            // 
            this.buttonlb.Location = new System.Drawing.Point(0, 0);
            this.buttonlb.Name = "buttonlb";
            this.buttonlb.Size = new System.Drawing.Size(75, 23);
            this.buttonlb.TabIndex = 0;
            // 
            // buttonFact
            // 
            this.buttonFact.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFact.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (128)))));
            this.buttonFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonFact.Location = new System.Drawing.Point(281, 276);
            this.buttonFact.Name = "buttonFact";
            this.buttonFact.Size = new System.Drawing.Size(133, 42);
            this.buttonFact.TabIndex = 29;
            this.buttonFact.Text = "Fact !";
            this.buttonFact.UseVisualStyleBackColor = false;
            this.buttonFact.Click += new System.EventHandler(this.buttonFact_Click);
            // 
            // GuiKalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(574, 586);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Outcome);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "GuiKalk";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GuiKalk_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonFact;

        private System.Windows.Forms.Button buttonmod;

        private System.Windows.Forms.Button buttonexp2;

        private System.Windows.Forms.Button button_sqr2;

        private System.Windows.Forms.TextBox textBoxFormula;

        private System.Windows.Forms.Button buttonsqr;

        private System.Windows.Forms.Button buttonexp;


        private System.Windows.Forms.Button buttonDelete;

        private System.Windows.Forms.Button buttonlb;

        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttondiv;
        private System.Windows.Forms.Button buttondot;
        private System.Windows.Forms.Button buttonend;
        private System.Windows.Forms.Button buttonmul;
        private System.Windows.Forms.Button buttonsub;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxCurrent;
        private System.Windows.Forms.TextBox textBoxHistory;

        #endregion

        public System.Windows.Forms.Label Outcome;
    }
}

