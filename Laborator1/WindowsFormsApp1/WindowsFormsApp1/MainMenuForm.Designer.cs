namespace WindowsFormsApp1
{
    partial class MainMenuForm
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
            this.AddFormBtn = new System.Windows.Forms.Button();
            this.ModifyFormBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // AddFormBtn
            // 
            this.AddFormBtn.Location = new System.Drawing.Point(40, 138);
            this.AddFormBtn.Name = "AddFormBtn";
            this.AddFormBtn.Size = new System.Drawing.Size(75, 23);
            this.AddFormBtn.TabIndex = 1;
            this.AddFormBtn.Text = "New Person";
            this.AddFormBtn.UseVisualStyleBackColor = true;
            this.AddFormBtn.Click += new System.EventHandler(this.AddFormBtn_Click);
            // 
            // ModifyFormBtn
            // 
            this.ModifyFormBtn.Location = new System.Drawing.Point(181, 137);
            this.ModifyFormBtn.Name = "ModifyFormBtn";
            this.ModifyFormBtn.Size = new System.Drawing.Size(75, 23);
            this.ModifyFormBtn.TabIndex = 2;
            this.ModifyFormBtn.Text = "Modify";
            this.ModifyFormBtn.UseVisualStyleBackColor = true;
            this.ModifyFormBtn.Click += new System.EventHandler(this.ModifyFormBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(325, 137);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 260);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ModifyFormBtn);
            this.Controls.Add(this.AddFormBtn);
            this.Controls.Add(this.label1);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddFormBtn;
        private System.Windows.Forms.Button ModifyFormBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}