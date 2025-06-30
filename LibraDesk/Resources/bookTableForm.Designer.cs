namespace LibraDesk.Resources
{
    partial class bookTableForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.booksTable = new System.Windows.Forms.DataGridView();
            this.genreToolBox = new System.Windows.Forms.ComboBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AvailabilityTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1114, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "+ Add a Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // booksTable
            // 
            this.booksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksTable.Location = new System.Drawing.Point(238, 203);
            this.booksTable.Name = "booksTable";
            this.booksTable.RowHeadersWidth = 62;
            this.booksTable.RowTemplate.Height = 28;
            this.booksTable.Size = new System.Drawing.Size(1058, 329);
            this.booksTable.TabIndex = 28;
            this.booksTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksTable_CellContentClick);
            // 
            // genreToolBox
            // 
            this.genreToolBox.FormattingEnabled = true;
            this.genreToolBox.Items.AddRange(new object[] {
            "ALL",
            "English",
            "Urdu"});
            this.genreToolBox.Location = new System.Drawing.Point(238, 164);
            this.genreToolBox.Name = "genreToolBox";
            this.genreToolBox.Size = new System.Drawing.Size(197, 28);
            this.genreToolBox.TabIndex = 29;
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreTextBox.Location = new System.Drawing.Point(238, 132);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(197, 26);
            this.GenreTextBox.TabIndex = 30;
            this.GenreTextBox.Text = "Genre";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorTextBox.Location = new System.Drawing.Point(652, 132);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(210, 26);
            this.AuthorTextBox.TabIndex = 32;
            this.AuthorTextBox.Text = "Author";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(652, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 26);
            this.textBox1.TabIndex = 33;
            // 
            // AvailabilityTextBox
            // 
            this.AvailabilityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailabilityTextBox.Location = new System.Drawing.Point(1053, 132);
            this.AvailabilityTextBox.Name = "AvailabilityTextBox";
            this.AvailabilityTextBox.Size = new System.Drawing.Size(208, 26);
            this.AvailabilityTextBox.TabIndex = 34;
            this.AvailabilityTextBox.Text = "Availability";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "by Title",
            "by author name"});
            this.comboBox1.Location = new System.Drawing.Point(1053, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 28);
            this.comboBox1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(604, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 36;
            this.label1.Text = "Books";
            // 
            // bookTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AvailabilityTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.genreToolBox);
            this.Controls.Add(this.booksTable);
            this.Controls.Add(this.button1);
            this.Name = "bookTableForm";
            this.Text = "bookTableForm";
            this.Load += new System.EventHandler(this.bookTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private System.Windows.Forms.DataGridView booksTable;
        private System.Windows.Forms.ComboBox genreToolBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox AvailabilityTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}