using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ssh_change_Multi_Port.Static
{
    class SettingStatic
    {
        private static SettingStatic _instance;
        public static SettingStatic Instance => _instance == null ? _instance = new SettingStatic() : _instance;
        public string sshFolder = Application.StartupPath + "\\sshFolder\\";
        public string sshUsed = Application.StartupPath + "\\sshFolder\\SSH Used.txt";
        public string sshUnused = Application.StartupPath + "\\sshFolder\\SSH Unused.txt";

        public IEnumerable<string> LoadSshFileToLookUpEdit()
        {
            var listFiles = new DirectoryInfo(sshFolder).GetFiles("*.txt");
            foreach (var item in listFiles)
                yield return item.Name;
        }

        public void CheckFileIfNotExist()
        {
            while (!Directory.Exists(sshFolder))
            {
                Directory.CreateDirectory(sshFolder);
            }
            while (!File.Exists(sshUsed))
            {
                File.Create(sshUsed);
            }
            while (!File.Exists(sshUnused))
            {
                File.Create(sshUnused);
            }
        }

    }
}
