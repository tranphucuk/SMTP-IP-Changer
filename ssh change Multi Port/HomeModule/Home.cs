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
using System.IO;
using System.Threading;
using ssh_change_Multi_Port.Static;

namespace ssh_change_Multi_Port.HomeModule
{
    public partial class Home : DevExpress.XtraEditors.XtraUserControl
    {
        public Home()
        {
            InitializeComponent();
            seThread_EditValueChanged(seThread.Value, null);
            gridView1.Columns["ID"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["ID"].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Columns["HostName"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["HostName"].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Columns["Status"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["Status"].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Columns["ID"].Width = 20;
            sbStop.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
            changeMultiThread.UpdateStatusByID += ChangeMultiThread_UpdateStatusByID1;
            changeMultiThread.UpdateSshUsed += ChangeMultiThread_UpdateSshUsed;
            changeMultiThread.StopThreadByID += ChangeMultiThread_StopThreadByID;
        }

        private void ChangeMultiThread_StopThreadByID(object sender, StopThreadEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                var tasks = gridControl1.DataSource as List<AddThreadToGridControl>;
                var targetTask = tasks.FirstOrDefault(t => t.ID == e.ID);
                if (targetTask != null)
                {
                    targetTask.ID = e.ID;
                    targetTask.Status = e.Status;
                    gridControl1.RefreshDataSource();
                }
            }));
        }

        private void ChangeMultiThread_UpdateSshUsed(object sender, SshUsedCountEventArgs e)
        {
            try
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    teSshUsed.Text = e.SshUsed.ToString();
                }));
            }
            catch { }
        }

        private void ChangeMultiThread_UpdateStatusByID1(object sender, AddThreadToGridControl e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                var source = gridControl1.DataSource as List<AddThreadToGridControl>;
                var targetTask = source.FirstOrDefault(s => s.ID == e.ID);
                if (targetTask != null)
                {
                    targetTask.HostName = e.HostName;
                    targetTask.Status = e.Status;
                    gridControl1.RefreshDataSource();
                }
            }));
        }

        private List<SshDetails> listSsh;
        private ChangeMultiThread changeMultiThread = new ChangeMultiThread();

        private void sbImportSsh_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Title = "SSH File";
            ofd.Filter = "SSH File|*.txt";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.Cancel) return;
            teImportPath.Text = ofd.FileName;
            var sshFile = File.ReadAllLines(ofd.FileName);
            listSsh = new List<SshDetails>();
            var builder = new StringBuilder();
            foreach (var item in sshFile)
            {
                var ssh = new SshDetails();
                var splitLine = item.Split('|');
                ssh.Host = splitLine[0];
                ssh.Username = splitLine[1];
                ssh.Password = splitLine[2];
                builder.AppendLine($"{ssh.Host}|{ssh.Username}|{ssh.Password}");
                listSsh.Add(ssh);
            }
            teTotalSsh.Text = listSsh.Count().ToString();
            File.WriteAllText(SettingStatic.Instance.sshUnused, builder.ToString());
            sbStop.Enabled = false;
            changeMultiThread.sshUSed.Clear();
        }

        private void sbChangeSsh_Click(object sender, EventArgs e)
        {
            var listSsh = GetListSshFromFile().ToList();
            if (listSsh.Count == 0)
            {
                XtraMessageBox.Show("SSH File is Empty.\nPlease Check Path: 'SshFolder\\SSH Unused.txt'", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sbStop.Enabled = true;
            new Thread(() =>
            {
                changeMultiThread.ChangeSsh(new InfoRun()
                {
                    ListSsh = listSsh,
                    Thread = Convert.ToInt32(seThread.Value),
                    TimeOut = Convert.ToInt32(seTimeOut.Value)
                });
            })
            { IsBackground = true }.Start();
        }

        private IEnumerable<SshDetails> GetListSshFromFile()
        {
            var fileSsh = File.ReadAllLines(SettingStatic.Instance.sshUnused);
            foreach (var item in fileSsh)
            {
                var ssh = new SshDetails();
                var split = item.Split('|');
                ssh.Host = split[0];
                ssh.Username = split[1];
                ssh.Password = split[2];
                yield return ssh;
            }
        }

        private void sbStop_Click(object sender, EventArgs e)
        {
            sbStop.Enabled = true;
            changeMultiThread.isStopped = true;
            //sbStop.Enabled = changeMultiThread.isStopped == false ? false : true;
            if (changeMultiThread.isStopped == true)
            {
                new Thread(() =>
                {
                    changeMultiThread.StopChangeSsh(new InfoRun()
                    {
                        Thread = Convert.ToInt32(seThread.Value),
                    });
                    changeMultiThread.isStopped = !changeMultiThread.isStopped;
                    sbStop.Enabled = changeMultiThread.isStopped == false ? false : true;
                })
                { IsBackground = true }.Start();
            }
        }

        private void seThread_EditValueChanged(object sender, EventArgs e)
        {
            var listTasks = new List<AddThreadToGridControl>();
            for (int i = 0; i < seThread.Value; i++)
            {
                listTasks.Add(new AddThreadToGridControl()
                {
                    HostName = "Waiting...",
                    ID = i + 1,
                    Status = "Ready"
                });
                gridControl1.DataSource = listTasks;
                gridControl1.RefreshDataSource();
            }
        }
    }
}
