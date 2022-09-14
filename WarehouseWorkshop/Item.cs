namespace Warehouse
{
    public class Item
    {
        private decimal price;
        public string ItemName
        {
            get;
            private set;
        }
        public decimal Price
        {
            get {return price;}
            set {price = Math.Round(value, 2);}
        } 

        public Item (string ItemName, decimal price)
        {
            this.ItemName = ItemName;
            this.price = Math.Round(price, 2);
        }
    }
}