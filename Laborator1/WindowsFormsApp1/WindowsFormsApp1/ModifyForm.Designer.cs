namespace WindowsFormsApp1
{
    partial class ModifyForm
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.ReadFileRTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(371, 259);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Main Menu";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ReadFileRTB
            // 
            this.ReadFileRTB.Location = new System.Drawing.Point(298, 12);
            this.ReadFileRTB.Name = "ReadFileRTB";
            this.ReadFileRTB.Size = new System.Drawing.Size(205, 197);
            this.ReadFileRTB.TabIndex = 1;
            this.ReadFileRTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "What do you want to modify?";
            // 
            // ChooseCb
            // 
            this.ChooseCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseCb.FormattingEnabled = true;
            this.ChooseCb.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Age",
            "Email",
            "Phone",
            "Address",
            "Gender"});
            this.ChooseCb.Location = new System.Drawing.Point(47, 44);
            this.ChooseCb.Name = "ChooseCb";
            this.ChooseCb.Size = new System.Drawing.Size(142, 21);
            this.ChooseCb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "With what?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 5;
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.Location = new System.Drawing.Point(73, 186);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(75, 23);
            this.ModifyBtn.TabIndex = 6;
            this.ModifyBtn.Text = "Modify";
            this.ModifyBtn.UseVisualStyleBackColor = true;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 294);
            this.Controls.Add(this.ModifyBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChooseCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReadFileRTB);
            this.Controls.Add(this.BackBtn);
            this.Name = "ModifyForm";
            this.Text = "ModifyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.RichTextBox ReadFileRTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChooseCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ModifyBtn;
    }
}