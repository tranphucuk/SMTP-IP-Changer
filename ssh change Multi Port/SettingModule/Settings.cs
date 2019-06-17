using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ssh_change_Multi_Port.Properties;
using ssh_change_Multi_Port.Static;
using System.IO;
using System.Diagnostics;

namespace ssh_change_Multi_Port.SettingModule
{
    public partial class Settings : DevExpress.XtraEditors.XtraUserControl
    {
        public Settings()
        {
            InitializeComponent();
            LoadDefaultData();
        }

        public void LoadDefaultData()
        {
            SettingStatic.Instance.CheckFileIfNotExist();
            teSshUsed.Text = SettingStatic.Instance.sshUsed;
            teSshUnused.Text = SettingStatic.Instance.sshUnused;
        }

        private void sbSshUsedFolder_Click(object sender, EventArgs e)
        {
            Process.Start(SettingStatic.Instance.sshUsed);
        }

        private void sbSshUnusedFolder_Click(object sender, EventArgs e)
        {
            Process.Start(SettingStatic.Instance.sshUnused);
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            Process.Start("https://bit.ly/2KAqHf2");
        }
    }
}
