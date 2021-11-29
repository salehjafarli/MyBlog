using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Commands.Article
{
    public class CreateArticleCommand : ICommand
    {
        public string Header { get; set; }
        public string MainImage { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
