using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.VisualBasic;// 입력값이 숫자인지를 확인하는 IsNumeric를 위해 추가

namespace Timer
{
    public partial class Form1 : Form
    {
        int CountOrgNum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            if(IntCheck())
            {
                CountOrgNum = Convert.ToInt32(this.txtNum.Text);
                this.txtNum.ReadOnly = true;
                this.Timer.Enabled = true;
            }
        }

        private bool IntCheck()
        {
            if (Information.IsNumeric(this.txtNum.Text)) //넣어준게 숫자인지 아닌지 판단함
            {
                return true;
            }
            else
            {
                MessageBox.Show("숫자를 입력하세요", "알림"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(CountOrgNum < 1)
            {
                this.Timer.Enabled = false;
                this.txtNum.ReadOnly = false;
                this.txtNum.Text = "";
                MessageBox.Show("펑!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CountOrgNum--;
                this.txtCountdown.Text = Convert.ToString(CountOrgNum);
            }
        }
    }
}
