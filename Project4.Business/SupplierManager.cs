using Project5.DataAccess;
using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project5.Business
{
    public class SupplierManager
    {
        ISupplierDal _supplierDal;

        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        public List<Supplier> GetAll()
        {

            //iş kodları yazlır

            return _supplierDal.GetAll();

        }
    }
}
