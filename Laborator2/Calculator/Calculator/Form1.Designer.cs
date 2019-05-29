namespace Calculator
{
    partial class Form1
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
            this.CalculResultTb = new System.Windows.Forms.TextBox();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.SubtractBtn = new System.Windows.Forms.Button();
            this.SumBtn = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.DotBtn = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.PowBtn = new System.Windows.Forms.Button();
            this.HistoryRtb = new System.Windows.Forms.RichTextBox();
            this.resultHistoryTb = new System.Windows.Forms.TextBox();
            this.resultViewList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.CBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalculResultTb
            // 
            this.CalculResultTb.Enabled = false;
            this.CalculResultTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculResultTb.Location = new System.Drawing.Point(12, 97);
            this.CalculResultTb.Name = "CalculResultTb";
            this.CalculResultTb.Size = new System.Drawing.Size(229, 30);
            this.CalculResultTb.TabIndex = 0;
            this.CalculResultTb.Text = "0";
            this.CalculResultTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DivideBtn
            // 
            this.DivideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideBtn.Location = new System.Drawing.Point(72, 146);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(44, 41);
            this.DivideBtn.TabIndex = 2;
            this.DivideBtn.TabStop = false;
            this.DivideBtn.Text = "/";
            this.DivideBtn.UseVisualStyleBackColor = true;
            this.DivideBtn.Click += new System.EventHandler(this.DivideBtn_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyBtn.Location = new System.Drawing.Point(134, 146);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(44, 41);
            this.MultiplyBtn.TabIndex = 3;
            this.MultiplyBtn.TabStop = false;
            this.MultiplyBtn.Text = "*";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            this.MultiplyBtn.Click += new System.EventHandler(this.MultiplyBtn_Click);
            // 
            // SubtractBtn
            // 
            this.SubtractBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractBtn.Location = new System.Drawing.Point(197, 146);
            this.SubtractBtn.Name = "SubtractBtn";
            this.SubtractBtn.Size = new System.Drawing.Size(44, 41);
            this.SubtractBtn.TabIndex = 4;
            this.SubtractBtn.TabStop = false;
            this.SubtractBtn.Text = "-";
            this.SubtractBtn.UseVisualStyleBackColor = true;
            this.SubtractBtn.Click += new System.EventHandler(this.SubtractBtn_Click);
            // 
            // SumBtn
            // 
            this.SumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumBtn.Location = new System.Drawing.Point(197, 206);
            this.SumBtn.Name = "SumBtn";
            this.SumBtn.Size = new System.Drawing.Size(44, 99);
            this.SumBtn.TabIndex = 8;
            this.SumBtn.TabStop = false;
            this.SumBtn.Text = "+";
            this.SumBtn.UseVisualStyleBackColor = true;
            this.SumBtn.Click += new System.EventHandler(this.SumBtn_Click);
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(134, 206);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(44, 41);
            this.Btn9.TabIndex = 7;
            this.Btn9.TabStop = false;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(72, 206);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(44, 41);
            this.Btn8.TabIndex = 6;
            this.Btn8.TabStop = false;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn7
            // 
            this.Btn7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(12, 206);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(44, 41);
            this.Btn7.TabIndex = 5;
            this.Btn7.TabStop = false;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(134, 263);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(44, 41);
            this.Btn6.TabIndex = 11;
            this.Btn6.TabStop = false;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(72, 263);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(44, 41);
            this.Btn5.TabIndex = 10;
            this.Btn5.TabStop = false;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(12, 263);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(44, 41);
            this.Btn4.TabIndex = 9;
            this.Btn4.TabStop = false;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(134, 320);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(44, 41);
            this.Btn3.TabIndex = 15;
            this.Btn3.TabStop = false;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(72, 320);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(44, 41);
            this.Btn2.TabIndex = 14;
            this.Btn2.TabStop = false;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(12, 320);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(44, 41);
            this.Btn1.TabIndex = 13;
            this.Btn1.TabStop = false;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // EnterBtn
            // 
            this.EnterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterBtn.Location = new System.Drawing.Point(197, 320);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(44, 100);
            this.EnterBtn.TabIndex = 20;
            this.EnterBtn.TabStop = false;
            this.EnterBtn.Text = "enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // DotBtn
            // 
            this.DotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotBtn.Location = new System.Drawing.Point(134, 379);
            this.DotBtn.Name = "DotBtn";
            this.DotBtn.Size = new System.Drawing.Size(44, 41);
            this.DotBtn.TabIndex = 19;
            this.DotBtn.TabStop = false;
            this.DotBtn.Text = ".";
            this.DotBtn.UseVisualStyleBackColor = true;
            this.DotBtn.Click += new System.EventHandler(this.DotBtn_Click);
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(72, 379);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(44, 41);
            this.Btn0.TabIndex = 18;
            this.Btn0.TabStop = false;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // PowBtn
            // 
            this.PowBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.PowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowBtn.Location = new System.Drawing.Point(12, 146);
            this.PowBtn.Name = "PowBtn";
            this.PowBtn.Size = new System.Drawing.Size(44, 41);
            this.PowBtn.TabIndex = 1;
            this.PowBtn.TabStop = false;
            this.PowBtn.Text = "^";
            this.PowBtn.UseVisualStyleBackColor = true;
            this.PowBtn.Click += new System.EventHandler(this.PowBtn_Click);
            // 
            // HistoryRtb
            // 
            this.HistoryRtb.Enabled = false;
            this.HistoryRtb.Location = new System.Drawing.Point(12, 12);
            this.HistoryRtb.Name = "HistoryRtb";
            this.HistoryRtb.Size = new System.Drawing.Size(229, 67);
            this.HistoryRtb.TabIndex = 21;
            this.HistoryRtb.Text = "";
            // 
            // resultHistoryTb
            // 
            this.resultHistoryTb.Enabled = false;
            this.resultHistoryTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultHistoryTb.Location = new System.Drawing.Point(453, 350);
            this.resultHistoryTb.Name = "resultHistoryTb";
            this.resultHistoryTb.Size = new System.Drawing.Size(309, 30);
            this.resultHistoryTb.TabIndex = 22;
            // 
            // resultViewList
            // 
            this.resultViewList.FullRowSelect = true;
            this.resultViewList.Location = new System.Drawing.Point(334, 12);
            this.resultViewList.Margin = new System.Windows.Forms.Padding(1);
            this.resultViewList.Name = "resultViewList";
            this.resultViewList.Size = new System.Drawing.Size(428, 313);
            this.resultViewList.TabIndex = 28;
            this.resultViewList.UseCompatibleStateImageBehavior = false;
            this.resultViewList.View = System.Windows.Forms.View.List;
            this.resultViewList.Click += new System.EventHandler(this.resultViewList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "RESULT:";
            // 
            // CBtn
            // 
            this.CBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtn.Location = new System.Drawing.Point(12, 379);
            this.CBtn.Name = "CBtn";
            this.CBtn.Size = new System.Drawing.Size(44, 41);
            this.CBtn.TabIndex = 18;
            this.CBtn.TabStop = false;
            this.CBtn.Text = "C";
            this.CBtn.UseVisualStyleBackColor = true;
            this.CBtn.Click += new System.EventHandler(this.CBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 447);
            this.Controls.Add(this.CBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultViewList);
            this.Controls.Add(this.resultHistoryTb);
            this.Controls.Add(this.HistoryRtb);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.DotBtn);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.SumBtn);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.SubtractBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.DivideBtn);
            this.Controls.Add(this.PowBtn);
            this.Controls.Add(this.CalculResultTb);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CalculResultTb;
        private System.Windows.Forms.Button DivideBtn;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.Button SubtractBtn;
        private System.Windows.Forms.Button SumBtn;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Button DotBtn;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button PowBtn;
        private System.Windows.Forms.RichTextBox HistoryRtb;
        private System.Windows.Forms.TextBox resultHistoryTb;
        private System.Windows.Forms.ListView resultViewList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CBtn;
    }
}

