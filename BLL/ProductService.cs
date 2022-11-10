
using AutoMapper;
using Repositories;
using Repositories.Entities;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService : IProductService
    {
        IDataSource dataSource; 
        public ProductService(IDataSource ds)
        {
           this. dataSource = ds;
        }

        public Product Add(Product model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel > GetAll()
        {
            List<Product> listFromDataSource = dataSource.GetAll();

            AutoMapper.MapperConfiguration config = new AutoMapper.MapperConfiguration
                (conf => conf.CreateMap<Product, ProductModel>()
                .ForMember(dest => dest.Product_Name, opt => opt.MapFrom(dest => dest.Name))
                 .ReverseMap()
                 .ForMember(dest => dest.Name, opt => opt.MapFrom(dest => dest.Product_Name))
                 );

            IMapper mapper = config.CreateMapper();

            var returnList=new List<ProductModel>();
            foreach (Product  item in listFromDataSource)
            {
                returnList.Add( mapper.Map<ProductModel >(item));
            }

            return returnList;
        }

        public Product Update(Product model)
        {
            throw new NotImplementedException();
        }

        List<Product> IService<Product>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
