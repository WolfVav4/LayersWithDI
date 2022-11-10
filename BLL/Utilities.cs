
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//any change
namespace BLL
{
    public static class Utilities
    {
        public static ProductService ConfigProductDependencies(string v)
        {
            switch (v)
            {
                case "Mock"  : return new ProductService(new Repositories.MockDataSource());
                case "SQL":
                default:
                     return new ProductService(new Repositories.SQLDataSorce());
        }
        }
    }
}
