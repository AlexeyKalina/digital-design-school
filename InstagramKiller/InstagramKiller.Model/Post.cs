﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramKiller.Model
{
    class Post
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public byte[] Photo { get; set; }
        public string Description { get; set; }

    }
}
