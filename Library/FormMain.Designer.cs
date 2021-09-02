
namespace Library
{
    partial class FormMain
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
            this.ListBooks = new System.Windows.Forms.ListBox();
            this.LabelBooks = new System.Windows.Forms.Label();
            this.LabelGenres = new System.Windows.Forms.Label();
            this.ListGenres = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListBooks
            // 
            this.ListBooks.FormattingEnabled = true;
            this.ListBooks.ItemHeight = 20;
            this.ListBooks.Location = new System.Drawing.Point(12, 34);
            this.ListBooks.Name = "ListBooks";
            this.ListBooks.Size = new System.Drawing.Size(150, 404);
            this.ListBooks.TabIndex = 5;
            // 
            // LabelBooks
            // 
            this.LabelBooks.AutoSize = true;
            this.LabelBooks.Location = new System.Drawing.Point(12, 11);
            this.LabelBooks.Name = "LabelBooks";
            this.LabelBooks.Size = new System.Drawing.Size(49, 20);
            this.LabelBooks.TabIndex = 4;
            this.LabelBooks.Text = "Books";
            // 
            // LabelGenres
            // 
            this.LabelGenres.AutoSize = true;
            this.LabelGenres.Location = new System.Drawing.Point(168, 11);
            this.LabelGenres.Name = "LabelGenres";
            this.LabelGenres.Size = new System.Drawing.Size(54, 20);
            this.LabelGenres.TabIndex = 6;
            this.LabelGenres.Text = "Genres";
            // 
            // ListGenres
            // 
            this.ListGenres.FormattingEnabled = true;
            this.ListGenres.ItemHeight = 20;
            this.ListGenres.Location = new System.Drawing.Point(168, 34);
            this.ListGenres.Name = "ListGenres";
            this.ListGenres.Size = new System.Drawing.Size(150, 404);
            this.ListGenres.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListGenres);
            this.Controls.Add(this.LabelGenres);
            this.Controls.Add(this.ListBooks);
            this.Controls.Add(this.LabelBooks);
            this.Name = "FormMain";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListBooks;
        private System.Windows.Forms.Label LabelBooks;
        private System.Windows.Forms.Label LabelGenres;
        private System.Windows.Forms.ListBox ListGenres;
    }
}

