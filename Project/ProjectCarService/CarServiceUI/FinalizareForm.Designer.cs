namespace CarServiceUI
{
    partial class FinalizareForm
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
            this.clientAsteptareLabel = new System.Windows.Forms.Label();
            this.clientiLv = new System.Windows.Forms.ListView();
            this.nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pieseLabel = new System.Windows.Forms.Label();
            this.pieseCbl = new System.Windows.Forms.CheckedListBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTb = new System.Windows.Forms.TextBox();
            this.finalizareBtn = new System.Windows.Forms.Button();
            this.inapoiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientAsteptareLabel
            // 
            this.clientAsteptareLabel.AutoSize = true;
            this.clientAsteptareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAsteptareLabel.Location = new System.Drawing.Point(92, 41);
            this.clientAsteptareLabel.Name = "clientAsteptareLabel";
            this.clientAsteptareLabel.Size = new System.Drawing.Size(239, 31);
            this.clientAsteptareLabel.TabIndex = 0;
            this.clientAsteptareLabel.Text = "Clienti in asteptare";
            // 
            // clientiLv
            // 
            this.clientiLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nume,
            this.prenume,
            this.descriere});
            this.clientiLv.Location = new System.Drawing.Point(403, 41);
            this.clientiLv.Name = "clientiLv";
            this.clientiLv.Size = new System.Drawing.Size(355, 148);
            this.clientiLv.TabIndex = 1;
            this.clientiLv.UseCompatibleStateImageBehavior = false;
            this.clientiLv.View = System.Windows.Forms.View.Details;
            this.clientiLv.SelectedIndexChanged += new System.EventHandler(this.clientiLv_SelectedIndexChanged);
            // 
            // nume
            // 
            this.nume.Text = "Nume";
            // 
            // prenume
            // 
            this.prenume.Text = "Prenume";
            this.prenume.Width = 61;
            // 
            // descriere
            // 
            this.descriere.Text = "Descriere";
            this.descriere.Width = 102;
            // 
            // pieseLabel
            // 
            this.pieseLabel.AutoSize = true;
            this.pieseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieseLabel.Location = new System.Drawing.Point(157, 237);
            this.pieseLabel.Name = "pieseLabel";
            this.pieseLabel.Size = new System.Drawing.Size(82, 31);
            this.pieseLabel.TabIndex = 2;
            this.pieseLabel.Text = "Piese";
            // 
            // pieseCbl
            // 
            this.pieseCbl.FormattingEnabled = true;
            this.pieseCbl.Location = new System.Drawing.Point(403, 223);
            this.pieseCbl.Name = "pieseCbl";
            this.pieseCbl.Size = new System.Drawing.Size(355, 154);
            this.pieseCbl.TabIndex = 3;
            this.pieseCbl.SelectedIndexChanged += new System.EventHandler(this.pieseCbl_SelectedIndexChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(287, 414);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(110, 31);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "TOTAL:";
            // 
            // totalTb
            // 
            this.totalTb.Enabled = false;
            this.totalTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTb.Location = new System.Drawing.Point(440, 407);
            this.totalTb.Name = "totalTb";
            this.totalTb.Size = new System.Drawing.Size(318, 38);
            this.totalTb.TabIndex = 5;
            // 
            // finalizareBtn
            // 
            this.finalizareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizareBtn.Location = new System.Drawing.Point(108, 472);
            this.finalizareBtn.Name = "finalizareBtn";
            this.finalizareBtn.Size = new System.Drawing.Size(131, 33);
            this.finalizareBtn.TabIndex = 6;
            this.finalizareBtn.Text = "Finalizare";
            this.finalizareBtn.UseVisualStyleBackColor = true;
            this.finalizareBtn.Click += new System.EventHandler(this.finalizareBtn_Click);
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inapoiBtn.Location = new System.Drawing.Point(424, 472);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(131, 33);
            this.inapoiBtn.TabIndex = 7;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // FinalizareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 517);
            this.Controls.Add(this.inapoiBtn);
            this.Controls.Add(this.finalizareBtn);
            this.Controls.Add(this.totalTb);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.pieseCbl);
            this.Controls.Add(this.pieseLabel);
            this.Controls.Add(this.clientiLv);
            this.Controls.Add(this.clientAsteptareLabel);
            this.Name = "FinalizareForm";
            this.Text = "Finalizare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientAsteptareLabel;
        private System.Windows.Forms.ListView clientiLv;
        private System.Windows.Forms.ColumnHeader nume;
        private System.Windows.Forms.ColumnHeader prenume;
        private System.Windows.Forms.ColumnHeader descriere;
        private System.Windows.Forms.Label pieseLabel;
        private System.Windows.Forms.CheckedListBox pieseCbl;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTb;
        private System.Windows.Forms.Button finalizareBtn;
        private System.Windows.Forms.Button inapoiBtn;
    }
}