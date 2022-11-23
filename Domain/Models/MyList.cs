using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class MyList<T>: BaseEntity
    {
        
        public T[] list;
       
        public MyList()
        {
            list = new T[0];         
        }


        public void Add(T item)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = item;

        }
        
        public T[] GetAll()
        {
            return list;
        }


      













    }
}
