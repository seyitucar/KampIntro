using Project5.DataAccess;
using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project5.DataAccess
{
    public class SoftwareDal : ISoftwareDal
    {
        List<Software> _softwares;

        public SoftwareDal()
        {
            _softwares = new List<Software>
            {
                new Software {SoftwareId = 1, SoftwareName="Avast",SoftwarePrice = 10, SoftwareRating = 5 },
                new Software {SoftwareId = 2, SoftwareName="Kaspersky",SoftwarePrice = 30, SoftwareRating = 4 },
                new Software {SoftwareId = 3, SoftwareName="MSE",SoftwarePrice = 50, SoftwareRating = 2 }
            };

        }

        public void Add(Software software)
        {
            Console.WriteLine("İlk Database ile eklendi");
        }

        public List<Software> GetAll()
        {
            return _softwares;
        }
    }
}
