using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.ValueObjects
{
    public class Section : ValueObject
    {
        public string Header { get; set; }
        public string Paragraph { get; set; }
        public byte[] Image { get; set; }
    }
}
