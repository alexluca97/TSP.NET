namespace CarServiceUI
{
    partial class MecaniciForm
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
            this.mecanicLv = new System.Windows.Forms.ListView();
            this.mecanicId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numeMecanic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenumeMecanic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataliiId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alegeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clientRtb = new System.Windows.Forms.RichTextBox();
            this.inapoiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mecanici";
            // 
            // mecanicLv
            // 
            this.mecanicLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mecanicId,
            this.numeMecanic,
            this.prenumeMecanic,
            this.dataliiId});
            this.mecanicLv.Location = new System.Drawing.Point(144, 159);
            this.mecanicLv.Name = "mecanicLv";
            this.mecanicLv.Size = new System.Drawing.Size(307, 334);
            this.mecanicLv.TabIndex = 1;
            this.mecanicLv.UseCompatibleStateImageBehavior = false;
            this.mecanicLv.View = System.Windows.Forms.View.Details;
            // 
            // mecanicId
            // 
            this.mecanicId.Text = "Cod Mecanic";
            this.mecanicId.Width = 0;
            // 
            // numeMecanic
            // 
            this.numeMecanic.Text = "Nume";
            // 
            // prenumeMecanic
            // 
            this.prenumeMecanic.Text = "Prenume";
            this.prenumeMecanic.Width = 84;
            // 
            // dataliiId
            // 
            this.dataliiId.Text = "Lucreaza la";
            this.dataliiId.Width = 129;
            // 
            // alegeBtn
            // 
            this.alegeBtn.Location = new System.Drawing.Point(12, 228);
            this.alegeBtn.Name = "alegeBtn";
            this.alegeBtn.Size = new System.Drawing.Size(75, 23);
            this.alegeBtn.TabIndex = 3;
            this.alegeBtn.Text = "Alege";
            this.alegeBtn.UseVisualStyleBackColor = true;
            this.alegeBtn.Click += new System.EventHandler(this.alegeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client";
            // 
            // clientRtb
            // 
            this.clientRtb.Location = new System.Drawing.Point(177, 24);
            this.clientRtb.Name = "clientRtb";
            this.clientRtb.Size = new System.Drawing.Size(274, 96);
            this.clientRtb.TabIndex = 5;
            this.clientRtb.Text = "";
            // 
            // inapoiBtn
            // 
            this.inapoiBtn.Location = new System.Drawing.Point(12, 416);
            this.inapoiBtn.Name = "inapoiBtn";
            this.inapoiBtn.Size = new System.Drawing.Size(75, 23);
            this.inapoiBtn.TabIndex = 6;
            this.inapoiBtn.Text = "Inapoi";
            this.inapoiBtn.UseVisualStyleBackColor = true;
            this.inapoiBtn.Click += new System.EventHandler(this.inapoiBtn_Click);
            // 
            // MecaniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 505);
            this.Controls.Add(this.inapoiBtn);
            this.Controls.Add(this.clientRtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alegeBtn);
            this.Controls.Add(this.mecanicLv);
            this.Controls.Add(this.label1);
            this.Name = "MecaniciForm";
            this.Text = "MecaniciFormcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView mecanicLv;
        private System.Windows.Forms.ColumnHeader mecanicId;
        private System.Windows.Forms.ColumnHeader numeMecanic;
        private System.Windows.Forms.ColumnHeader prenumeMecanic;
        private System.Windows.Forms.ColumnHeader dataliiId;
        private System.Windows.Forms.Button alegeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox clientRtb;
        private System.Windows.Forms.Button inapoiBtn;
    }
}