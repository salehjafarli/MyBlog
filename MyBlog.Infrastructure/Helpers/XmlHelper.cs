using MyBlog.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyBlog.Infrastructure.Helpers
{
    public  class XmlHelper
    {
        public XmlHelper(string Path)
        {
            this.Path = Path;
        }

        public string Path { get; }

        public string RawXml { get; private set; }

        public T Extract<T>()
        {
            object resultobj;
            XmlRootAttribute atr = new XmlRootAttribute();
            atr.ElementName = "Sections";
            XmlSerializer serializer = new XmlSerializer(typeof(T),atr);
            using (FileStream strm = File.OpenRead(Path))
            {
                resultobj = serializer.Deserialize(strm);
            }
            return (T)resultobj;

        }



        public void SpecialCharacterReplacer()
        {

        }
    }
}
