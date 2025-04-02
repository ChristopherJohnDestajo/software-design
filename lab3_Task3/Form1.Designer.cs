namespace lab3_Task3
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
            btnShow_Info = new Button();
            listBoxBooks = new ListBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnShow_Info
            // 
            btnShow_Info.Location = new Point(278, 99);
            btnShow_Info.Name = "btnShow_Info";
            btnShow_Info.Size = new Size(237, 65);
            btnShow_Info.TabIndex = 0;
            btnShow_Info.Text = "Show Info";
            btnShow_Info.UseVisualStyleBackColor = true;
            btnShow_Info.Click += btnShow_Info_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(73, 216);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(662, 144);
            listBoxBooks.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(listBoxBooks);
            panel1.Controls.Add(btnShow_Info);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 461);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnShow_Info;
        private ListBox listBoxBooks;
        private Panel panel1;
    }
}
