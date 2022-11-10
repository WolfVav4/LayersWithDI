using System.Collections.Generic;

namespace Services.Models
{
    public  class RecipeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CatergoryModel Category { get; set; }
        public List<ProductInRecipeModel> Products { get; set; }

    }
}
