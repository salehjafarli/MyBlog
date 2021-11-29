using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyBlog.Domain.ValueObjects
{
    public class Section : ValueObject
    {
        public string Header { get; set; }
        [XmlIgnore]
        public byte[] Image { get; set; }
        public string ImagePath { get; set; }
        public string Paragraph { get; set; }
    }
}
