using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> sehirler = new MyDictionary<int,string>();
            sehirler.Add(34,"İstanbul");
            sehirler.Add(35,"İzmir");
            sehirler.Add(06,"Ankara");

            sehirler.GetAll();
        }
    }
}
