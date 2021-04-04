using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_file
{
    public class y_upload : y<y_upload.o>
    {
        public override string z_xid => all_command.x_file;
        public override string z_yid => nameof(y_upload);
        public string file_id { get; set; }
        public string upload_id { get; set; }
        public long offset { get; set; }
        public byte[] data { get; set; }
        public class o : o_base<error>
        {
        }
        public enum error
        {
            non,
            invalid_fileid,
            invalid_uploadid
        }
    }
}
