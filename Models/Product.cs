namespace Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public Tool Tool { get; set; }

        public override string ToString()
        {
            return $"{nameof(ProductId)}: {ProductId}, name: {Name }";
        }
    }
}