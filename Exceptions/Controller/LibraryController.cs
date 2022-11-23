using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Controller
{
    public  class LibraryController
    {
        public static void GetAll()
        {
            var libraries = Add();

            foreach (var liabrary in libraries)
            {
                foreach (var book in liabrary.Books)
                {
                    Console.WriteLine(book.Name);
                }
            }




            
        }



        public static List<Book> GetAllBooksByLiabrary(Predicate<Book> predicate)
        {

            var result = GetAllBook();

            return result.FindAll(predicate);
        }



        private static List<Book> GetAllBook()
        {

            List<Book> books = new List<Book>();

            Book book1 = new Book()
            {
                Name = "Xosrov",
                Author = "Nizami",
                LibraryId = 1
            };

            Book book2 = new Book()
            {
                Name = "Shirin",
                Author = "Nizami",
                LibraryId = 1
            };

            Book book3 = new Book()
            {
                Name = "Shikayetname",
                Author = "Fizuli",
                LibraryId = 2
            };

            Book book4 = new Book()
            {
                Name = "Dede Qorqud",
                Author = "YYY",
                LibraryId = 2
            };

            Book book5 = new Book()
            {
                Name = "7 Gozel",
                Author = "Nizami",
                LibraryId = 2
            };

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);

            return books;

        }





        public static List<Library> Add()
        {
            List<Library> libraries= new List<Library>();

            Book book1 = new Book()
            {
                Name = "Xosrov",
                Author = "Nizami",
                LibraryId = 1
            };

            Book book2 = new Book()
            {
                Name = "Shirin",
                Author = "Nizami",
                LibraryId = 1
            };

            Book book3 = new Book()
            {
                Name = "Shikayetname",
                Author = "Fizuli",
                LibraryId = 2
            };

            Book book4 = new Book()
            {
                Name = "Dede Qorqud",
                Author = "YYY",
                LibraryId = 2
            };

            Book book5 = new Book()
            {
                Name = "7 Gozel",
                Author = "Nizami",
                LibraryId = 2
            };

            List<Book> books1 = new List<Book>() { book1, book2 };

            List<Book> books2 = new List<Book>() { book3, book4,book5 };


            Library library = new Library()
            {
                ID = 1,
                Name = "Axundov",
                Books=books1
            };


            Library library1 = new Library()
            {
                ID = 2,
                Name = "Baku Book Center",
                Books = books2
            };


            libraries.Add(library);
            libraries.Add(library1);

            return libraries;
        }
    }
}
