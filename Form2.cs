using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Collections;

namespace HariboteShortcut
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            stg = new Properties.Settings();
            cfgpath.Text = stg.settingPath;
            if (File.Exists(stg.settingPath))
            {
                cfg_ref(stg.settingPath);
            }
            else
            {
                MessageBox.Show("設定ファイルが見つかりません。\n" +
                                "設定ファイルを開くか新規作成してください。");
            }
        }
        Properties.Settings stg;
        List<ShortcutData> sd;
        Type stype = typeof(List<ShortcutData>);
        bool isDontSave = false;

        private void cfgpath_TextChanged(object sender, EventArgs e)
        {
            stg.settingPath = cfgpath.Text;
            stg.Save();
        }

        private void cfg_ref(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cfg_ref(openFileDialog1.FileName);
            }
        }
        private void cfg_ref(string fp)
        {
            
                FileStream fs;
                cfgpath.Text = fp;

                if (File.Exists(fp))
                {
                    fs = File.OpenRead(fp);
                }
                else
                {
                    fs = File.Create(fp);
                }
                var xs = new XmlSerializer(stype);
                int count = 0;
            onm:;
                try
                {
                    sd = (List<ShortcutData>)xs.Deserialize(fs);
                }
                catch
                {
                    if(count == 1)
                    {
                        MessageBox.Show("新規ファイルの初期化に失敗しました。\n" +
                                        "あきらめてください。");
                        return;
                    }
                    fs.Close();
                    fs = File.OpenWrite(fp);
                    var nsd = new List<ShortcutData>();
                    xs.Serialize(fs,nsd);
                    fs.Close();
                    fs = File.OpenRead(fp);
                    count++;
                    goto onm;
                }
                slist.Items.Clear();
                foreach (ShortcutData row in sd)
                {
                    slist.Items.Add(new Liststr(row));
                }
            fs.Close();
        }

        private void slist_SelectedIndexChanged(object sender, EventArgs e)
        {
            isDontSave = true;
            fpi.Text = ((Liststr)slist.SelectedItem).c.FileName;
            ari.Text = ((Liststr)slist.SelectedItem).c.Arguments;
            isDontSave = false;
        }

        private void propc(object sender, EventArgs e)
        {
            if (isDontSave) return;
            if(slist.SelectedItem != null)
            {
                ((Liststr)slist.SelectedItem).c.FileName = fpi.Text;
                ((Liststr)slist.SelectedItem).c.Arguments = ari.Text;
                List<ShortcutData> ret = new List<ShortcutData>();
                foreach(Liststr r in slist.Items)
                {
                    ret.Add(r.c);
                }
                var xs = new XmlSerializer(stype);
                var fs = new FileStream(stg.settingPath, FileMode.Create);
                xs.Serialize(fs, ret);
                fs.Close();
            }
        }
    }
    public class Liststr
    {
        public ShortcutData c;
        public Liststr(ShortcutData ca)
        {
            c = ca;
        }
        public override string ToString()
        {
             return c.ShortcutName; 
            
        }
    }
}
