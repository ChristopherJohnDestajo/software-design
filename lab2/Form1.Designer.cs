namespace lab2
{
	partial class txtInput
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
            btn_Calculate_Factorial = new Button();
            btn_Calculate_Sum = new Button();
            textinput = new TextBox();
            txtArrayInput = new TextBox();
            lblResult = new Label();
            lblSumResult = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            lblSumResults = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Calculate_Factorial
            // 
            btn_Calculate_Factorial.Location = new Point(105, 208);
            btn_Calculate_Factorial.Name = "btn_Calculate_Factorial";
            btn_Calculate_Factorial.Size = new Size(160, 53);
            btn_Calculate_Factorial.TabIndex = 0;
            btn_Calculate_Factorial.Text = "Factorial";
            btn_Calculate_Factorial.UseVisualStyleBackColor = true;
            btn_Calculate_Factorial.Click += btn_Calculate_Factorial_Click;
            // 
            // btn_Calculate_Sum
            // 
            btn_Calculate_Sum.Location = new Point(117, 201);
            btn_Calculate_Sum.Name = "btn_Calculate_Sum";
            btn_Calculate_Sum.Size = new Size(156, 57);
            btn_Calculate_Sum.TabIndex = 1;
            btn_Calculate_Sum.Text = "Sum";
            btn_Calculate_Sum.UseVisualStyleBackColor = true;
            btn_Calculate_Sum.Click += btn_Calculate_Sum_Click;
            // 
            // textinput
            // 
            textinput.Location = new Point(35, 139);
            textinput.Name = "textinput";
            textinput.Size = new Size(312, 27);
            textinput.TabIndex = 2;
            textinput.Text = " ";
            textinput.TextAlign = HorizontalAlignment.Center;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(42, 136);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(312, 27);
            txtArrayInput.TabIndex = 3;
            txtArrayInput.TextAlign = HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(0, 27);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(157, 40);
            lblResult.TabIndex = 4;
            lblResult.Click += lblResult_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.Location = new Point(130, 282);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(160, 36);
            lblSumResult.TabIndex = 5;
            // 
            // label1
            // 
            label1.Location = new Point(35, 79);
            label1.Name = "label1";
            label1.Size = new Size(312, 36);
            label1.TabIndex = 6;
            label1.Text = "Factorial Calculator";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(42, 79);
            label2.Name = "label2";
            label2.Size = new Size(312, 36);
            label2.TabIndex = 7;
            label2.Text = "Addition Using Recursion";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textinput);
            panel1.Controls.Add(btn_Calculate_Factorial);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 450);
            panel1.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblResult);
            panel4.Location = new Point(105, 282);
            panel4.Name = "panel4";
            panel4.Size = new Size(160, 96);
            panel4.TabIndex = 8;
            panel4.Paint += panel4_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 128);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblSumResult);
            panel3.Controls.Add(txtArrayInput);
            panel3.Controls.Add(btn_Calculate_Sum);
            panel3.Location = new Point(413, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(391, 450);
            panel3.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblSumResults);
            panel5.Location = new Point(117, 282);
            panel5.Name = "panel5";
            panel5.Size = new Size(156, 96);
            panel5.TabIndex = 9;
            // 
            // lblSumResults
            // 
            lblSumResults.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSumResults.Location = new Point(3, 27);
            lblSumResults.Name = "lblSumResults";
            lblSumResults.Size = new Size(150, 40);
            lblSumResults.TabIndex = 4;
            // 
            // txtInput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "txtInput";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Calculate_Factorial;
        private Button btn_Calculate_Sum;
        private TextBox textinput;
        private TextBox txtArrayInput;
        private Label lblResult;
        private Label lblSumResult;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label lblSumResults;
    }
}
