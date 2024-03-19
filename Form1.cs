using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace HariboteShortcut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cfg = new Properties.Settings();
            if (File.Exists(cfg.settingPath))
            {
                var reader = new FileStream(cfg.settingPath,FileMode.Open);
                var xs = new XmlSerializer(sdtype);
                try
                {
                    sd = (List<ShortcutData>)xs.Deserialize(reader);
                }
                catch
                {
                    MessageBox.Show("ショートカット設定ファイルの読込に失敗しました。\n" +
                                    "別の設定ファイルを試すか、新規作成してください。");
                    //MessageBox.Show("エラーメッセージ：" + e.Message);
                    return;
                }
                reader.Close();

                sid.AutoCompleteCustomSource.Clear();
                foreach (ShortcutData row in sd)
                {
                    sid.AutoCompleteCustomSource.Add(row.ShortcutName);
                }
            }
            else{
                MessageBox.Show("ショートカット設定ファイルがありません。\n" +
                                "読み込むか、新規作成してください。");
            }
            TopMost = true;
        }
        Type sdtype = typeof(List<ShortcutData>);
        Properties.Settings cfg;
        List<ShortcutData> sd;

        private void kd(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                execute();
            }
        }
        private void execute(object sender = null, EventArgs e = null)
        {
            string s = sid.Text;
            foreach(var row in sd)
            {
                if(row.ShortcutName == s)
                {
                    try
                    {
                        var p = new Process();
                        p.StartInfo.FileName = row.FileName;
                        p.StartInfo.Arguments = row.Arguments;
                        p.Start();
                    }
                    catch
                    {
                        MessageBox.Show("実行するファイルが存在しません。\n" +
                                        "設定ファイルを確認してください。");
                    }
                }
            }
        }

        private void cfgbut(object sender, EventArgs e)
        {
            string apppath = Application.ExecutablePath;
            var p = new Process();
            p.StartInfo.FileName = apppath;
            p.StartInfo.Arguments = "config";
            p.Start();
            Application.Exit();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Focus();
        }
    }
    [Serializable]
    public class ShortcutData
    {
        public string FileName;
        public string Arguments;
        public string ShortcutName;
        public ShortcutData(string shortcutName,string fileName = "", string arguments = "")
        {
            FileName = fileName;
            Arguments = arguments;
            ShortcutName = shortcutName;
        }
        public ShortcutData()
        {
            FileName = string.Empty;
            Arguments = string.Empty;
            ShortcutName = string.Empty;
        }
    }
}
