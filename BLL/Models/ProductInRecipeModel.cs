
namespace Services.Models
{
    public class ProductInRecipeModel
    {
        public int Id { get; set; }
        public ProductModel Product { get; set; }
        public RecipeModel Recipe { get; set; }
        public int Amount { get; set; }
        public eTool Tool { get; set; }
    }
}