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
    public partial class HW_03 : Form
    {
        double  num1, num2, num3, num4, prise1, prise2, prise3, prise4,Total,nineper;
        string SItem1, SItem2, SItem3, SItem4;

        private void Card_Click(object sender, EventArgs e)
        {
            nineper = Total * 0.9 ;
            if (Total == 0)
            {
                MessageBox.Show("尚未點餐!!!","請再確認");
            }
            else
                MessageBox.Show("總金額 : " + Total.ToString() + " $" + "\n" + "折扣後金額 : " + nineper + "$", "確認付款", MessageBoxButtons.YesNo);
        //先確認總金額是否為0，為0則顯示尚未點餐，不為0則將總金額*0.9並顯示
        }

        private void Cash_Click(object sender, EventArgs e)
        {
            if (Total == 0)
            {
                MessageBox.Show("尚未點餐!!!","請再確認");
            }
            else
                MessageBox.Show("總金額 :" + Total.ToString()+" $", "確認付款", MessageBoxButtons.YesNo) ;
            //先確認總金額是否為0，為0則顯示尚未點餐，不為0則顯示付款視窗
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            num1 = num2 = num3 = num4 = 0;
            prise1 = prise2 = prise3 = prise4 = Total = 0;
            txttoal.Text = "NT$ 0 ";
            SItem1 = SItem2 = SItem3 = SItem4 = "";
            List.Text = "尚未點餐";
            //將變數數值歸零、將金額顯示0、狀態顯示尚未點餐
        }

        private void Item1_Click(object sender, EventArgs e)
        {
            num1 += 1;
            prise1 = num1 * 350;
            if (num1 > 0)
            {
                SItem1 = "血腥瑪麗 X " + num1 + "共NT$ " + prise1 + "元" + Environment.NewLine;
            }
            //將單位+1、計算總價，並將單位及總價加上字串給SItem1
            math();
            //執行方法math
        }

        private void Item2_Click(object sender, EventArgs e)
        {
            num2 += 1;
            prise2 = num2 * 300;
            if (num2 > 0)
            {
                SItem2 = "馬丁尼 X " + num2 + "共NT$ " + prise2 + "元" + Environment.NewLine;
            }
            //將單位+1、計算總價，並將單位及總價加上字串給SItem2
            math();
            //執行方法math
        }
        private void Item3_Click_1(object sender, EventArgs e)
        {
            num3 += 1;
            prise3 = num3 * 250;
            if (num3 > 0)
            {
                SItem3 = "摩西多 X " + num3 + "共NT$ " + prise3 + "元" + Environment.NewLine;
            }
            //將單位+1、計算總價，並將單位及總價加上字串給SItem3
            math();
            //執行方法math
        }
        private void Item4_Click(object sender, EventArgs e)
        {
            num4 += 1;
            prise4 = num4 * 500;
            if (num4 > 0)
            {
                SItem4 = "環遊世界 X " + num4 + "共NT$ " + prise4 + "元";
            }
            //將單位+1、計算總價，並將單位及總價加上字串給SItem4
            math();
            //執行方法math
        }

        void math()
        {
            Total = prise1 + prise2 + prise3 + prise4;
            //計算總金額
            txttoal.Text = "NT$ " + Total.ToString();
            //顯示總金額並將型態轉為字串
            List.Text = SItem1 +  SItem2 +  SItem3 +  SItem4;
            //將各字串顯示
        }

        public HW_03()
        {
            InitializeComponent();
        }
    }
}
