using Domain.Models;
using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Controller
{
    public class MyListController
    {

        
       public void Add1()
        {
            MyList<ListService> list = new MyList<ListService>();
            ListService list1 = new ListService("Crime and Punishment", "Dostoevsky");
            ListService list2 = new ListService("Taras Bulba", "Nikolai Gogol");
            ListService list3 = new ListService("War and Peace", "Leo Tolstoy");
            list.Add(list1);
            list.Add(list2);    
            list.Add(list3);
            foreach (var item in list.GetAll())
            {
                Console.Write(item.BookName+"-");
                Console.WriteLine(item.BookAuthor);
              
            }
        }


        public void Clear1()
        {
            MyList<ListService> list = new MyList<ListService>();
            ListService list1 = new ListService("Crime and Punishment", "Dostoevsky");
            ListService list2 = new ListService("Taras Bulba", "Nikolai Gogol");
            ListService list3 = new ListService("War and Peace", "Leo Tolstoy");
            list.Add(list1);
            list.Add(list2);
            list.Add(list3);
            foreach (var item in list.GetAll())
            {
                _ = item == null;
                Console.WriteLine(item);

            }

        }

        public void Find1()
        {
            MyList<ListService> list = new MyList<ListService>();
            ListService list1 = new ListService("Crime and Punishment", "Dostoevsky");
            ListService list2 = new ListService("Taras Bulba", "Nikolai Gogol");
            ListService list3 = new ListService("War and Peace", "Leo Tolstoy");
            list.Add(list1);
            list.Add(list2);
            list.Add(list3);
            int count = 0;
            foreach (var item in list.GetAll())
            {
                if (item.BookName == "Crime and Punishment" && item.BookAuthor == "Dostoevsky")
                {
                    count++;
                    Console.WriteLine(count);
                }
            }

        }


        public void FindAll1()
        {
            MyList<ListService> list = new MyList<ListService>();
            ListService list1 = new ListService("Crime and Punishment", "Dostoevsky");
            ListService list2 = new ListService("Taras Bulba", "Nikolai Gogol");
            ListService list3 = new ListService("War and Peace", "Leo Tolstoy");
            list.Add(list1);
            list.Add(list2);
            list.Add(list3);
            int count = 0;
            foreach (var item in list.GetAll())
            {
               count++;
               Console.WriteLine(count);                
            }

        }















        





    }

    }

