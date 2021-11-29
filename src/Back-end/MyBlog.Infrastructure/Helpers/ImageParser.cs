using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Infrastructure.Helpers
{
    public static class ImageParser
    {
        public static byte[] Parse(string path)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                return Array.Empty<byte>();
            }
            var img = Image.FromFile(path);
            using (var ms = new MemoryStream())
            { 
                img.Save(ms,img.RawFormat);
                return ms.ToArray();

            }
        }
    }
}
