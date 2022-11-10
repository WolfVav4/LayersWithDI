using Repositories.Entities;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal interface IService <T>
        
    {
        //implement CRUD
        List<T> GetAll(); //Read

    T Add(T model);  //create

    T Update(T model);  //Update
    bool Delete(int id);  //Delete





}
{
    }
}
