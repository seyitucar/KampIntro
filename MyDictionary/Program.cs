using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Java");
            myDictionary.Add("C#");
            myDictionary.Add("Flutter");

            Console.WriteLine(myDictionary.Count);
        }
    }
}
