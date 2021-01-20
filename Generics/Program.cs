using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
        }
    }

    class MyList<T> // Generic Class
    {
        public void Add(T item)
        {

        }

    }
}
