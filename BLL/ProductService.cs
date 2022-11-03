
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService
    {
        IDataSource ds;//= new DAL.MockDataSource();
        public ProductService(IDataSource ds)
        {
           this. ds = ds;
        }

        public List<Product > GetAll()
        {
            var list = ds.GetAll();
            return list;
        }
    }
}
