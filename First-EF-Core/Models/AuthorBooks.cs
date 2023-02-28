﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_EF_Core.Models
{
    public class AuthorBooks
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
