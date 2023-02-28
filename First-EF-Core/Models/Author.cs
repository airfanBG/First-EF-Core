using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_EF_Core.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public List<AuthorBooks> AuthorBooks { get; set; }
    }
}
