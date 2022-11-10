

namespace Repositories.Entities
{
    public class ProductInRecipe
    {
        public int Id { get; set; }
        public Product  Product { get; set; }
        public Recipe  Recipe { get; set; }
        public int Amount { get; set; }
        public int Tool { get; set; }

    }
}