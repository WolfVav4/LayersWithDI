using AutoMapper;
using Repositories.Entities;
using Repositories;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal interface IProductService : IService<Product>
    {
        //implement CRUD
        List<ProductModel> GetAll(); //Read

        Product Add(Product  model);  //create

        Product Update(Product model);  //Update
        bool Delete(int id  );  //Delete





    }
}
