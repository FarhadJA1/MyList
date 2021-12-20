using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NewList.Models
{
    public class MyList<T> 
    {
        
        public T[] MyArray;
        public int Count { get; set; }

        public MyList()
        {
            MyArray = new T[0];
        }

        public void Add(T obj)
        {
            if (Count % 10 == 1)
            {
                Array.Resize(ref MyArray,MyArray.Length + 10);
            }
            
            obj =  MyArray[Count];
            Count++;
        }

        public void Delete()
        {
            MyArray = new T[Count];
            Count = 0;
        }

        public void AddRange(IEnumerable<T> List)
        {
            foreach (var item in List)
            {
                Add(item);
            }
        }

        public T Find(Predicate<T> func)
        {
            foreach (var item in MyArray)
            {
                if(func(item))
                {
                    return item;
                }

            }
            return default;
        }

        public void GetAll()
        {
            foreach (var item in MyArray)
            {
                Console.WriteLine(item); 
            }
            
        }

        
    }
}
