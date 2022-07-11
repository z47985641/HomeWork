
namespace HomeWork
{
    partial class HW_04
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.scro = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtchi = new System.Windows.Forms.TextBox();
            this.txteng = new System.Windows.Forms.TextBox();
            this.txtmath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.scro);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(6, 171);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 104);
            this.textBox2.TabIndex = 6;
            // 
            // scro
            // 
            this.scro.BackColor = System.Drawing.SystemColors.Menu;
            this.scro.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.scro.Location = new System.Drawing.Point(7, 22);
            this.scro.Multiline = true;
            this.scro.Name = "scro";
            this.scro.Size = new System.Drawing.Size(280, 143);
            this.scro.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(6, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(281, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "顯示最高分/最低分科目";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "儲存學生成績";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "顯示儲存內容";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(108, 18);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 4;
            // 
            // txtchi
            // 
            this.txtchi.Location = new System.Drawing.Point(108, 46);
            this.txtchi.Name = "txtchi";
            this.txtchi.Size = new System.Drawing.Size(100, 22);
            this.txtchi.TabIndex = 5;
            // 
            // txteng
            // 
            this.txteng.Location = new System.Drawing.Point(108, 74);
            this.txteng.Name = "txteng";
            this.txteng.Size = new System.Drawing.Size(100, 22);
            this.txteng.TabIndex = 6;
            // 
            // txtmath
            // 
            this.txtmath.Location = new System.Drawing.Point(108, 102);
            this.txtmath.Name = "txtmath";
            this.txtmath.Size = new System.Drawing.Size(100, 22);
            this.txtmath.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓名 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "國文 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "英文 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "數學 : ";
            // 
            // HW_04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmath);
            this.Controls.Add(this.txteng);
            this.Controls.Add(this.txtchi);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "HW_04";
            this.Text = "HW_03";
            this.Load += new System.EventHandler(this.HW_04_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox scro;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtchi;
        private System.Windows.Forms.TextBox txteng;
        private System.Windows.Forms.TextBox txtmath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}