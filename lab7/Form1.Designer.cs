namespace lab7
{
	partial class txtAuthorName
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
            btnNextPage = new Button();
            btnreverse = new Button();
            listBoxBooks = new ListBox();
            lblPageNumber = new Label();
            addbook = new Button();
            txtNameAuthor = new TextBox();
            txtBookTitle = new TextBox();
            btnExporter = new Button();
            AsyncSearch = new Button();
            txtSearch = new TextBox();
            Importer = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(547, 314);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(198, 69);
            btnNextPage.TabIndex = 0;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnreverse
            // 
            btnreverse.Location = new Point(316, 308);
            btnreverse.Name = "btnreverse";
            btnreverse.Size = new Size(198, 69);
            btnreverse.TabIndex = 1;
            btnreverse.Text = "Previous ";
            btnreverse.UseVisualStyleBackColor = true;
            btnreverse.Click += btnreverse_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(316, 38);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(429, 244);
            listBoxBooks.TabIndex = 2;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(357, 285);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(0, 20);
            lblPageNumber.TabIndex = 3;
            // 
            // addbook
            // 
            addbook.Location = new Point(24, 116);
            addbook.Name = "addbook";
            addbook.Size = new Size(154, 39);
            addbook.TabIndex = 4;
            addbook.Text = "Add Book";
            addbook.UseVisualStyleBackColor = true;
            addbook.Click += addbook_Click;
            // 
            // txtNameAuthor
            // 
            txtNameAuthor.Location = new Point(24, 32);
            txtNameAuthor.Name = "txtNameAuthor";
            txtNameAuthor.Size = new Size(186, 27);
            txtNameAuthor.TabIndex = 5;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(24, 83);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(186, 27);
            txtBookTitle.TabIndex = 6;
            // 
            // btnExporter
            // 
            btnExporter.Location = new Point(24, 161);
            btnExporter.Name = "btnExporter";
            btnExporter.Size = new Size(154, 45);
            btnExporter.TabIndex = 7;
            btnExporter.Text = "Export Book";
            btnExporter.UseVisualStyleBackColor = true;
            btnExporter.Click += btnExporter_Click;
            // 
            // AsyncSearch
            // 
            AsyncSearch.Location = new Point(70, 341);
            AsyncSearch.Name = "AsyncSearch";
            AsyncSearch.Size = new Size(140, 45);
            AsyncSearch.TabIndex = 8;
            AsyncSearch.Text = "Search Book";
            AsyncSearch.UseVisualStyleBackColor = true;
            AsyncSearch.Click += AsyncSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 308);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(278, 27);
            txtSearch.TabIndex = 9;
            // 
            // Importer
            // 
            Importer.Location = new Point(24, 212);
            Importer.Name = "Importer";
            Importer.Size = new Size(154, 45);
            Importer.TabIndex = 10;
            Importer.Text = "Import Book";
            Importer.UseVisualStyleBackColor = true;
            Importer.Click += Importer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 11;
            label1.Text = "Book Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 60);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 12;
            label2.Text = "Book Title";
            // 
            // txtAuthorName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Importer);
            Controls.Add(txtSearch);
            Controls.Add(AsyncSearch);
            Controls.Add(btnExporter);
            Controls.Add(txtBookTitle);
            Controls.Add(txtNameAuthor);
            Controls.Add(addbook);
            Controls.Add(lblPageNumber);
            Controls.Add(listBoxBooks);
            Controls.Add(btnreverse);
            Controls.Add(btnNextPage);
            Name = "txtAuthorName";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNextPage;
        private Button btnreverse;
        private ListBox listBoxBooks;
        private Label lblPageNumber;
        private Button addbook;
        private TextBox txtNameAuthor;
        private TextBox txtBookTitle;
        private Button btnExporter;
        private Button AsyncSearch;
        private TextBox txtSearch;
        private Button Importer;
        private Label label1;
        private Label label2;
    }
}
