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
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(699, 39);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(36, 255);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(202, 255);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(372, 255);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(36, 167);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(202, 167);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(372, 167);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(36, 85);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(202, 85);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(372, 85);
            button9.Name = "button9";
            button9.Size = new Size(112, 34);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(558, 167);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(112, 34);
            buttonMultiply.TabIndex = 10;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(558, 85);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(112, 34);
            buttonDivide.TabIndex = 11;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Location = new Point(558, 255);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(112, 34);
            buttonSubtract.TabIndex = 12;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Location = new Point(36, 342);
            button0.Name = "button0";
            button0.Size = new Size(112, 34);
            button0.TabIndex = 13;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(202, 342);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(112, 34);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(372, 342);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(112, 34);
            buttonEquals.TabIndex = 15;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(558, 342);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 34);
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(723, 450);
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