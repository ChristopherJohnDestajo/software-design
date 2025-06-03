namespace lab6
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
            ListBoxBooks = new ListBox();
            btnAddBook = new Button();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnUpdateBook = new Button();
            btnDeletebook = new Button();
            btnDisplaybook = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // ListBoxBooks
            // 
            ListBoxBooks.FormattingEnabled = true;
            ListBoxBooks.Location = new Point(317, 39);
            ListBoxBooks.Name = "ListBoxBooks";
            ListBoxBooks.Size = new Size(417, 284);
            ListBoxBooks.TabIndex = 0;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(53, 39);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(210, 44);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "add book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(44, 320);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(219, 27);
            txtAuthorName.TabIndex = 2;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(44, 373);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(219, 27);
            txtBookTitle.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 297);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 350);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Book Title";
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(53, 89);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(210, 44);
            btnUpdateBook.TabIndex = 6;
            btnUpdateBook.Text = "update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeletebook
            // 
            btnDeletebook.Location = new Point(53, 139);
            btnDeletebook.Name = "btnDeletebook";
            btnDeletebook.Size = new Size(210, 44);
            btnDeletebook.TabIndex = 7;
            btnDeletebook.Text = "delete Book";
            btnDeletebook.UseVisualStyleBackColor = true;
            btnDeletebook.Click += btnDeletebook_Click;
            // 
            // btnDisplaybook
            // 
            btnDisplaybook.Location = new Point(53, 189);
            btnDisplaybook.Name = "btnDisplaybook";
            btnDisplaybook.Size = new Size(210, 44);
            btnDisplaybook.TabIndex = 8;
            btnDisplaybook.Text = "display Book";
            btnDisplaybook.UseVisualStyleBackColor = true;
            btnDisplaybook.Click += btnDisplaybook_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(327, 341);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(408, 33);
            progressBar1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(btnDisplaybook);
            Controls.Add(btnDeletebook);
            Controls.Add(btnUpdateBook);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(btnAddBook);
            Controls.Add(ListBoxBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBoxBooks;
        private Button btnAddBook;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Label label1;
        private Label label2;
        private Button btnUpdateBook;
        private Button btnDeletebook;
        private Button btnDisplaybook;
        private ProgressBar progressBar1;
    }
}
