    using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using ssh_change_Multi_Port.HomeModule;
using ssh_change_Multi_Port.LicenseModule;
using ssh_change_Multi_Port.SettingModule;
using ssh_change_Multi_Port.Static;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ssh_change_Multi_Port
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            CheckLicense();
        }

        private void CheckLicense()
        {
            var license = LicenseInfoController.Instance.GetLicense();
            switch (license.Type)
            {
                case LicenseType.Invalid:
                    {
                        var frm = new FrmLicense() { Text = "Invalid Key" };
                        frm.ShowDialog();
                        this.Close();
                        break;
                    }
                case LicenseType.Valid:
                    break;
                case LicenseType.Expired:
                    {
                        var frm = new FrmLicense() { Text = "Key has Expired" };
                        frm.ShowDialog();
                        this.Close();
                        break;
                    }
                default:
                    break;
            }
        }

        private void ChangeModuleTo<T>() where T : UserControl
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            panel2.Controls.Clear();
            var newModule = Activator.CreateInstance<T>();
            panel2.Controls.Add(newModule);
            newModule.Dock = DockStyle.Fill;
            SplashScreenManager.CloseForm(false);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            var quitConfirm = XtraMessageBox.Show("Quit ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (quitConfirm == DialogResult.OK)
            {
                HomeStatic.Instance.KillAutoControl();
                HomeStatic.Instance.KillBvSsh();
                Application.Exit();
            }
        }

        private void lblHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ChangeModuleTo<Home>();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ChangeModuleTo<Settings>();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
