using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_ASP.NET.Models
{
    public class ArticlesModel
    {
        public string title { get; set; }
        public string intro { get; set; }
        public string author { get; set; }

        public ArticlesModel(string title, string intro, string author)
        {
            this.title = title;
            this.intro = intro;
            this.author = author;
        }
    }
}