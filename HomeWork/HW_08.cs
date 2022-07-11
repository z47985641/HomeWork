using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class HW_08 : Form
    {
        int Item;
        double ans;

        public HW_08()
        {
            InitializeComponent();
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            Item = 1;
            Math();
            Anser.Text = ans.ToString();
            //將變數Item帶入1，並呼叫方法Math，將答案轉字串並顯示
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            Item = 2;
            Math();
            Anser.Text = ans.ToString();
            //將變數Item帶入2，並呼叫方法Math，將答案轉字串並顯示
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            Item = 3;
            Math();
            Anser.Text = ans.ToString();
            //將變數Item帶入3，並呼叫方法Math，將答案轉字串並顯示
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            Item = 4;
            Math();
            Anser.Text = ans.ToString();
            //將變數Item帶入4，並呼叫方法Math，將答案轉字串並顯示
        }

        public void Math()
        {
            if (TxtA.Text != "" & TxtB.Text != "")
            {
                double num1 = double.Parse(TxtA.Text), num2 = double.Parse(TxtB.Text);
                //將輸入的字串轉成double並帶入變數
                switch (Item)
                {
                    case 1:
                        ans = num1 + num2;
                        break;
                    case 2:
                        ans = num1 - num2;
                        break;
                    case 3:
                        ans = num1 * num2;
                        break;
                    case 4:
                        ans = num1 / num2;
                        break;
                        //依照 變數ITEM帶入對應的算式
                }
            }
            else
                MessageBox.Show("請確認是否有輸入數值", "警告");
        }
    }
}
