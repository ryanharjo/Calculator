namespace Calculator_RyanHarjo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonSubtract = new Button();
            button0 = new Button();
            buttonClear = new Button();
            buttonEquals = new Button();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(20, 20);
            txtDisplay.Margin = new Padding(5);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(1186, 61);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(61, 418);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(190, 56);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(343, 418);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(190, 56);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(632, 418);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(190, 56);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(61, 274);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(190, 56);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(343, 274);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Size = new Size(190, 56);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(632, 274);
            button6.Margin = new Padding(5);
            button6.Name = "button6";
            button6.Size = new Size(190, 56);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(61, 139);
            button7.Margin = new Padding(5);
            button7.Name = "button7";
            button7.Size = new Size(190, 56);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(343, 139);
            button8.Margin = new Padding(5);
            button8.Name = "button8";
            button8.Size = new Size(190, 56);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(632, 139);
            button9.Margin = new Padding(5);
            button9.Name = "button9";
            button9.Size = new Size(190, 56);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(938, 274);
            buttonMultiply.Margin = new Padding(5);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(190, 56);
            buttonMultiply.TabIndex = 10;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(938, 139);
            buttonDivide.Margin = new Padding(5);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(190, 56);
            buttonDivide.TabIndex = 11;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubtract.Location = new Point(938, 418);
            buttonSubtract.Margin = new Padding(5);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(190, 56);
            buttonSubtract.TabIndex = 12;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += buttonSubtract_Click;
            // 
            // button0
            // 
            button0.Location = new Point(61, 561);
            button0.Margin = new Padding(5);
            button0.Name = "button0";
            button0.Size = new Size(190, 56);
            button0.TabIndex = 13;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(343, 561);
            buttonClear.Margin = new Padding(5);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(190, 56);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(632, 561);
            buttonEquals.Margin = new Padding(5);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(190, 56);
            buttonEquals.TabIndex = 15;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(938, 561);
            buttonAdd.Margin = new Padding(5);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(190, 56);
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(1242, 738);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEquals);
            Controls.Add(buttonClear);
            Controls.Add(button0);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDisplay);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonSubtract;
        private Button button0;
        private Button buttonClear;
        private Button buttonEquals;
        private Button buttonAdd;
    }
}