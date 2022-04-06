namespace HW13Library
{
    public struct Product
    {
        public string name { get; set; }
        public string shopName { get; set; }
        public Product(string name, string shopName)
        {
            this.name = name;
            this.shopName = shopName;
        }
        
    }
}