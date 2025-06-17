namespace LibraDesk
{
    partial class SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signUpEmail = new System.Windows.Forms.TextBox();
            this.signUpPassword = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.signUpName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.signUpContactNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.signUpDepartment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.signUpSemester = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(545, 39);
            this.label1.MinimumSize = new System.Drawing.Size(250, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRADESK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.signUpSemester);
            this.panel1.Controls.Add(this.signUpContactNo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.signUpDepartment);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.signUpName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.signUpButton);
            this.panel1.Controls.Add(this.signUpPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.signUpEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(91, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 419);
            this.panel1.TabIndex = 3;
            // 
            // signUpEmail
            // 
            this.signUpEmail.Location = new System.Drawing.Point(0, 211);
            this.signUpEmail.Name = "signUpEmail";
            this.signUpEmail.Size = new System.Drawing.Size(441, 26);
            this.signUpEmail.TabIndex = 4;
            // 
            // signUpPassword
            // 
            this.signUpPassword.Location = new System.Drawing.Point(0, 263);
            this.signUpPassword.Name = "signUpPassword";
            this.signUpPassword.Size = new System.Drawing.Size(441, 26);
            this.signUpPassword.TabIndex = 5;
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signUpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signUpButton.Location = new System.Drawing.Point(349, 370);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(450, 37);
            this.signUpButton.TabIndex = 6;
            this.signUpButton.Text = "SignUp";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 42);
            this.label4.MinimumSize = new System.Drawing.Size(150, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Create an Account";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signUpName
            // 
            this.signUpName.Location = new System.Drawing.Point(0, 144);
            this.signUpName.Name = "signUpName";
            this.signUpName.Size = new System.Drawing.Size(441, 26);
            this.signUpName.TabIndex = 8;
            this.signUpName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // signUpContactNo
            // 
            this.signUpContactNo.Location = new System.Drawing.Point(697, 144);
            this.signUpContactNo.Name = "signUpContactNo";
            this.signUpContactNo.Size = new System.Drawing.Size(441, 26);
            this.signUpContactNo.TabIndex = 14;
            this.signUpContactNo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contact No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(700, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Semester";
            // 
            // signUpDepartment
            // 
            this.signUpDepartment.Location = new System.Drawing.Point(697, 211);
            this.signUpDepartment.Name = "signUpDepartment";
            this.signUpDepartment.Size = new System.Drawing.Size(441, 26);
            this.signUpDepartment.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(700, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Department";
            // 
            // signUpSemester
            // 
            this.signUpSemester.FormattingEnabled = true;
            this.signUpSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.signUpSemester.Location = new System.Drawing.Point(697, 272);
            this.signUpSemester.Name = "signUpSemester";
            this.signUpSemester.Size = new System.Drawing.Size(441, 28);
            this.signUpSemester.TabIndex = 15;
            this.signUpSemester.Text = "Select";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox signUpPassword;
        private System.Windows.Forms.TextBox signUpEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox signUpName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox signUpContactNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox signUpDepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox signUpSemester;
    }
}