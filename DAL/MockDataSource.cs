using Repositories.Entities;
using System.Collections.Generic;


namespace Repositories

{
    public class MockDataSource : IDataSource  
    {
        void init()
        {
            products = new List<Product>();
            products.Add(new Product() { Id = 0, Name = "Flour", DefaultTool = 3});
            products.Add(new Product() { Id = 1, Name = "Suger", DefaultTool = 2 });
            products.Add(new Product() { Id = 2, Name = "Salt", DefaultTool = 4 });
            products.Add(new Product() { Id = 3, Name = "Egg", DefaultTool = 2 });
            products.Add(new Product() { Id = 4, Name = "Oil" ,DefaultTool = 1});
        }

        //CRUD
        public List<Product> GetAll()
        {
            if (products == null) init();
            return products;
        }

        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(int productId)
        {
            Product currProduct = null;
            foreach (var item in products)
            {
                if (item.Id == productId)
                    currProduct = item;
            }
            products.Remove(currProduct);
        }
        public void UpdateProduct(Product newValues)
        { }

        List<Recipe> recipes;
        List<Product> products;



        //property
        #region Learn about property

        //int id;
        //string firstName;
        //public void SetFirstName(string fn)
        //{ this.firstName = fn; }

        //private string lastName;
        //public string LastName //full property
        //{
        //    get { return lastName; }
        //    set { lastName = value; }
        //}
        //public string Address { get; set; } //Auto property 
        #endregion
    }
}
