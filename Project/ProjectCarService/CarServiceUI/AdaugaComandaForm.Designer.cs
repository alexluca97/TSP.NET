namespace CarServiceUI
{
    partial class AdaugaComandaForm
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
            this.dataProgramareTp = new System.Windows.Forms.DateTimePicker();
            this.DataProgramariiLabel = new System.Windows.Forms.Label();
            this.DescriereLabel = new System.Windows.Forms.Label();
            this.descriereTtb = new System.Windows.Forms.RichTextBox();
            this.kmBordLabel = new System.Windows.Forms.Label();
            this.kmBordTb = new System.Windows.Forms.TextBox();
            this.AdaugaComandaBtn = new System.Windows.Forms.Button();
            this.AdaugaDetaliiBtn = new System.Windows.Forms.Button();
            this.anuleazaComandaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataProgramareTp
            // 
            this.dataProgramareTp.CustomFormat = "yyyy-MM-dd";
            this.dataProgramareTp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataProgramareTp.Location = new System.Drawing.Point(174, 37);
            this.dataProgramareTp.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dataProgramareTp.MinDate = new System.DateTime(2019, 3, 28, 0, 0, 0, 0);
            this.dataProgramareTp.Name = "dataProgramareTp";
            this.dataProgramareTp.Size = new System.Drawing.Size(88, 20);
            this.dataProgramareTp.TabIndex = 0;
            this.dataProgramareTp.Value = new System.DateTime(2019, 3, 28, 0, 0, 0, 0);
            // 
            // DataProgramariiLabel
            // 
            this.DataProgramariiLabel.AutoSize = true;
            this.DataProgramariiLabel.Location = new System.Drawing.Point(24, 37);
            this.DataProgramariiLabel.Name = "DataProgramariiLabel";
            this.DataProgramariiLabel.Size = new System.Drawing.Size(85, 13);
            this.DataProgramariiLabel.TabIndex = 1;
            this.DataProgramariiLabel.Text = "Data Programarii";
            // 
            // DescriereLabel
            // 
            this.DescriereLabel.AutoSize = true;
            this.DescriereLabel.Location = new System.Drawing.Point(27, 87);
            this.DescriereLabel.Name = "DescriereLabel";
            this.DescriereLabel.Size = new System.Drawing.Size(52, 13);
            this.DescriereLabel.TabIndex = 2;
            this.DescriereLabel.Text = "Descriere";
            // 
            // descriereTtb
            // 
            this.descriereTtb.Location = new System.Drawing.Point(149, 87);
            this.descriereTtb.Name = "descriereTtb";
            this.descriereTtb.Size = new System.Drawing.Size(403, 116);
            this.descriereTtb.TabIndex = 3;
            this.descriereTtb.Text = "";
            // 
            // kmBordLabel
            // 
            this.kmBordLabel.AutoSize = true;
            this.kmBordLabel.Location = new System.Drawing.Point(27, 248);
            this.kmBordLabel.Name = "kmBordLabel";
            this.kmBordLabel.Size = new System.Drawing.Size(58, 13);
            this.kmBordLabel.TabIndex = 4;
            this.kmBordLabel.Text = "Km in Bord";
            this.kmBordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kmBordTb
            // 
            this.kmBordTb.Location = new System.Drawing.Point(149, 241);
            this.kmBordTb.Name = "kmBordTb";
            this.kmBordTb.Size = new System.Drawing.Size(123, 20);
            this.kmBordTb.TabIndex = 5;
            // 
            // AdaugaComandaBtn
            // 
            this.AdaugaComandaBtn.Location = new System.Drawing.Point(12, 315);
            this.AdaugaComandaBtn.Name = "AdaugaComandaBtn";
            this.AdaugaComandaBtn.Size = new System.Drawing.Size(167, 42);
            this.AdaugaComandaBtn.TabIndex = 6;
            this.AdaugaComandaBtn.Text = "Adauga Comanda";
            this.AdaugaComandaBtn.UseVisualStyleBackColor = true;
            this.AdaugaComandaBtn.Click += new System.EventHandler(this.AdaugaComandaBtn_Click);
            // 
            // AdaugaDetaliiBtn
            // 
            this.AdaugaDetaliiBtn.Location = new System.Drawing.Point(205, 315);
            this.AdaugaDetaliiBtn.Name = "AdaugaDetaliiBtn";
            this.AdaugaDetaliiBtn.Size = new System.Drawing.Size(167, 42);
            this.AdaugaDetaliiBtn.TabIndex = 8;
            this.AdaugaDetaliiBtn.Text = "Adauga Detalii";
            this.AdaugaDetaliiBtn.UseVisualStyleBackColor = true;
            this.AdaugaDetaliiBtn.Click += new System.EventHandler(this.AdaugaDetaliiBtn_Click);
            // 
            // anuleazaComandaBtn
            // 
            this.anuleazaComandaBtn.Location = new System.Drawing.Point(402, 315);
            this.anuleazaComandaBtn.Name = "anuleazaComandaBtn";
            this.anuleazaComandaBtn.Size = new System.Drawing.Size(167, 42);
            this.anuleazaComandaBtn.TabIndex = 9;
            this.anuleazaComandaBtn.Text = "Anuleaza Comanda";
            this.anuleazaComandaBtn.UseVisualStyleBackColor = true;
            this.anuleazaComandaBtn.Click += new System.EventHandler(this.anuleazaComandaBtn_Click);
            // 
            // AdaugaComandaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 393);
            this.Controls.Add(this.anuleazaComandaBtn);
            this.Controls.Add(this.AdaugaDetaliiBtn);
            this.Controls.Add(this.AdaugaComandaBtn);
            this.Controls.Add(this.kmBordTb);
            this.Controls.Add(this.kmBordLabel);
            this.Controls.Add(this.descriereTtb);
            this.Controls.Add(this.DescriereLabel);
            this.Controls.Add(this.DataProgramariiLabel);
            this.Controls.Add(this.dataProgramareTp);
            this.Name = "AdaugaComandaForm";
            this.Text = "AdaugaComandaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataProgramareTp;
        private System.Windows.Forms.Label DataProgramariiLabel;
        private System.Windows.Forms.Label DescriereLabel;
        private System.Windows.Forms.RichTextBox descriereTtb;
        private System.Windows.Forms.Label kmBordLabel;
        private System.Windows.Forms.TextBox kmBordTb;
        private System.Windows.Forms.Button AdaugaComandaBtn;
        private System.Windows.Forms.Button AdaugaDetaliiBtn;
        private System.Windows.Forms.Button anuleazaComandaBtn;
    }
}