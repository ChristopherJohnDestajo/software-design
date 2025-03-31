namespace lab2_Task_3_B
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
            btn_Calculate_Exponent = new Button();
            txtBaseInput = new TextBox();
            txtExponentInput = new TextBox();
            lblPowerResult = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Calculate_Exponent
            // 
            btn_Calculate_Exponent.Location = new Point(62, 228);
            btn_Calculate_Exponent.Name = "btn_Calculate_Exponent";
            btn_Calculate_Exponent.Size = new Size(233, 59);
            btn_Calculate_Exponent.TabIndex = 0;
            btn_Calculate_Exponent.Text = "Solve";
            btn_Calculate_Exponent.UseVisualStyleBackColor = true;
            btn_Calculate_Exponent.Click += btn_Calculate_Exponent_Click;
            // 
            // txtBaseInput
            // 
            txtBaseInput.Location = new Point(62, 84);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(321, 27);
            txtBaseInput.TabIndex = 1;
            // 
            // txtExponentInput
            // 
            txtExponentInput.Location = new Point(62, 158);
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.Size = new Size(321, 27);
            txtExponentInput.TabIndex = 2;
            // 
            // lblPowerResult
            // 
            lblPowerResult.BorderStyle = BorderStyle.Fixed3D;
            lblPowerResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPowerResult.Location = new Point(62, 309);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(335, 75);
            lblPowerResult.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblPowerResult);
            panel1.Controls.Add(txtExponentInput);
            panel1.Controls.Add(txtBaseInput);
            panel1.Controls.Add(btn_Calculate_Exponent);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 456);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 128);
            panel2.Location = new Point(546, 277);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 176);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 128);
            panel3.Location = new Point(546, 303);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 147);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 255, 128);
            panel4.Location = new Point(546, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(254, 147);
            panel4.TabIndex = 6;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(552, 180);
            label1.Name = "label1";
            label1.Size = new Size(245, 107);
            label1.TabIndex = 7;
            label1.Text = "Exponential Calculator";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(62, 58);
            label2.Name = "label2";
            label2.Size = new Size(192, 23);
            label2.TabIndex = 6;
            label2.Text = "Base";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(62, 131);
            label3.Name = "label3";
            label3.Size = new Size(192, 24);
            label3.TabIndex = 7;
            label3.Text = "Exponent";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Calculate_Exponent;
        private TextBox txtBaseInput;
        private TextBox txtExponentInput;
        protected Label lblPowerResult;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Label label2;
    }
}
