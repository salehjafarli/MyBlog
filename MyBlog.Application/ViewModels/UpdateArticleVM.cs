using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.ViewModels
{
    public class UpdateArticleVM
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string MainImage { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
