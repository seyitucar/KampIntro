using Project5.DataAccess;
using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project5.Business
{
    public class SoftwareManager
    {
        ISoftwareDal _softwareDal;
        public SoftwareManager(ISoftwareDal softwareDal)
        {
            _softwareDal = softwareDal;
        }

        public List<Software> GetAll()
        {
            // iş kodu
            return _softwareDal.GetAll();
        }
    }
}
