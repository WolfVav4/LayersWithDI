using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // MockDataSource mockDS = new MockDataSource();
            // DAL.RealDataSource ds = new DAL.RealDataSource();

            ProductService productSerMock = BLL.Utilities.ConfigProductDependencies("Mock");
            ProductService serSQL  = BLL.Utilities.ConfigProductDependencies("SQL");

            List  <Product> list = productSerMock.GetAll();
            var                    list1 = serSQL.GetAll();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
              
            Console.ReadLine();
        }
    }
}
