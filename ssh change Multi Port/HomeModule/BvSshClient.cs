using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thanhps42.BvSsh;

namespace ssh_change_Multi_Port.HomeModule
{
    public class BvSshClient : BvSshHelper
    {
        private string exePath;
        private string profilePath;
        public BvSshClient(string exe, string profile, object oAutoIt) : base(exe, profile, oAutoIt)
        {
            this.exePath = exe;
            this.profilePath = profile;
        }
    }
}
