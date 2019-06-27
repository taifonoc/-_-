using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 滑鼠點擊_練習
{
    public partial class Form1 : Form
    {
        int times = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            times++;
            lebal.Text = "你已經按了 " + times + "下";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            times = 0;
            lebal.Text = "你已經按了 0下";
        }
    }
}
