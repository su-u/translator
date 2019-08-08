namespace translator
{
    partial class Share
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
            this.btn_twitter = new System.Windows.Forms.Button();
            this.btn_facebook = new System.Windows.Forms.Button();
            this.btn_mixi = new System.Windows.Forms.Button();
            this.btn_ameba = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_twitter
            // 
            this.btn_twitter.Location = new System.Drawing.Point(50, 116);
            this.btn_twitter.Name = "btn_twitter";
            this.btn_twitter.Size = new System.Drawing.Size(75, 23);
            this.btn_twitter.TabIndex = 0;
            this.btn_twitter.Text = "Twitter";
            this.btn_twitter.UseVisualStyleBackColor = true;
            this.btn_twitter.Click += new System.EventHandler(this.btn_twitter_Click);
            // 
            // btn_facebook
            // 
            this.btn_facebook.Location = new System.Drawing.Point(146, 116);
            this.btn_facebook.Name = "btn_facebook";
            this.btn_facebook.Size = new System.Drawing.Size(75, 23);
            this.btn_facebook.TabIndex = 1;
            this.btn_facebook.Text = "Facebook";
            this.btn_facebook.UseVisualStyleBackColor = true;
            this.btn_facebook.Click += new System.EventHandler(this.btn_facebook_Click);
            // 
            // btn_mixi
            // 
            this.btn_mixi.Location = new System.Drawing.Point(251, 116);
            this.btn_mixi.Name = "btn_mixi";
            this.btn_mixi.Size = new System.Drawing.Size(75, 23);
            this.btn_mixi.TabIndex = 2;
            this.btn_mixi.Text = "mixi";
            this.btn_mixi.UseVisualStyleBackColor = true;
            this.btn_mixi.Click += new System.EventHandler(this.btn_mixi_Click);
            // 
            // btn_ameba
            // 
            this.btn_ameba.Location = new System.Drawing.Point(348, 116);
            this.btn_ameba.Name = "btn_ameba";
            this.btn_ameba.Size = new System.Drawing.Size(75, 23);
            this.btn_ameba.TabIndex = 3;
            this.btn_ameba.Text = "Ameba";
            this.btn_ameba.UseVisualStyleBackColor = true;
            this.btn_ameba.Click += new System.EventHandler(this.btn_ameba_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 87);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Share
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_ameba);
            this.Controls.Add(this.btn_mixi);
            this.Controls.Add(this.btn_facebook);
            this.Controls.Add(this.btn_twitter);
            this.Name = "Share";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_twitter;
        private System.Windows.Forms.Button btn_facebook;
        private System.Windows.Forms.Button btn_mixi;
        private System.Windows.Forms.Button btn_ameba;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}