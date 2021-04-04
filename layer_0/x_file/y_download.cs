using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_file
{
    public class y_download : y<y_download.o>
    {
        public override string z_yid => all_command.x_file;
        public override string z_xid => nameof(y_download);
        public string a_fileid { get; set; }
        public DateTime a_version { get; set; }
        public long a_offset { get; set; }
        public class o : o_base
        {
            public byte[] data { get; set; }
        }
    }
}
