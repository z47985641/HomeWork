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
    public partial class HW_02 : Form
    {
        public HW_02()
        {
            InitializeComponent();
        }
        public double math(double Money, double First, double Year, double Per)
        {
            double TMoney = Money - First;
            double Mounth = Year * 12;
            double MPer = Per / 12 / 100;
            double G = 1;
            int i = 1;
            //宣告變數

            while (i < Mounth + 1)
            {
                G *= 1 + MPer;
                i++;
            }
            //計算利息算式中的"(1+月利息)^期數"

            double Mpay = (G * MPer) / (G - 1) * TMoney;
            //計算利息
            return Math.Floor(Mpay);
            //回傳月繳款
        }

        private void btnmounth_Click(object sender, EventArgs e)
        {
            double MMpay = math(double.Parse(TXTMoney.Text), double.Parse(TXTFirst.Text), double.Parse(TXTYear.Text), double.Parse(TXTper.Text));
            //將text box的字串轉型為Double並帶進有回傳值的方法(math)中
            MessageBox.Show("月付款 : " + MMpay);
            //將計算結果轉型成字串並顯示
        }

        private void btnmoney_Click(object sender, EventArgs e)
        {
            double Tpay = math(double.Parse(TXTMoney.Text), double.Parse(TXTFirst.Text), double.Parse(TXTYear.Text), double.Parse(TXTper.Text)) * double.Parse(TXTYear.Text) * 12;
            //將text box的字串轉型為Double並帶進有回傳值的方法(math)中，並將回傳值乘上期數等於總付款
            MessageBox.Show("總付款 : " + Tpay);
            //將計算結果轉型成字串並顯示
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            HW_02_secand SC = new HW_02_secand();
            SC.Show(); 
            //顯示第二表單
        }

        private void HW_02_Load(object sender, EventArgs e)
        {

        }
    }
}
