namespace HariboteShortcut
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.slist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cfgpath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cfgdialog = new System.Windows.Forms.OpenFileDialog();
            this.ari = new System.Windows.Forms.TextBox();
            this.fpi = new System.Windows.Forms.TextBox();
            this.sn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ns = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.scfpi = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // slist
            // 
            this.slist.FormattingEnabled = true;
            this.slist.ItemHeight = 12;
            this.slist.Location = new System.Drawing.Point(12, 31);
            this.slist.Name = "slist";
            this.slist.Size = new System.Drawing.Size(196, 220);
            this.slist.TabIndex = 0;
            this.slist.SelectedIndexChanged += new System.EventHandler(this.slist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "今の設定ファイル";
            // 
            // cfgpath
            // 
            this.cfgpath.Location = new System.Drawing.Point(103, 6);
            this.cfgpath.Name = "cfgpath";
            this.cfgpath.Size = new System.Drawing.Size(568, 19);
            this.cfgpath.TabIndex = 2;
            this.cfgpath.TextChanged += new System.EventHandler(this.cfgpath_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "参照";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cfg_ref);
            // 
            // cfgdialog
            // 
            this.cfgdialog.CheckFileExists = false;
            this.cfgdialog.DefaultExt = "hsc";
            this.cfgdialog.Filter = "はりぼてショートカット設定ファイル|*.hsc|すべてのファイル|*.*";
            this.cfgdialog.Title = "設定ファイルを選択";
            // 
            // ari
            // 
            this.ari.Location = new System.Drawing.Point(249, 81);
            this.ari.Name = "ari";
            this.ari.Size = new System.Drawing.Size(463, 19);
            this.ari.TabIndex = 5;
            this.ari.TextChanged += new System.EventHandler(this.propc);
            // 
            // fpi
            // 
            this.fpi.Location = new System.Drawing.Point(278, 56);
            this.fpi.Name = "fpi";
            this.fpi.Size = new System.Drawing.Size(391, 19);
            this.fpi.TabIndex = 6;
            this.fpi.TextChanged += new System.EventHandler(this.propc);
            // 
            // sn
            // 
            this.sn.AutoSize = true;
            this.sn.Location = new System.Drawing.Point(214, 34);
            this.sn.Name = "sn";
            this.sn.Size = new System.Drawing.Size(75, 12);
            this.sn.TabIndex = 7;
            this.sn.Text = "ショートカット名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "ファイルパス";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "引数";
            // 
            // ns
            // 
            this.ns.Location = new System.Drawing.Point(12, 257);
            this.ns.Name = "ns";
            this.ns.Size = new System.Drawing.Size(153, 19);
            this.ns.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 19);
            this.button2.TabIndex = 11;
            this.button2.Text = "追加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.add);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 19);
            this.button3.TabIndex = 12;
            this.button3.Text = "削除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.del);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(675, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 19);
            this.button4.TabIndex = 13;
            this.button4.Text = "参照";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.fr);
            // 
            // scfpi
            // 
            this.scfpi.Filter = "全てのファイル|*.*";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sn);
            this.Controls.Add(this.fpi);
            this.Controls.Add(this.ari);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cfgpath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(740, 489);
            this.MinimumSize = new System.Drawing.Size(740, 489);
            this.Name = "Form2";
            this.Text = "はりぼてショートカット設定画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox slist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cfgpath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog cfgdialog;
        private System.Windows.Forms.TextBox ari;
        private System.Windows.Forms.TextBox fpi;
        private System.Windows.Forms.Label sn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ns;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog scfpi;
    }
}