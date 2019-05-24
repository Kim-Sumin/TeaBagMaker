using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        string[] ttList = new string[]{"홍차", "녹차", "루이보스차", "국화차"};
        string org = "";

        int countnum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i<ttList.Length; i++)
            {
                this.TList.Items.Add(ttList[i]);
            }
            this.org = countdown.Text;
            if(TList.Items.Count > 0)
            {
                this.TList.SelectedIndex = 0;
            }
        }

        private void Push_Click(object sender, EventArgs e)
        {
            if (TList.SelectedIndex.Equals("홍차") || TList.Items.Equals("국화차"))
            {
                this.countnum = 60 * 2;
            }
            else if (TList.SelectedIndex.Equals("녹차"))
            {
                this.countnum = 60 * 3;
            }
            else if(TList.SelectedIndex.Equals("루이보스차"))
            {
                this.countnum = 60 * 5;
            }
            this.timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(countnum < 1)
            {
                this.timer.Enabled = false;
                this.countdown.Text = "";
            }
            else
            {
                this.countnum--;
                this.countdown.Text = Convert.ToString(this.countnum);
            }
        }
    }//Form1 : Form
}//namespace