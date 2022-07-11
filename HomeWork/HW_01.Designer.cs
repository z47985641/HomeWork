
namespace HomeWork
{
    partial class HW_01
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TXT_name = new System.Windows.Forms.TextBox();
            this.TXT_EN = new System.Windows.Forms.TextBox();
            this.TXT_gender = new System.Windows.Forms.TextBox();
            this.TXT_star = new System.Windows.Forms.TextBox();
            this.LB_name = new System.Windows.Forms.Label();
            this.LB_EN = new System.Windows.Forms.Label();
            this.LB_Gender = new System.Windows.Forms.Label();
            this.LB_star = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Say HELLO ~~";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "Say HI ~~~";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TXT_name
            // 
            this.TXT_name.Location = new System.Drawing.Point(287, 87);
            this.TXT_name.Name = "TXT_name";
            this.TXT_name.Size = new System.Drawing.Size(100, 22);
            this.TXT_name.TabIndex = 2;
            // 
            // TXT_EN
            // 
            this.TXT_EN.Location = new System.Drawing.Point(286, 128);
            this.TXT_EN.Name = "TXT_EN";
            this.TXT_EN.Size = new System.Drawing.Size(100, 22);
            this.TXT_EN.TabIndex = 3;
            // 
            // TXT_gender
            // 
            this.TXT_gender.Location = new System.Drawing.Point(286, 177);
            this.TXT_gender.Name = "TXT_gender";
            this.TXT_gender.Size = new System.Drawing.Size(100, 22);
            this.TXT_gender.TabIndex = 4;
            // 
            // TXT_star
            // 
            this.TXT_star.Location = new System.Drawing.Point(286, 224);
            this.TXT_star.Name = "TXT_star";
            this.TXT_star.Size = new System.Drawing.Size(100, 22);
            this.TXT_star.TabIndex = 5;
            // 
            // LB_name
            // 
            this.LB_name.AutoSize = true;
            this.LB_name.Location = new System.Drawing.Point(131, 90);
            this.LB_name.Name = "LB_name";
            this.LB_name.Size = new System.Drawing.Size(35, 12);
            this.LB_name.TabIndex = 6;
            this.LB_name.Text = "姓名 :";
            // 
            // LB_EN
            // 
            this.LB_EN.AutoSize = true;
            this.LB_EN.Location = new System.Drawing.Point(131, 132);
            this.LB_EN.Name = "LB_EN";
            this.LB_EN.Size = new System.Drawing.Size(76, 12);
            this.LB_EN.TabIndex = 7;
            this.LB_EN.Text = "English Name :";
            // 
            // LB_Gender
            // 
            this.LB_Gender.AutoSize = true;
            this.LB_Gender.Location = new System.Drawing.Point(131, 181);
            this.LB_Gender.Name = "LB_Gender";
            this.LB_Gender.Size = new System.Drawing.Size(35, 12);
            this.LB_Gender.TabIndex = 8;
            this.LB_Gender.Text = "性別 :";
            // 
            // LB_star
            // 
            this.LB_star.AutoSize = true;
            this.LB_star.Location = new System.Drawing.Point(131, 228);
            this.LB_star.Name = "LB_star";
            this.LB_star.Size = new System.Drawing.Size(35, 12);
            this.LB_star.TabIndex = 9;
            this.LB_star.Text = "星座 :";
            // 
            // HW_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.LB_star);
            this.Controls.Add(this.LB_Gender);
            this.Controls.Add(this.LB_EN);
            this.Controls.Add(this.LB_name);
            this.Controls.Add(this.TXT_star);
            this.Controls.Add(this.TXT_gender);
            this.Controls.Add(this.TXT_EN);
            this.Controls.Add(this.TXT_name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "HW_01";
            this.Text = "HW_01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TXT_name;
        private System.Windows.Forms.TextBox TXT_EN;
        private System.Windows.Forms.TextBox TXT_gender;
        private System.Windows.Forms.TextBox TXT_star;
        private System.Windows.Forms.Label LB_name;
        private System.Windows.Forms.Label LB_EN;
        private System.Windows.Forms.Label LB_Gender;
        private System.Windows.Forms.Label LB_star;
    }
}

