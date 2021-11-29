using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Responses
{
    public class SectionResponse
    {
        public string Header { get; set; }
        public byte[] Image { get; set; }
        public string Paragraph { get; set; }
    }
}
