using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Library
    {
        public int ID { get; set; }

        public string? Name { get; set; }
        public List<Book> ? Books {get; set;}

    }
}
