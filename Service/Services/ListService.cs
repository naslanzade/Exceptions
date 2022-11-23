using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ListService
    {
        public string ? BookName { get; set; }
        public string ? BookAuthor { get; set; }

        public ListService(string bookname, string bookauthor)
        {
            BookName= bookname;
            BookAuthor= bookauthor;
        }

    }
}
