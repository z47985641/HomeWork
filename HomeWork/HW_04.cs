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
    public partial class HW_04 : Form
    {
        string SName, CHI, MATH, ENG ;
        int[] big;
        static string[] Sub = new string[] { "國文", "英文", "數學" };
        //宣告各變數及陣列

        private void button2_Click(object sender, EventArgs e)
        {
            scro.Text = "姓名 : "+SName + Environment.NewLine + "國文 : " + CHI + Environment.NewLine + "英文 : " + ENG + Environment.NewLine + "數學 : " + MATH ;
            //顯示輸入的資料
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text ="最高科目成績為 " +Getmax(ref big).ToString()+ Environment.NewLine+"最低科目成績為 "+GetSmall(ref big).ToString();
            //顯示最高及最低成績
        }

        static int Getmax (ref int[] ary )
        {
            int i,Max;
            Max = ary[0];
            for (i = 1; i <= 2; i++)
            {
                if (Max < ary[i])
                {
                    Max = ary[i];
                }
                //比大小，並將較大的數值帶進MAX變數
            }
            return Max;
            //回傳
        }

        private void HW_04_Load(object sender, EventArgs e)
        {

        }

        static int GetSmall(ref int[] ary)
        {
            int i, Small;

            Small = ary[0];
            for (i = 1; i <= 2; i++)
            {
                if (Small > ary[i])
                    Small = ary[i];
                //比大小，並將較小的數值帶進SMALL變數
            }
            return Small;
            //回傳
        }
        public HW_04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" & txtchi.Text != "" & txtmath.Text != "" & txteng.Text != "")
            {
                big = new int[] { int.Parse(txtchi.Text), int.Parse(txteng.Text), int.Parse(txtmath.Text) };
                SName = txtname.Text;
                CHI = txtchi.Text;
                MATH = txtmath.Text;
                ENG = txteng.Text;
                button3.Enabled = true;
            }
            else
                MessageBox.Show("所有內容皆須填寫","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //確認個欄位皆被輸入值，若非則顯示僅告，將輸入資料帶進變數及陣列
        }
    }
}
