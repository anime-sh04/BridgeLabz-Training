using System;
namespace FlashDealz {
    class Product
    {
        public string Name { get; set; }
        public double DiscountedPrice { get; set; }

        public Product(string name, double discountedPrice)
        {
            Name = name;
            DiscountedPrice = discountedPrice;
        }

        public override string ToString()
        {
            return $"Name : {Name}\nDiscounted Price : {DiscountedPrice}";
        }


    }
}