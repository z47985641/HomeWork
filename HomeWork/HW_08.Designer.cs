
namespace HomeWork
{
    partial class HW_08
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
            this.TxtA = new System.Windows.Forms.TextBox();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.Anser = new System.Windows.Forms.TextBox();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(63, 47);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(100, 22);
            this.TxtA.TabIndex = 0;
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(63, 84);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(100, 22);
            this.TxtB.TabIndex = 1;
            // 
            // Anser
            // 
            this.Anser.Enabled = false;
            this.Anser.Location = new System.Drawing.Point(63, 138);
            this.Anser.Name = "Anser";
            this.Anser.Size = new System.Drawing.Size(100, 22);
            this.Anser.TabIndex = 2;
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(184, 47);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(75, 23);
            this.btnplus.TabIndex = 3;
            this.btnplus.Text = "加";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(184, 84);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 23);
            this.btnsub.TabIndex = 4;
            this.btnsub.Text = "減";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnmul
            // 
            this.btnmul.Location = new System.Drawing.Point(265, 47);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(75, 23);
            this.btnmul.TabIndex = 5;
            this.btnmul.Text = "乘";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(265, 84);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(75, 23);
            this.btndiv.TabIndex = 6;
            this.btndiv.Text = "除";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "數值一";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "數值二";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "答案";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "===================";
            // 
            // HW_08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 181);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.Anser);
            this.Controls.Add(this.TxtB);
            this.Controls.Add(this.TxtA);
            this.Name = "HW_08";
            this.Text = "HW_08_MyClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.TextBox Anser;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}