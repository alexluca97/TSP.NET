namespace CarServiceUI
{
    partial class AdaugaDetaliiForm
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
            this.imaginePb = new System.Windows.Forms.PictureBox();
            this.AdaugaFotoBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DescriereLabel = new System.Windows.Forms.Label();
            this.DataDetaliiTp = new System.Windows.Forms.DateTimePicker();
            this.TitluLabel = new System.Windows.Forms.Label();
            this.TitluTb = new System.Windows.Forms.TextBox();
            this.AdaugaDetaliiBtn = new System.Windows.Forms.Button();
            this.AnuleazaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imaginePb)).BeginInit();
            this.SuspendLayout();
            // 
            // imaginePb
            // 
            this.imaginePb.Location = new System.Drawing.Point(232, 77);
            this.imaginePb.Name = "imaginePb";
            this.imaginePb.Size = new System.Drawing.Size(282, 240);
            this.imaginePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imaginePb.TabIndex = 0;
            this.imaginePb.TabStop = false;
            // 
            // AdaugaFotoBtn
            // 
            this.AdaugaFotoBtn.Location = new System.Drawing.Point(77, 105);
            this.AdaugaFotoBtn.Name = "AdaugaFotoBtn";
            this.AdaugaFotoBtn.Size = new System.Drawing.Size(117, 42);
            this.AdaugaFotoBtn.TabIndex = 1;
            this.AdaugaFotoBtn.Text = "Aduga Fotografie";
            this.AdaugaFotoBtn.UseVisualStyleBackColor = true;
            this.AdaugaFotoBtn.Click += new System.EventHandler(this.AdaugaFotoBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(150, 352);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(393, 121);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // DescriereLabel
            // 
            this.DescriereLabel.AutoSize = true;
            this.DescriereLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriereLabel.Location = new System.Drawing.Point(7, 304);
            this.DescriereLabel.Name = "DescriereLabel";
            this.DescriereLabel.Size = new System.Drawing.Size(187, 25);
            this.DescriereLabel.TabIndex = 3;
            this.DescriereLabel.Text = "Descriere Fotografie";
            // 
            // DataDetaliiTp
            // 
            this.DataDetaliiTp.CustomFormat = "yyyy-MM-dd";
            this.DataDetaliiTp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataDetaliiTp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataDetaliiTp.Location = new System.Drawing.Point(12, 185);
            this.DataDetaliiTp.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.DataDetaliiTp.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DataDetaliiTp.Name = "DataDetaliiTp";
            this.DataDetaliiTp.Size = new System.Drawing.Size(200, 23);
            this.DataDetaliiTp.TabIndex = 4;
            this.DataDetaliiTp.Value = new System.DateTime(2019, 3, 28, 20, 52, 40, 0);
            // 
            // TitluLabel
            // 
            this.TitluLabel.AutoSize = true;
            this.TitluLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitluLabel.Location = new System.Drawing.Point(72, 22);
            this.TitluLabel.Name = "TitluLabel";
            this.TitluLabel.Size = new System.Drawing.Size(49, 25);
            this.TitluLabel.TabIndex = 5;
            this.TitluLabel.Text = "Titlu";
            // 
            // TitluTb
            // 
            this.TitluTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitluTb.Location = new System.Drawing.Point(232, 26);
            this.TitluTb.Name = "TitluTb";
            this.TitluTb.Size = new System.Drawing.Size(282, 30);
            this.TitluTb.TabIndex = 6;
            // 
            // AdaugaDetaliiBtn
            // 
            this.AdaugaDetaliiBtn.Location = new System.Drawing.Point(45, 555);
            this.AdaugaDetaliiBtn.Name = "AdaugaDetaliiBtn";
            this.AdaugaDetaliiBtn.Size = new System.Drawing.Size(149, 48);
            this.AdaugaDetaliiBtn.TabIndex = 7;
            this.AdaugaDetaliiBtn.Text = "Adauga Detaliile";
            this.AdaugaDetaliiBtn.UseVisualStyleBackColor = true;
            this.AdaugaDetaliiBtn.Click += new System.EventHandler(this.AdaugaDetaliiBtn_Click);
            // 
            // AnuleazaBtn
            // 
            this.AnuleazaBtn.Location = new System.Drawing.Point(309, 555);
            this.AnuleazaBtn.Name = "AnuleazaBtn";
            this.AnuleazaBtn.Size = new System.Drawing.Size(149, 48);
            this.AnuleazaBtn.TabIndex = 8;
            this.AnuleazaBtn.Text = "Anuleaza";
            this.AnuleazaBtn.UseVisualStyleBackColor = true;
            this.AnuleazaBtn.Click += new System.EventHandler(this.AnuleazaBtn_Click);
            // 
            // AdaugaDetaliiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 633);
            this.Controls.Add(this.AnuleazaBtn);
            this.Controls.Add(this.AdaugaDetaliiBtn);
            this.Controls.Add(this.TitluTb);
            this.Controls.Add(this.TitluLabel);
            this.Controls.Add(this.DataDetaliiTp);
            this.Controls.Add(this.DescriereLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.AdaugaFotoBtn);
            this.Controls.Add(this.imaginePb);
            this.Name = "AdaugaDetaliiForm";
            this.Text = "AdaugaDetalii";
            ((System.ComponentModel.ISupportInitialize)(this.imaginePb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imaginePb;
        private System.Windows.Forms.Button AdaugaFotoBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label DescriereLabel;
        private System.Windows.Forms.DateTimePicker DataDetaliiTp;
        private System.Windows.Forms.Label TitluLabel;
        private System.Windows.Forms.TextBox TitluTb;
        private System.Windows.Forms.Button AdaugaDetaliiBtn;
        private System.Windows.Forms.Button AnuleazaBtn;
    }
}