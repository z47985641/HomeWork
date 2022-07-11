
namespace HomeWork
{
    partial class HW_03
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
            this.Item1 = new System.Windows.Forms.Button();
            this.Item2 = new System.Windows.Forms.Button();
            this.Item4 = new System.Windows.Forms.Button();
            this.Cash = new System.Windows.Forms.Button();
            this.Card = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Item3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.List = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttoal = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Item1
            // 
            this.Item1.Location = new System.Drawing.Point(6, 21);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(142, 110);
            this.Item1.TabIndex = 0;
            this.Item1.Text = "血腥瑪麗 350";
            this.Item1.UseVisualStyleBackColor = true;
            this.Item1.Click += new System.EventHandler(this.Item1_Click);
            // 
            // Item2
            // 
            this.Item2.Location = new System.Drawing.Point(154, 21);
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(142, 110);
            this.Item2.TabIndex = 1;
            this.Item2.Text = "馬丁尼 300";
            this.Item2.UseVisualStyleBackColor = true;
            this.Item2.Click += new System.EventHandler(this.Item2_Click);
            // 
            // Item4
            // 
            this.Item4.Location = new System.Drawing.Point(450, 21);
            this.Item4.Name = "Item4";
            this.Item4.Size = new System.Drawing.Size(142, 110);
            this.Item4.TabIndex = 1;
            this.Item4.Text = "環遊世界 500";
            this.Item4.UseVisualStyleBackColor = true;
            this.Item4.Click += new System.EventHandler(this.Item4_Click);
            // 
            // Cash
            // 
            this.Cash.Location = new System.Drawing.Point(6, 21);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(205, 123);
            this.Cash.TabIndex = 2;
            this.Cash.Text = "現金";
            this.Cash.UseVisualStyleBackColor = true;
            this.Cash.Click += new System.EventHandler(this.Cash_Click);
            // 
            // Card
            // 
            this.Card.Location = new System.Drawing.Point(6, 150);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(205, 123);
            this.Card.TabIndex = 3;
            this.Card.Text = "信用卡";
            this.Card.UseVisualStyleBackColor = true;
            this.Card.Click += new System.EventHandler(this.Card_Click);
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(6, 175);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(363, 33);
            this.Clean.TabIndex = 4;
            this.Clean.Text = "全部清除";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Item3);
            this.groupBox1.Controls.Add(this.Item1);
            this.groupBox1.Controls.Add(this.Item2);
            this.groupBox1.Controls.Add(this.Item4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 139);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜單";
            // 
            // Item3
            // 
            this.Item3.Location = new System.Drawing.Point(302, 23);
            this.Item3.Name = "Item3";
            this.Item3.Size = new System.Drawing.Size(142, 110);
            this.Item3.TabIndex = 2;
            this.Item3.Text = "摩西多 250";
            this.Item3.UseVisualStyleBackColor = true;
            this.Item3.Click += new System.EventHandler(this.Item3_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.List);
            this.groupBox2.Controls.Add(this.Clean);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 217);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "清單";
            // 
            // List
            // 
            this.List.Enabled = false;
            this.List.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.List.Location = new System.Drawing.Point(1, 21);
            this.List.Multiline = true;
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(368, 148);
            this.List.TabIndex = 5;
            this.List.Text = "尚未點餐";
            this.List.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttoal);
            this.groupBox3.Location = new System.Drawing.Point(13, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 96);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "總金額";
            // 
            // txttoal
            // 
            this.txttoal.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txttoal.Enabled = false;
            this.txttoal.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txttoal.ForeColor = System.Drawing.SystemColors.Window;
            this.txttoal.Location = new System.Drawing.Point(7, 22);
            this.txttoal.Name = "txttoal";
            this.txttoal.Size = new System.Drawing.Size(361, 65);
            this.txttoal.TabIndex = 0;
            this.txttoal.Text = "NT$ 0";
            this.txttoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.Cash);
            this.groupBox4.Controls.Add(this.Card);
            this.groupBox4.Location = new System.Drawing.Point(393, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 319);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "付款方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(17, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "信用卡9折優惠";
            // 
            // HW_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HW_03";
            this.Text = "HW_03";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Item1;
        private System.Windows.Forms.Button Item2;
        private System.Windows.Forms.Button Item4;
        private System.Windows.Forms.Button Cash;
        private System.Windows.Forms.Button Card;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Item3;
        private System.Windows.Forms.TextBox txttoal;
        private System.Windows.Forms.TextBox List;
    }
}