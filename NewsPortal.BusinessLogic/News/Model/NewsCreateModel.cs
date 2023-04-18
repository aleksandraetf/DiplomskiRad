using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.BusinessLogic.News.Model
{
    public class NewsCreateModel
    {
        [Required]
        public string Text { get; set; }
    }
}
