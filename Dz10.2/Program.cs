using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>(9);

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            Console.WriteLine($"Element at index 2: {myList.Find(1)}");
            Console.WriteLine(myList.Length);
            Console.ReadLine();
        }
    }
    class MyList<T>
    {
        private T[] array = new T[10];
        private int count { get; set; }
        public int Length { get; private set; }
        public void Add(T item)
        {
            if (count >= array.Length)
            {
                Array.Resize(ref array, array.Length * 2);
            }
            array[count] = item;
            count++;
            Length = array.Length;
        }
        public T Find(int index)
        {
            return array[index];
        }
        
        public MyList(int Size) 
        { 
           array = new T[Size];
           Length = Size;
        }
    }
}
