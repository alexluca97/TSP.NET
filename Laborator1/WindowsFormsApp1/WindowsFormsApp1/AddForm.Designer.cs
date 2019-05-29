namespace WindowsFormsApp1
{
    partial class AddForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.FirstNameTb = new System.Windows.Forms.TextBox();
            this.LastNameTb = new System.Windows.Forms.TextBox();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.AgeTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.AddPersonBtn = new System.Windows.Forms.Button();
            this.ReadFileRTB = new System.Windows.Forms.RichTextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Age";
            // 
            // FirstNameTb
            // 
            this.FirstNameTb.Location = new System.Drawing.Point(111, 13);
            this.FirstNameTb.Name = "FirstNameTb";
            this.FirstNameTb.Size = new System.Drawing.Size(127, 20);
            this.FirstNameTb.TabIndex = 4;
            // 
            // LastNameTb
            // 
            this.LastNameTb.Location = new System.Drawing.Point(111, 42);
            this.LastNameTb.Name = "LastNameTb";
            this.LastNameTb.Size = new System.Drawing.Size(127, 20);
            this.LastNameTb.TabIndex = 5;
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(111, 104);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(127, 20);
            this.PhoneTb.TabIndex = 7;
            // 
            // AgeTb
            // 
            this.AgeTb.Location = new System.Drawing.Point(111, 75);
            this.AgeTb.Name = "AgeTb";
            this.AgeTb.Size = new System.Drawing.Size(127, 20);
            this.AgeTb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // EmailTb
            // 
            this.EmailTb.Location = new System.Drawing.Point(111, 139);
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.Size = new System.Drawing.Size(127, 20);
            this.EmailTb.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender";
            // 
            // GenderCb
            // 
            this.GenderCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCb.Location = new System.Drawing.Point(111, 172);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(127, 21);
            this.GenderCb.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(111, 206);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(127, 63);
            this.AddressTb.TabIndex = 13;
            // 
            // AddPersonBtn
            // 
            this.AddPersonBtn.Location = new System.Drawing.Point(100, 275);
            this.AddPersonBtn.Name = "AddPersonBtn";
            this.AddPersonBtn.Size = new System.Drawing.Size(67, 23);
            this.AddPersonBtn.TabIndex = 14;
            this.AddPersonBtn.Text = "Save";
            this.AddPersonBtn.UseVisualStyleBackColor = true;
            this.AddPersonBtn.Click += new System.EventHandler(this.AddPersonBtn_Click);
            // 
            // ReadFileRTB
            // 
            this.ReadFileRTB.Location = new System.Drawing.Point(288, 13);
            this.ReadFileRTB.Name = "ReadFileRTB";
            this.ReadFileRTB.Size = new System.Drawing.Size(420, 256);
            this.ReadFileRTB.TabIndex = 15;
            this.ReadFileRTB.Text = "";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(182, 276);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(72, 23);
            this.BackBtn.TabIndex = 16;
            this.BackBtn.Text = "Main Menu";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 313);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ReadFileRTB);
            this.Controls.Add(this.AddPersonBtn);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmailTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.AgeTb);
            this.Controls.Add(this.LastNameTb);
            this.Controls.Add(this.FirstNameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "Submit Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FirstNameTb;
        private System.Windows.Forms.TextBox LastNameTb;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.TextBox AgeTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.Button AddPersonBtn;
        private System.Windows.Forms.RichTextBox ReadFileRTB;
        private System.Windows.Forms.Button BackBtn;
    }
}

