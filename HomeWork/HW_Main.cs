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
    public partial class HW_Main : Form
    {
        public HW_Main()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            STOP_ALL();
            HW_01 HW01 = new HW_01();
            HW01.MdiParent = HW_Main.ActiveForm;
            HW01.Show();
            HW01.Location = new Point(5, 5);
            //顯示HW_01 表單並固定位置
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            STOP_ALL();
            HW_02 HW02 = new HW_02();
            HW02.MdiParent = HW_Main.ActiveForm;
            HW02.Show();
            HW02.Location = new Point(5, 5);
            //顯示HW_02 表單並固定位置
        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            STOP_ALL();
            HW_03 HW03 = new HW_03();
            HW03.MdiParent = HW_Main.ActiveForm;
            HW03.Show();
            HW03.Location = new Point(5, 5);
            //顯示HW_03 表單並固定位置
        }

        private void button4_Click_4(object sender, EventArgs e)
        {
            STOP_ALL();
            HW_04 HW04 = new HW_04();
            HW04.MdiParent = HW_Main.ActiveForm;
            HW04.Show();
            HW04.Location = new Point(5, 5);
            //顯示HW_04 表單並固定位置
        }

        private void button5_Click_5(object sender, EventArgs e)
        {
            STOP_ALL();
            HW_05 HW05 = new HW_05();
            HW05.MdiParent = HW_Main.ActiveForm;
            HW05.Show();
            HW05.Location = new Point(5, 5);
            //顯示HW_05 表單並固定位置
        }

        private void button6_Click_6(object sender, EventArgs e)
        {
            STOP_ALL();
            HW_05 HW05 = new HW_05();
            HW05.MdiParent = HW_Main.ActiveForm;
            HW05.Show();
            HW05.Location = new Point(5, 5);
            HW05.Gbox1();
            //顯示HW_05 表單、固定位置並顯示group box1
        }
        private void button7_Click(object sender, EventArgs e)
        {
            STOP_ALL();
            HW_08 HW08 = new HW_08();
            HW08.MdiParent = HW_Main.ActiveForm;
            HW08.Show();
            HW08.Location = new Point(5, 5);
            //顯示HW_08 表單並固定位置
        }
        public void STOP_ALL()
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item != null)
                {
                    item.Close();
                }
            }
            //關閉所有表單
        }

    }
}
