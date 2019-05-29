namespace CarServiceUI
{
    partial class FirstForm
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
            this.cautaClientBtn = new System.Windows.Forms.Button();
            this.clientsListView = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Localitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adaugaClientBtn = new System.Windows.Forms.Button();
            this.autoListView = new System.Windows.Forms.ListView();
            this.autoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numarAuto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serieSasiu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sasiuId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sasiuInfoRtb = new System.Windows.Forms.RichTextBox();
            this.creazaComandaBtn = new System.Windows.Forms.Button();
            this.clientiLabel = new System.Windows.Forms.Label();
            this.autoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adaugaVehiculBtn = new System.Windows.Forms.Button();
            this.mecanicFormBtn = new System.Windows.Forms.Button();
            this.FinalizareBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cautaClientBtn
            // 
            this.cautaClientBtn.Location = new System.Drawing.Point(12, 70);
            this.cautaClientBtn.Name = "cautaClientBtn";
            this.cautaClientBtn.Size = new System.Drawing.Size(119, 37);
            this.cautaClientBtn.TabIndex = 0;
            this.cautaClientBtn.Text = "Cauta Client";
            this.cautaClientBtn.UseVisualStyleBackColor = true;
            this.cautaClientBtn.Click += new System.EventHandler(this.cautaClientBtn_Click);
            // 
            // clientsListView
            // 
            this.clientsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nume,
            this.Prenume,
            this.Adresa,
            this.Localitate,
            this.Telefon,
            this.Email});
            this.clientsListView.FullRowSelect = true;
            this.clientsListView.GridLines = true;
            this.clientsListView.Location = new System.Drawing.Point(187, 37);
            this.clientsListView.Name = "clientsListView";
            this.clientsListView.Size = new System.Drawing.Size(601, 207);
            this.clientsListView.TabIndex = 1;
            this.clientsListView.UseCompatibleStateImageBehavior = false;
            this.clientsListView.View = System.Windows.Forms.View.Details;
            this.clientsListView.SelectedIndexChanged += new System.EventHandler(this.clientsListView_SelectedIndexChanged);
            this.clientsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clientsListView_Click);
            // 
            // Id
            // 
            this.Id.Text = "Cod Client";
            this.Id.Width = 0;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 82;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.Width = 90;
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 102;
            // 
            // Localitate
            // 
            this.Localitate.Text = "Localitate";
            this.Localitate.Width = 115;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 88;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 119;
            // 
            // adaugaClientBtn
            // 
            this.adaugaClientBtn.Location = new System.Drawing.Point(12, 113);
            this.adaugaClientBtn.Name = "adaugaClientBtn";
            this.adaugaClientBtn.Size = new System.Drawing.Size(119, 39);
            this.adaugaClientBtn.TabIndex = 2;
            this.adaugaClientBtn.Text = "Adauga Client";
            this.adaugaClientBtn.UseVisualStyleBackColor = true;
            this.adaugaClientBtn.Click += new System.EventHandler(this.adaugaClientBtn_Click);
            // 
            // autoListView
            // 
            this.autoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.autoId,
            this.numarAuto,
            this.serieSasiu,
            this.sasiuId});
            this.autoListView.FullRowSelect = true;
            this.autoListView.GridLines = true;
            this.autoListView.Location = new System.Drawing.Point(187, 290);
            this.autoListView.Name = "autoListView";
            this.autoListView.Size = new System.Drawing.Size(601, 185);
            this.autoListView.TabIndex = 3;
            this.autoListView.UseCompatibleStateImageBehavior = false;
            this.autoListView.View = System.Windows.Forms.View.Details;
            this.autoListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.autoListView_Click);
            // 
            // autoId
            // 
            this.autoId.Text = "Cod Client";
            this.autoId.Width = 0;
            // 
            // numarAuto
            // 
            this.numarAuto.Text = "Numar Auto";
            this.numarAuto.Width = 186;
            // 
            // serieSasiu
            // 
            this.serieSasiu.Text = "Serie Sasiu";
            this.serieSasiu.Width = 124;
            // 
            // sasiuId
            // 
            this.sasiuId.Text = "Cod Sasiu";
            // 
            // sasiuInfoRtb
            // 
            this.sasiuInfoRtb.Enabled = false;
            this.sasiuInfoRtb.Location = new System.Drawing.Point(187, 526);
            this.sasiuInfoRtb.Name = "sasiuInfoRtb";
            this.sasiuInfoRtb.Size = new System.Drawing.Size(601, 86);
            this.sasiuInfoRtb.TabIndex = 4;
            this.sasiuInfoRtb.Text = "";
            // 
            // creazaComandaBtn
            // 
            this.creazaComandaBtn.Location = new System.Drawing.Point(13, 253);
            this.creazaComandaBtn.Name = "creazaComandaBtn";
            this.creazaComandaBtn.Size = new System.Drawing.Size(118, 63);
            this.creazaComandaBtn.TabIndex = 5;
            this.creazaComandaBtn.Text = "Creaza Comanda";
            this.creazaComandaBtn.UseVisualStyleBackColor = true;
            this.creazaComandaBtn.Click += new System.EventHandler(this.creazaComandaBtn_Click);
            // 
            // clientiLabel
            // 
            this.clientiLabel.AutoSize = true;
            this.clientiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientiLabel.Location = new System.Drawing.Point(187, 9);
            this.clientiLabel.Name = "clientiLabel";
            this.clientiLabel.Size = new System.Drawing.Size(66, 25);
            this.clientiLabel.TabIndex = 6;
            this.clientiLabel.Text = "Clienti";
            // 
            // autoLabel
            // 
            this.autoLabel.AutoSize = true;
            this.autoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel.Location = new System.Drawing.Point(187, 262);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(125, 25);
            this.autoLabel.TabIndex = 7;
            this.autoLabel.Text = "Autovehicule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sasiu";
            // 
            // adaugaVehiculBtn
            // 
            this.adaugaVehiculBtn.Location = new System.Drawing.Point(13, 340);
            this.adaugaVehiculBtn.Name = "adaugaVehiculBtn";
            this.adaugaVehiculBtn.Size = new System.Drawing.Size(118, 47);
            this.adaugaVehiculBtn.TabIndex = 9;
            this.adaugaVehiculBtn.Text = "Adauga Vehicul";
            this.adaugaVehiculBtn.UseVisualStyleBackColor = true;
            this.adaugaVehiculBtn.Click += new System.EventHandler(this.adaugaVehiculBtn_Click);
            // 
            // mecanicFormBtn
            // 
            this.mecanicFormBtn.Location = new System.Drawing.Point(13, 428);
            this.mecanicFormBtn.Name = "mecanicFormBtn";
            this.mecanicFormBtn.Size = new System.Drawing.Size(118, 47);
            this.mecanicFormBtn.TabIndex = 10;
            this.mecanicFormBtn.Text = "Cauta Mecanici";
            this.mecanicFormBtn.UseVisualStyleBackColor = true;
            this.mecanicFormBtn.Click += new System.EventHandler(this.mecanicFormBtn_Click);
            // 
            // FinalizareBtn
            // 
            this.FinalizareBtn.Location = new System.Drawing.Point(13, 553);
            this.FinalizareBtn.Name = "FinalizareBtn";
            this.FinalizareBtn.Size = new System.Drawing.Size(118, 47);
            this.FinalizareBtn.TabIndex = 11;
            this.FinalizareBtn.Text = "Finalizare Comanda";
            this.FinalizareBtn.UseVisualStyleBackColor = true;
            this.FinalizareBtn.Click += new System.EventHandler(this.FinalizareBtn_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 660);
            this.Controls.Add(this.FinalizareBtn);
            this.Controls.Add(this.mecanicFormBtn);
            this.Controls.Add(this.adaugaVehiculBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autoLabel);
            this.Controls.Add(this.clientiLabel);
            this.Controls.Add(this.creazaComandaBtn);
            this.Controls.Add(this.sasiuInfoRtb);
            this.Controls.Add(this.autoListView);
            this.Controls.Add(this.adaugaClientBtn);
            this.Controls.Add(this.clientsListView);
            this.Controls.Add(this.cautaClientBtn);
            this.Name = "FirstForm";
            this.Text = "CarServiceSCUI";
            this.Load += new System.EventHandler(this.FirstForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cautaClientBtn;
        private System.Windows.Forms.ListView clientsListView;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader Localitate;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Button adaugaClientBtn;
        private System.Windows.Forms.ListView autoListView;
        private System.Windows.Forms.ColumnHeader autoId;
        private System.Windows.Forms.ColumnHeader numarAuto;
        private System.Windows.Forms.ColumnHeader serieSasiu;
        private System.Windows.Forms.RichTextBox sasiuInfoRtb;
        private System.Windows.Forms.Button creazaComandaBtn;
        private System.Windows.Forms.Label clientiLabel;
        private System.Windows.Forms.Label autoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adaugaVehiculBtn;
        private System.Windows.Forms.ColumnHeader sasiuId;
        private System.Windows.Forms.Button mecanicFormBtn;
        private System.Windows.Forms.Button FinalizareBtn;
    }
}

