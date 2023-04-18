using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.BusinessLogic.News.Model
{
    public class NewsViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Date { get; set; }
    }
}
