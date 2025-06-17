namespace LibraDesk
{
    partial class SideBarControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideBarControl));
            this.dashboardButton = new System.Windows.Forms.Button();
            this.booksButton = new System.Windows.Forms.Button();
            this.membersButton = new System.Windows.Forms.Button();
            this.isuuedBooksButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dashboardButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dashboardButton.Location = new System.Drawing.Point(-20, 117);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(198, 40);
            this.dashboardButton.TabIndex = 0;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // booksButton
            // 
            this.booksButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.booksButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.booksButton.Location = new System.Drawing.Point(-20, 178);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(198, 40);
            this.booksButton.TabIndex = 2;
            this.booksButton.Text = "Books";
            this.booksButton.UseVisualStyleBackColor = false;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // membersButton
            // 
            this.membersButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.membersButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.membersButton.Location = new System.Drawing.Point(-20, 236);
            this.membersButton.Name = "membersButton";
            this.membersButton.Size = new System.Drawing.Size(198, 40);
            this.membersButton.TabIndex = 3;
            this.membersButton.Text = "Members";
            this.membersButton.UseVisualStyleBackColor = false;
            // 
            // isuuedBooksButton
            // 
            this.isuuedBooksButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.isuuedBooksButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.isuuedBooksButton.Location = new System.Drawing.Point(-20, 302);
            this.isuuedBooksButton.Name = "isuuedBooksButton";
            this.isuuedBooksButton.Size = new System.Drawing.Size(198, 40);
            this.isuuedBooksButton.TabIndex = 4;
            this.isuuedBooksButton.Text = "Issued Books";
            this.isuuedBooksButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // SideBarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.isuuedBooksButton);
            this.Controls.Add(this.membersButton);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.dashboardButton);
            this.Name = "SideBarControl";
            this.Size = new System.Drawing.Size(174, 600);
            this.Load += new System.EventHandler(this.SideBarControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button membersButton;
        private System.Windows.Forms.Button isuuedBooksButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
