using Project5.Business;
using Project5.DataAccess;
using System;

namespace Project5.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SupplierManager supplierManager = new SupplierManager(new XSupplierDal());

            foreach (var supplier in supplierManager.GetAll())
            {
                Console.WriteLine(supplier.SupplierName);
            }

        }
    }
}
