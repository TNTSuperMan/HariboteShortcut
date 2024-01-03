namespace HariboteShortcut
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // sid
            // 
            this.sid.AutoCompleteCustomSource.AddRange(new string[] {
            "easing",
            "aviutl",
            "edge"});
            this.sid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.sid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.sid.Location = new System.Drawing.Point(12, 12);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(160, 19);
            this.sid.TabIndex = 0;
            this.sid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kd);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "実行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.execute);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 19);
            this.button2.TabIndex = 2;
            this.button2.Text = "設定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cfgbut);
            // 
            // tbicon
            // 
            this.tbicon.Icon = ((System.Drawing.Icon)(resources.GetObject("tbicon.Icon")));
            this.tbicon.Text = "はりぼてショートカット";
            this.tbicon.Visible = true;
            this.tbicon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 44);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(285, 83);
            this.MinimumSize = new System.Drawing.Size(285, 83);
            this.Name = "Form1";
            this.Text = "はりぼてショートカット";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon tbicon;
    }
}

