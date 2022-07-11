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
    public partial class HW_01 : Form
    {
        public HW_01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Hello 大家好!! 我叫"+
                TXT_name .Text +"\n "+ "English name is "+
                TXT_EN.Text+"\n"+"性別是 " + 
                TXT_gender.Text+"\n"+ "星座則是 " + 
                TXT_star.Text+"\n"+"高興認識大家~~~~~");
            //將各text box輸入的字串加上其他字串並於MessageBox顯示
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HI~~~ 大家好~~ 我叫" + 
                TXT_name.Text + "\n " + "English name is " + 
                TXT_EN.Text + "\n" + "性別是 " + 
                TXT_gender.Text + "\n" + "星座則是 " + 
                TXT_star.Text + "\n" + "高興認識大家!!!");
            //將各text box輸入的字串加上其他字串並於MessageBox顯示
        }
    }
}
