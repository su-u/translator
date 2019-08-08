namespace translator
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.m_txtbox_1 = new System.Windows.Forms.RichTextBox();
            this.btb_sh = new System.Windows.Forms.Button();
            this.btn_word_size = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_tr = new System.Windows.Forms.Button();
            this._comboFrom = new System.Windows.Forms.ComboBox();
            this._comboTo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(425, 98);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(312, 321);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // m_txtbox_1
            // 
            this.m_txtbox_1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.m_txtbox_1.Location = new System.Drawing.Point(36, 98);
            this.m_txtbox_1.Name = "m_txtbox_1";
            this.m_txtbox_1.Size = new System.Drawing.Size(315, 321);
            this.m_txtbox_1.TabIndex = 17;
            this.m_txtbox_1.Text = "";
            this.m_txtbox_1.TextChanged += new System.EventHandler(this.m_txtbox_1_TextChanged);
            // 
            // btb_sh
            // 
            this.btb_sh.Location = new System.Drawing.Point(572, 448);
            this.btb_sh.Name = "btb_sh";
            this.btb_sh.Size = new System.Drawing.Size(75, 38);
            this.btb_sh.TabIndex = 16;
            this.btb_sh.Text = "共有";
            this.btb_sh.UseVisualStyleBackColor = true;
            this.btb_sh.Click += new System.EventHandler(this.btb_sh_Click);
            // 
            // btn_word_size
            // 
            this.btn_word_size.Location = new System.Drawing.Point(444, 448);
            this.btn_word_size.Name = "btn_word_size";
            this.btn_word_size.Size = new System.Drawing.Size(113, 38);
            this.btn_word_size.TabIndex = 15;
            this.btn_word_size.Text = "文字サイズを変更";
            this.btn_word_size.UseVisualStyleBackColor = true;
            this.btn_word_size.Click += new System.EventHandler(this.btn_word_size_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(370, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 60);
            this.button5.TabIndex = 14;
            this.button5.Text = "→";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_tr
            // 
            this.btn_tr.Location = new System.Drawing.Point(662, 448);
            this.btn_tr.Name = "btn_tr";
            this.btn_tr.Size = new System.Drawing.Size(75, 38);
            this.btn_tr.TabIndex = 21;
            this.btn_tr.Text = "テキスト読み取り";
            this.btn_tr.UseVisualStyleBackColor = true;
            this.btn_tr.Click += new System.EventHandler(this.btn_tr_Click);
            // 
            // _comboFrom
            // 
            this._comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFrom.FormattingEnabled = true;
            this._comboFrom.Items.AddRange(new object[] {
            "Japanese",
            "English",
            "Chinese",
            "Korean",
            "Russia"});
            this._comboFrom.Location = new System.Drawing.Point(146, 56);
            this._comboFrom.Name = "_comboFrom";
            this._comboFrom.Size = new System.Drawing.Size(121, 20);
            this._comboFrom.TabIndex = 22;
            this._comboFrom.SelectedIndexChanged += new System.EventHandler(this._comboFrom_SelectedIndexChanged);
            this._comboFrom.SelectedItem = "Japanese";
            // 
            // _comboTo
            // 
            this._comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboTo.FormattingEnabled = true;
            this._comboTo.Items.AddRange(new object[] {
            "Japanese",
            "English",
            "Chinese",
            "Korean",
            "Russia"});
            this._comboTo.Location = new System.Drawing.Point(509, 56);
            this._comboTo.MaxDropDownItems = 20;
            this._comboTo.Name = "_comboTo";
            this._comboTo.Size = new System.Drawing.Size(127, 20);
            this._comboTo.TabIndex = 23;
            this._comboTo.SelectedIndexChanged += new System.EventHandler(this._comboTo_SelectedIndexChanged);
            this._comboTo.SelectedItem = "English";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this._comboTo);
            this.Controls.Add(this._comboFrom);
            this.Controls.Add(this.btn_tr);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.m_txtbox_1);
            this.Controls.Add(this.btb_sh);
            this.Controls.Add(this.btn_word_size);
            this.Controls.Add(this.button5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btb_sh;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_tr;
        public System.Windows.Forms.RichTextBox richTextBox2;
        public System.Windows.Forms.RichTextBox m_txtbox_1;
        public System.Windows.Forms.Button btn_word_size;
        private System.Windows.Forms.ComboBox _comboFrom;
        private System.Windows.Forms.ComboBox _comboTo;
    }
}