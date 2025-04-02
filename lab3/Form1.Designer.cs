namespace lab3
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
            SuspendLayout();
            // 
            // btnShow_Info
            // 
            btnShow_Info.Location = new Point(32, 61);
            btnShow_Info.Name = "btnShow_Info";
            btnShow_Info.Size = new Size(221, 53);
            btnShow_Info.TabIndex = 0;
            btnShow_Info.Text = "Show Info";
            btnShow_Info.UseVisualStyleBackColor = true;
            btnShow_Info.Click += btnShow_Info_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(299, 61);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(468, 364);
            listBoxBooks.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxBooks);
            Controls.Add(btnShow_Info);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnShow_Info;
        private ListBox listBoxBooks;
    }
}
