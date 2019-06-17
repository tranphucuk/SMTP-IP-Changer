using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssh_change_Multi_Port.HomeModule
{
    public class InfoRun
    {
        public int Thread { get; set; }
        public List<SshDetails> ListSsh { get; set; }
        public int TimeOut { get; set; }
    }
}
