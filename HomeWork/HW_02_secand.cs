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
    public partial class HW_02_secand : Form
    {
        public HW_02_secand()
        {
            InitializeComponent();
        }
        public  void HW_01_secand_Load(object sender, EventArgs e)
        {
            HW_02 HW02 = new HW_02 ();
            RPmoney.Text = HW02.TXTMoney.Text;
            RPyear.Text = HW02.TXTYear.Text;
            RPper.Text = HW02.TXTper.Text;
            string RPFirst = HW02.TXTFirst.Text ;
            //將第一表單的數值顯示在第二表單

            double MMpay = HW02.math(double.Parse(RPmoney.Text), double.Parse(RPFirst), double.Parse(RPyear.Text), double.Parse(RPper.Text));
            //將text box的字串轉型為Double並帶進有回傳值的方法(math)中
            RPMmoney.Text = MMpay.ToString();
            //將計算結果轉型成字串並顯示

            double Tpay = HW02.math(double.Parse(RPmoney.Text), double.Parse(RPFirst), double.Parse(RPyear.Text), double.Parse(RPper.Text))* double.Parse(RPyear.Text) * 12;
            //將text box的字串轉型為Double並帶進有回傳值的方法(math)中，並將回傳值乘上期數等於總付款
            RPYmoney.Text = Tpay.ToString ();
            //將計算結果轉型成字串並顯示


        }
    }
}
