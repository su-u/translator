using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.IO;
using System.Net;



namespace translator
{
    public partial class MainForm : Form
    {
        public Txtread tr = new Txtread();
        public Share sh = new Share();

        public MainForm()
        {
            //this._comboFrom.SelectedItem = "Japanese";
            //this._comboFrom.SelectedItem = "English";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }
    

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btn_sh_Click(object sender, EventArgs e)
        {
            sh.textBox1.Text = this.richTextBox2.Text;
            sh.ShowDialog();
        }

        private void btn_tr_Click(object sender, EventArgs e)
        {
            tr.ShowDialog();
            this.m_txtbox_1.Text = tr.readtxt;
        }

        private void btb_sh_Click(object sender, EventArgs e)
        {
            sh.ShowDialog();
        }

        public void m_txtbox_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_word_size_Click(object sender, EventArgs e)
        {
            Font orgf = this.m_txtbox_1.Font;
            if (orgf.Size == 10)
            {
                Font f = new Font(orgf.FontFamily, 20);
                this.m_txtbox_1.Font = f;
                this.richTextBox2.Font = f;
            }
            else if (orgf.Size == 20)
            {
                Font f = new Font(orgf.FontFamily, 40);
                this.m_txtbox_1.Font = f;
                this.richTextBox2.Font = f;
            }
            else if (orgf.Size == 40)
            {
                Font f = new Font(orgf.FontFamily, 10);
                this.m_txtbox_1.Font = f;
                this.richTextBox2.Font = f;
            }
        }

        private void _comboTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _comboFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
           //this._comboFrom.SelectedItem = "English";
        }

        public string translation;

        private void button5_Click(object sender, EventArgs e)
        {
            //string soucelang = ;
            //string 
            this.richTextBox2.Text = string.Empty;
            string translation = string.Empty;


            string url = string.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                                                urllangage(this._comboFrom.Text),
                                                urllangage(this._comboTo.Text),
                                                HttpUtility.UrlEncode (this.m_txtbox_1.Text));
            string dlfile = Path.GetTempFileName();
            using(WebClient wc = new WebClient()){
                wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                wc.DownloadFile(url, dlfile);
        }
             //                    Get translated text
            if (File.Exists (dlfile)) {

                // Get phrase collection
                string text = File.ReadAllText(dlfile);
                int index = text.IndexOf(string.Format(",,\"{0}\"", urllangage(this._comboFrom.Text)));
                if (index == -1) {
                    // Translation of single word
                    int startQuote = text.IndexOf('\"');
                    if (startQuote != -1) {
                        int endQuote = text.IndexOf('\"', startQuote + 1);
                        if (endQuote != -1) {
                            translation = text.Substring(startQuote + 1, endQuote - startQuote - 1);
                        }
                    }
                }
                else {
                    // Translation of phrase
                    text = text.Substring(0, index);
                    text = text.Replace("],[", ",");
                    text = text.Replace("]", string.Empty);
                    text = text.Replace("[", string.Empty);
                    text = text.Replace("\",\"", "\"");
                           
                    // Get translated phrases
                    string[] phrases = text.Split (new[] { '\"' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i=0; (i < phrases.Count()); i += 2) {
                        string translatedPhrase = phrases[i];
                        if (translatedPhrase.StartsWith(",,")) {
                            i--;
                            continue;
                        }
                        translation += translatedPhrase + "  ";
                    }
                }

                // Fix up translation
                translation = translation.Trim();
                translation = translation.Replace(" ?", "?");
                translation = translation.Replace(" !", "!");
                translation = translation.Replace(" ,", ",");
                translation = translation.Replace(" .", ".");
                translation = translation.Replace(" ;", ";");


                this.richTextBox2.Text = translation;

            }
            ////if (File.Exists(dlfile))
            //{
            //    string tt = File.ReadAllText(dlfile);
                //richTextBox2.Text = text;
            //}
            //richTextBox2.Text = tt;


        }

        private void richTextBox2_TextChanged(object sender, System.EventArgs e)
        {

        }

        private string urllangage(string gengo)
        {
            switch (gengo)
            {
                case "Japanese":
                    return "ja";
                case "English":
                    return "en";
                case "Korean":
                    return "ko";
                case "Russia":
                    return "ru";
                case "Chinese":
                    return "zh-CN";
            }
            return "aaa";
        }




    }
}
