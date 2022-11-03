using Models;
using System.Collections.Generic;


namespace Repositories

{
    public class MockDataSource : IDataSource  
    {
        void init()
        {
            products = new List<Product>();
            products.Add(new Product() { ProductId = 0, Name = "Flour" });
            products.Add(new Product() { ProductId = 1, Name = "Suger" });
            products.Add(new Product() { ProductId = 2, Name = "Salt" });
            products.Add(new Product() { ProductId = 3, Name = "Egg" });
            products.Add(new Product() { ProductId = 4, Name = "Oil" });
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
                if (item.ProductId == productId)
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
