using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Java");
            myDictionary.Add("Python");
            myDictionary.Add("C#");

            Console.WriteLine(myDictionary.Count);
        }
    }
}
