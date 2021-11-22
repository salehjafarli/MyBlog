using MyBlog.Domain.Events;
using MyBlog.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Entites
{
    public class Article : Entity, IAggregateRoot
    {
        public string  Header { get; set; }
        public string MainImage { get;set; }
        public string Description { get; set; }
        public List<Section> Sections { get; set; }
        public DateTime Date { get; set; }

    }
}
