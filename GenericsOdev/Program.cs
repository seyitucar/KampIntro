using System;

namespace GenericsOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Kalem");
            myDictionary.Add("Silgi");

            Console.WriteLine(myDictionary.Count);

        }
    }
}
