using Project5.Business;
using Project5.DataAccess;
using System;

namespace Project5.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftwareManager softwareManager = new SoftwareManager(new SoftwareDal());

            foreach (var software in softwareManager.GetAll())
            {
                Console.WriteLine(software.SoftwareName);
            }
        }
    }
}
