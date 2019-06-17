using ssh_change_Multi_Port.HomeModule;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssh_change_Multi_Port.Static
{
    class HomeStatic
    {
        private static HomeStatic _instance;
        public static HomeStatic Instance => _instance == null ? _instance = new HomeStatic() : _instance;

        public void RunAutoControlIfNotExist()
        {
            var process = Process.GetProcessesByName("autocontrol");
            if (process.Count() != 0) return;
            Process.Start("autocontrol.exe");
        }

        public void WriteSshToFile(List<SshDetails> listSsh, string path)
        {
            var builder = new StringBuilder();
            foreach (var item in listSsh)
            {
                var ssh = new SshDetails();
                builder.AppendLine($"{item.Host}|{item.Username}|{item.Password}");
            }
            File.WriteAllText(path, builder.ToString());
        }

        public void KillBvSsh()
        {
            var processes = Process.GetProcessesByName("BvSsh");
            try
            {
                while (processes.Count() > 0)
                    processes.ToList().ForEach(bvs => bvs.Kill());
            }
            catch
            {
            }
        }

        public void KillAutoControl()
        {
            var processes = Process.GetProcessesByName("autocontrol");
            try
            {
                while (processes.Count() > 0)
                    processes.ToList().ForEach(ac => ac.Kill());
            }
            catch
            {
            }
        }
    }
}
