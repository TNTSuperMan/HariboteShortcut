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
            if (cfgdialog.ShowDialog() == DialogResult.OK)
            {
                cfg_ref(cfgdialog.FileName);
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
            if (slist.SelectedItems.Count == 0) return;
            isDontSave = true;
            sn.Text = ((Liststr)slist.SelectedItem).c.ShortcutName;
            fpi.Text = ((Liststr)slist.SelectedItem).c.FileName;
            ari.Text = ((Liststr)slist.SelectedItem).c.Arguments;
            isDontSave = false;
        }

        private void propc(object sender, EventArgs e)
        {
            if (isDontSave) return;
            if(slist.SelectedItems.Count != 0)
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

        private void add(object sender, EventArgs e)
        {
            foreach(var r in slist.Items)
            {
                if(ns.Text == ((Liststr)r).c.ShortcutName)
                {
                    MessageBox.Show("同じショートカット名の\nショートカットがあります。");
                    return;
                }
            }
            if(ns.Text == string.Empty)
            {
                MessageBox.Show("ショートカット名は空にできません。");
                return;
            }
            slist.Items.Add(new Liststr(new ShortcutData(ns.Text)));
            ns.Text = string.Empty;
        }

        private void fr(object sender, EventArgs e)
        {
            if(DialogResult.OK == scfpi.ShowDialog())
            {
                fpi.Text = scfpi.FileName;
            }
        }

        private void del(object sender, EventArgs e)
        {

            if (slist.SelectedItems.Count != 0)
            {
                string sname = ((Liststr)slist.SelectedItem).c.ShortcutName;
                foreach(Liststr r in slist.Items)
                {
                    if(sname == r.c.ShortcutName)
                    {
                        slist.Items.Remove(r);
                    }
                }
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
