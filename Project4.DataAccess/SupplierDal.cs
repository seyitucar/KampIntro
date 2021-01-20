using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project5.DataAccess
{
    public class SupplierDal : ISupplierDal
    {
        //Ado.Net

        List<Supplier> _suppliers;

        public SupplierDal()
        {
            _suppliers = new List<Supplier>
            {
                new Supplier { SupplierId=1,SupplierName="Özen",SupplierType = "Örme",AuditScore=85, SupplierClass="A"},
                new Supplier { SupplierId=2,SupplierName="Tübaş",SupplierType = "Örme",AuditScore=75, SupplierClass="C"},
                new Supplier { SupplierId=3,SupplierName="Savcan",SupplierType = "Dokuma",AuditScore=65, SupplierClass="D"},
                new Supplier { SupplierId=4,SupplierName="Akal",SupplierType = "Triko",AuditScore=95, SupplierClass="A"},
                new Supplier { SupplierId=5,SupplierName="Işıksoy",SupplierType = "Dokuma",AuditScore=85, SupplierClass="B"}
            };
        }

        public void Add(Supplier supplier)
        {
            Console.WriteLine("Ado.NET ile Eklendi");
        }

        public List<Supplier> GetAll()
        {
            return _suppliers;
        }
    }
}
