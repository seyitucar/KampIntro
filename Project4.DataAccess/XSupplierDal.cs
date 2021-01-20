using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project5.DataAccess
{
    public class XSupplierDal : ISupplierDal
    {
        List<Supplier> _suppliers;
        public XSupplierDal()
        {
            _suppliers = new List<Supplier>
            {
                new Supplier { SupplierId=1,SupplierName="Özen x",SupplierType = "Örme",AuditScore=85, SupplierClass="A"},
                new Supplier { SupplierId=2,SupplierName="Tübaş x",SupplierType = "Örme",AuditScore=75, SupplierClass="C"},
                new Supplier { SupplierId=3,SupplierName="Savcan x",SupplierType = "Dokuma",AuditScore=65, SupplierClass="D"},
                new Supplier { SupplierId=4,SupplierName="Akal x",SupplierType = "Triko",AuditScore=95, SupplierClass="A"},
                new Supplier { SupplierId=5,SupplierName="Işıksoy x",SupplierType = "Dokuma",AuditScore=85, SupplierClass="B"}
            };
        }

        public void Add(Supplier supplier)
        {
            Console.WriteLine("X ile eklendi");
        }

        public List<Supplier> GetAll()
        {
            return _suppliers;
        }
    }
}
