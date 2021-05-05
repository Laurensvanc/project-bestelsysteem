namespace ChapooModel
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductNaam { get; set; }
        public double Prijs { get; set; }
        public double InkoopPrijs { get; set; }
        public int Aantal { get; set; }
        public bool IsAlcohol { get; set; }
        public bool IsDrinken { get; set; }

        public Product(int productId, string productNaam, double prijs, double inkoopPrijs, int aantal, bool isAlcohol, bool isDrinken)
        {
            ProductId = productId;
            ProductNaam = productNaam;
            Prijs = prijs;
            InkoopPrijs = inkoopPrijs;
            Aantal = aantal;
            IsAlcohol = isAlcohol;
            IsDrinken = isDrinken;
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public override string ToString()
        {
            return ProductNaam;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Product;

            if (other == null)
            {
                return false;
            }
            if (ProductId != other.ProductId || ProductNaam != other.ProductNaam || Prijs != other.Prijs || InkoopPrijs != other.InkoopPrijs || Aantal != other.Aantal || IsAlcohol != other.IsAlcohol || IsDrinken != other.IsDrinken)
            {
                return false;
            }
            return true;
        }
    }
}