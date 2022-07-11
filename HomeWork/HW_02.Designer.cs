
namespace HomeWork
{
    partial class HW_02
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
            this.btnmounth = new System.Windows.Forms.Button();
            this.btnmoney = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.TXTMoney = new System.Windows.Forms.TextBox();
            this.TXTYear = new System.Windows.Forms.TextBox();
            this.TXTper = new System.Windows.Forms.TextBox();
            this.TXTFirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmounth
            // 
            this.btnmounth.Location = new System.Drawing.Point(75, 313);
            this.btnmounth.Name = "btnmounth";
            this.btnmounth.Size = new System.Drawing.Size(75, 23);
            this.btnmounth.TabIndex = 0;
            this.btnmounth.Text = "PMT(月付)";
            this.btnmounth.UseVisualStyleBackColor = true;
            this.btnmounth.Click += new System.EventHandler(this.btnmounth_Click);
            // 
            // btnmoney
            // 
            this.btnmoney.Location = new System.Drawing.Point(328, 313);
            this.btnmoney.Name = "btnmoney";
            this.btnmoney.Size = new System.Drawing.Size(75, 23);
            this.btnmoney.TabIndex = 1;
            this.btnmoney.Text = "總付金額";
            this.btnmoney.UseVisualStyleBackColor = true;
            this.btnmoney.Click += new System.EventHandler(this.btnmoney_Click);
            // 
            // btnreport
            // 
            this.btnreport.Location = new System.Drawing.Point(593, 312);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(75, 23);
            this.btnreport.TabIndex = 2;
            this.btnreport.Text = "報告";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // TXTMoney
            // 
            this.TXTMoney.Location = new System.Drawing.Point(356, 30);
            this.TXTMoney.Name = "TXTMoney";
            this.TXTMoney.Size = new System.Drawing.Size(100, 22);
            this.TXTMoney.TabIndex = 3;
            this.TXTMoney.Text = "300000";
            // 
            // TXTYear
            // 
            this.TXTYear.Location = new System.Drawing.Point(356, 79);
            this.TXTYear.Name = "TXTYear";
            this.TXTYear.Size = new System.Drawing.Size(100, 22);
            this.TXTYear.TabIndex = 4;
            this.TXTYear.Text = "5";
            // 
            // TXTper
            // 
            this.TXTper.Location = new System.Drawing.Point(356, 131);
            this.TXTper.Name = "TXTper";
            this.TXTper.Size = new System.Drawing.Size(100, 22);
            this.TXTper.TabIndex = 5;
            this.TXTper.Text = "5.78";
            // 
            // TXTFirst
            // 
            this.TXTFirst.Location = new System.Drawing.Point(356, 180);
            this.TXTFirst.Name = "TXTFirst";
            this.TXTFirst.Size = new System.Drawing.Size(100, 22);
            this.TXTFirst.TabIndex = 6;
            this.TXTFirst.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "貸款金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "期限(年)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "利率(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "頭期款";
            // 
            // HW_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTFirst);
            this.Controls.Add(this.TXTper);
            this.Controls.Add(this.TXTYear);
            this.Controls.Add(this.TXTMoney);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnmoney);
            this.Controls.Add(this.btnmounth);
            this.Name = "HW_02";
            this.Text = "HW_02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmounth;
        private System.Windows.Forms.Button btnmoney;
        private System.Windows.Forms.Button btnreport;
        public  System.Windows.Forms.TextBox TXTMoney;
        public  System.Windows.Forms.TextBox TXTYear;
        public  System.Windows.Forms.TextBox TXTper;
        public  System.Windows.Forms.TextBox TXTFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}