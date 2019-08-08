using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace translator
{
    public partial class Share : Form
    {

        //public MainForm mf = new MainForm();

        public Share()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }



        private void btn_twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/");
            this.Close();
        }

        private void btn_facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
            this.Close();
        }

        private void btn_mixi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mixi.jp/");
            this.Close();
        }

        private void btn_ameba_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ameba.jp/");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }

}
