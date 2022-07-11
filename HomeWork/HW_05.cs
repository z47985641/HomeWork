using System;
using System.Collections;
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
    public partial class HW_05 : Form
    {
        public HW_05()
        {
            InitializeComponent();
        }
        private void HW_05_Load(object sender, EventArgs e)
        {
            for (i = 0; i < SUB.Length; i++)
            {
                LTXT += $"{SUB[i].PadRight(10)}";
            }
            label5.Text = $"{LTXT}\n";
            //表單讀取時顯示欄位名稱
        }

        ArrayList NData = new ArrayList();
        ArrayList AData = new ArrayList();
        ArrayList SSData = new ArrayList();
        ScoreData DData;
        ScoreAData ADData;
        ScoreArer SData;
        string[] SUB = { "姓名", "國文", "英文", "數學", "總分","平均", "最高科目", "最低科目" };
        string[] DSUB = { "總分", "平均","最高分數", "最低分數" };
        string LTXT ;
        int Big, Small;
        int i,J = 1,K,L, CMax, EMax, MMax, CLess,ELess,MLess;
        
        
        private void btnadd_Click(object sender, EventArgs e)
        {
            btnmath.Enabled=true;
            DData.DName = textBox1.Text;
            DData.Dchi = int.Parse(textBox2.Text);
            DData.Deng = int.Parse(textBox3.Text);
            DData.Dmath = int.Parse(textBox4.Text);
            DData.Dtotal = DData.Dchi + DData.Deng + DData.Dmath;
            DData.Daver = DData.Dtotal / 3 ;
            NData.Add(DData); 

            GetBig();
            GetSmall();
            SData.Dbig = Big;
            SData.Dsmal = Small;
            SSData.Add(SData);

            showData();

            J++;
            //呼叫方法找出最高及最低的成績並將輸入的資料寫進集合
        }
        void Radd ()
        {
            btnmath.Enabled = true;
            L = NData.Count + 1;
            DData.DName = L.ToString();
            Random RA = new Random(int.Parse(DateTime.Now.ToString("HHmmssfff")) * 5);
            DData.Dchi = RA.Next(10, 100);
            DData.Deng = RA.Next(10, 100);
            DData.Dmath = RA.Next(10, 100);
            DData.Dtotal = DData.Dchi + DData.Deng + DData.Dmath;
            DData.Daver = DData.Dtotal / 3;
            NData.Add(DData);

            GetBig();
            GetSmall();
            SData.Dbig = Big;
            SData.Dsmal = Small;
            SSData.Add(SData);

            showData();
            J++;
            //隨機加入各科成績
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int SearchBig= int.Parse(textBox6.Text), SearchSmall=int.Parse(textBox5.Text);
            label5.Text = $"{LTXT}\n";
            for (int i = 0; i < NData.Count; i++)
            {
                if (((ScoreData)NData[i]).Dchi >= SearchSmall && ((ScoreData)NData[i]).Dchi <= SearchBig)
                {
                    label5.Text += $"{((ScoreData)NData[i]).DName.PadRight(15)}" +
                        $"{((ScoreData)NData[i]).Dchi.ToString().PadRight(15)}" +
                        $"{((ScoreData)NData[i]).Deng.ToString().PadRight(15)}" +
                        $"{((ScoreData)NData[i]).Dmath.ToString().PadRight(15)}" +
                        $"{((ScoreData)NData[i]).Dtotal.ToString().PadRight(15)}" +
                        $"{((ScoreData)NData[i]).Daver.ToString().PadRight(15)}" +
                        $"{((ScoreArer)SSData[i]).DBsub}" +
                        $"{((ScoreArer)SSData[i]).Dbig.ToString().PadRight(15)}" +
                        $"{((ScoreArer)SSData[i]).DSsub}" +
                        $"{((ScoreArer)SSData[i]).Dsmal}\n";
                }
            }
            //顯示各集合內容
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnmath.Enabled = true;
            DData.DName = textBox1.Text;
            DData.Dchi = int.Parse(textBox2.Text);
            DData.Deng = int.Parse(textBox3.Text);
            DData.Dmath = int.Parse(textBox4.Text);
            DData.Dtotal = DData.Dchi + DData.Deng + DData.Dmath;
            DData.Daver = DData.Dtotal / 3;
            NData.Insert(0, DData);

            GetBig();
            GetSmall();
            SData.Dbig = Big;
            SData.Dsmal = Small;
            SSData.Insert(0,SData);

            showData();

            J++;
            //呼叫方法找出最高及最低的成績並將輸入的資料寫進集合的第一個元素
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SSData.RemoveAt(0);
            NData.RemoveAt(0);
            showData();
            //移除集合內第一筆資料
        }

        private void btnRadd_Click(object sender, EventArgs e)
        {
            Radd();
            //呼叫方法Radd
        }

        private void btnRadd20_Click(object sender, EventArgs e)
        {
            for (i = 0; i <20;i++)
                Radd();

            //呼叫20次Radd加入隨機資料
            
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            btnmath.Enabled = false;
            label6.Text = "";
            NData.Clear();
            SSData.Clear();
            showData();
            J = 1;
            //清除各集合資料
        }

        void showData()
        {
            label5.Text = $"{LTXT}\n";
            for (int i = 0; i < NData.Count; i++)
            {
                label5.Text += $"{((ScoreData)NData[i]).DName.PadRight(15)}" +
                    $"{((ScoreData)NData[i]).Dchi.ToString().PadRight(15)}" +
                    $"{((ScoreData)NData[i]).Deng.ToString().PadRight(15)}" +
                    $"{((ScoreData)NData[i]).Dmath.ToString().PadRight(15)}" +
                    $"{((ScoreData)NData[i]).Dtotal.ToString().PadRight(15)}" +
                    $"{((ScoreData)NData[i]).Daver.ToString().PadRight(15)}" +
                    $"{((ScoreArer)SSData[i]).DBsub}" +
                    $"{((ScoreArer)SSData[i]).Dbig.ToString().PadRight(15)}" +
                    $"{((ScoreArer)SSData[i]).DSsub}" +
                    $"{((ScoreArer)SSData[i]).Dsmal}\n";
            }
            //顯示集合內的資料
        }

        private void btnmath_Click(object sender, EventArgs e)
        {
            AData.Clear();
            label6.Text = "";
            GetSS();
            for (i = 0; i < AData.Count; i++)
            {
                label6.Text += $"{DSUB[i]}{"",-12:D}{ ((ScoreAData)AData[i]).Csub}{"",-10:D}" +
                    $"{((ScoreAData)AData[i]).Esub}{"",-10:D}{((ScoreAData)AData[i]).Msub}\n";
            }
            //清除集合內的資料並呼叫方法GetSS加入元素並顯示儲存的成績元素
        }
        
        void GetSS()
        {
            int CHI = 0;
            int ENG = 0;
            int MATH = 0;
            for (i = 0; i<NData.Count; i++)
            {
                CHI += ((ScoreData) NData[i]).Dchi;
                ENG  += ((ScoreData) NData[i]).Deng;
                MATH += ((ScoreData) NData[i]).Dmath;
            }
            ADData.Csub = CHI;
            ADData.Esub = ENG;
            ADData.Msub = MATH;
            AData.Add(ADData);
            ADData.Csub = CHI / i ;
            ADData.Esub = ENG / i;
            ADData.Msub = MATH / i;
            AData.Add(ADData);
            //計算各科總分及平均
            GetMax();
            GetLess();

            
        }
       
        void  GetLess()
        {
            CLess = ((ScoreData)NData[0]).Dchi;
            ELess = ((ScoreData)NData[0]).Deng;
            MLess = ((ScoreData)NData[0]).Dmath;
            for (i = 0; i < NData.Count; i++)
            {
                if (CLess > ((ScoreData)NData[i]).Dchi)
                    CLess = ((ScoreData)NData[i]).Dchi;
                if (ELess > ((ScoreData)NData[i]).Deng)
                    ELess = ((ScoreData)NData[i]).Deng;
                if (MLess > ((ScoreData)NData[i]).Dmath)
                    MLess = ((ScoreData)NData[i]).Dmath;
                ADData.Csub = CLess;
                ADData.Esub = ELess;
                ADData.Msub = MLess;
            }
            AData.Add(ADData);
            //找出各科目最低成績
        }
        void GetMax()
        {
            CMax = ((ScoreData)NData[0]).Dchi;
            EMax = ((ScoreData)NData[0]).Deng;
            MMax = ((ScoreData)NData[0]).Dmath;
            for (i = 0; i < NData.Count; i++)
            {
                if (CMax < ((ScoreData)NData[i]).Dchi)
                    CMax = ((ScoreData)NData[i]).Dchi;
                if (EMax < ((ScoreData)NData[i]).Deng)
                    EMax = ((ScoreData)NData[i]).Deng;
                if (MMax < ((ScoreData)NData[i]).Dmath)
                    MMax = ((ScoreData)NData[i]).Dmath;
                ADData.Csub = CMax;
                ADData.Esub = EMax;
                ADData.Msub = MMax;
            }
            AData.Add(ADData);
            //找出各科目最高成績
        }
        void GetSmall()
        {
            K = NData.Count - 1;
            if (((ScoreData)NData[K]).Dchi < ((ScoreData)NData[K]).Deng)
            {
                if (((ScoreData)NData[K]).Dchi< ((ScoreData)NData[K]).Dmath)
                {
                    Small = ((ScoreData)NData[K]).Dchi;
                    SData.DSsub = SUB[1];
                }
                else
                {
                    Small = ((ScoreData)NData[K]).Dmath;
                    SData.DSsub = SUB[3];
                }
            }
            else if (((ScoreData)NData[K]).Deng < ((ScoreData)NData[K]).Dmath)
            {
                Small = ((ScoreData)NData[K]).Deng;
                SData.DSsub = SUB[2];
            }
            else
            {
                Small = ((ScoreData)NData[K]).Dmath;
                SData.DSsub = SUB[3];
            }
            //找出最低科目及成績
        }
        void GetBig()
        {
            K = NData.Count - 1;
            if (((ScoreData)NData[K]).Dchi > ((ScoreData)NData[K]).Deng)
            {
                if (((ScoreData)NData[K]).Dchi  > ((ScoreData)NData[K]).Dmath)
                {
                    Big = ((ScoreData)NData[K]).Dchi ;
                    SData.DBsub = SUB[1];
                }
                else
                {
                    Big = ((ScoreData)NData[K]).Dmath;
                    SData.DBsub = SUB[3];
                }
            }
            else if (((ScoreData)NData[K]).Deng > ((ScoreData)NData[K]).Dmath)
            {
                Big = ((ScoreData)NData[K]).Deng;
                SData.DBsub = SUB[2];
            }
            else
            {
                Big = ((ScoreData)NData[K]).Dmath;
                SData.DBsub = SUB[3];
            }
            //找出最高科目及成績
        }


        public void Gbox1()
        {
            groupBox1.Visible = true;
            //顯示HW_06 group box
        }
    }
}
