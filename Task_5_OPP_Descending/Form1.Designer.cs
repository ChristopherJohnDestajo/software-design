namespace Task_5_OPP_Descending
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
            btn_Sort = new Button();
            listBoxResult = new ListBox();
            SuspendLayout();
            // 
            // btn_Sort
            // 
            btn_Sort.Location = new Point(41, 65);
            btn_Sort.Name = "btn_Sort";
            btn_Sort.Size = new Size(220, 61);
            btn_Sort.TabIndex = 0;
            btn_Sort.Text = "Sort";
            btn_Sort.UseVisualStyleBackColor = true;
            btn_Sort.Click += btn_Sort_Click;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.Location = new Point(279, 65);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(509, 324);
            listBoxResult.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResult);
            Controls.Add(btn_Sort);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Sort;
        private ListBox listBoxResult;
    }
}
