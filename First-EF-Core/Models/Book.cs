using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_EF_Core.Models
{
    public class Book
    {
      public int Id { get; set; }
      
      public string Title { get; set; }
      public List<AuthorBooks> AuthorBooks { get; set; }
    }
}
