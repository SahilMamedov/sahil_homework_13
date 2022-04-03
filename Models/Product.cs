namespace Homework_13
{
    public abstract class Product
    {
        private static int _Id { get; set; }
        public string _Name { get; set; }
        public double _Price { get; set; }
        public int _Count { get; set; }
        protected static double _TotallnCome { get; set; }
        public abstract void Sell();
        public abstract void ShowInfo();
        public int ID { get; set; }

        public Product(string name, double price, int count)
        {
            _Id++;
            _Name = name;
            _Price = price;
            _Count = count;

            ID = _Id;
        }

    }
}
