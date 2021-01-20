using System;
using System.Collections.Generic;
using System.Text;

namespace Project5.Entities
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierType { get; set; }
        public double AuditScore { get; set; }
        public string SupplierClass { get; set; }
    }
}
