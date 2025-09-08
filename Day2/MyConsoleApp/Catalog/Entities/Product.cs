namespace Catalog
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void setName(string name)
        {
            Name = name;
        }
        public void setPrice(decimal price)
        {
            Price = price;
        }
        public string getName()
        {
            return Name;
        }
        public decimal getPrice()
        {
            return Price;
        }
    }
}