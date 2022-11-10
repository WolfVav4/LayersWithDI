using System;

namespace Services.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public eTool DefaultTool { get; set; }

        public override string ToString()
        {
            return $" {nameof(Id)}: {Id}," +
                Environment.NewLine +
                $"{nameof(Product_Name)}: {Product_Name}" +
                Environment.NewLine +
                $"{nameof(DefaultTool)}: {DefaultTool}" +
                                Environment.NewLine +

                "===============================================";
        }
    }
}