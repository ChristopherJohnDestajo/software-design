namespace lab2_Task_3_A
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Calculate_nth = new Button();
            FibonacciInput = new TextBox();
            lblFibonacciResult = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Calculate_nth
            // 
            btn_Calculate_nth.Location = new Point(256, 212);
            btn_Calculate_nth.Name = "btn_Calculate_nth";
            btn_Calculate_nth.Size = new Size(243, 76);
            btn_Calculate_nth.TabIndex = 0;
            btn_Calculate_nth.Text = "Answer";
            btn_Calculate_nth.UseVisualStyleBackColor = true;
            btn_Calculate_nth.Click += btn_Calculate_nth_Click;
            // 
            // FibonacciInput
            // 
            FibonacciInput.Location = new Point(232, 161);
            FibonacciInput.Name = "FibonacciInput";
            FibonacciInput.Size = new Size(304, 27);
            FibonacciInput.TabIndex = 1;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.BorderStyle = BorderStyle.FixedSingle;
            lblFibonacciResult.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFibonacciResult.Location = new Point(256, 313);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(243, 32);
            lblFibonacciResult.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblFibonacciResult);
            panel1.Controls.Add(FibonacciInput);
            panel1.Controls.Add(btn_Calculate_nth);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 454);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 104);
            label1.Name = "label1";
            label1.Size = new Size(514, 45);
            label1.TabIndex = 3;
            label1.Text = "Enter nth of the Fibonacci Sequence";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Calculate_nth;
        private TextBox FibonacciInput;
        private Label lblFibonacciResult;
        private Panel panel1;
        private Label label1;
    }
}
