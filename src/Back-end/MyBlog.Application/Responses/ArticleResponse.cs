using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Responses
{
    public class ArticleResponse
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public byte[] MainImage { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public List<SectionResponse> Sections { get; set; }
        public DateTime Date { get; set; }
    }
}
