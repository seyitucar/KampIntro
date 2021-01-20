using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project5.DataAccess
{
    public interface ISoftwareDal
    {

        List<Software> GetAll();

        void Add(Software software);

    }
}
