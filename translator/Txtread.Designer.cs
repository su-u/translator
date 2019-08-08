namespace translator
{
    partial class Txtread
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
            this.t_btn1 = new System.Windows.Forms.Button();
            this.t_btn_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // t_btn_1
            // 
            this.t_btn_1.Location = new System.Drawing.Point(101, 109);
            this.t_btn_1.Name = "t_btn_1";
            this.t_btn_1.Size = new System.Drawing.Size(75, 23);
            this.t_btn_1.TabIndex = 0;
            this.t_btn_1.Text = "ファイルを開く";
            this.t_btn_1.UseVisualStyleBackColor = true;
            this.t_btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // Txtread
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.t_btn_1);
            this.Name = "Txtread";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button t_btn1;
        private System.Windows.Forms.Button t_btn_1;
    }
}

