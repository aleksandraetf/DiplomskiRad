﻿using NewsPortal.DAL.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.DAL.NewsPortal
{
    public partial class News : IBaseEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }

        public virtual User User { get; set; }
    }
}
