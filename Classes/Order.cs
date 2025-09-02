namespace Classes
{
    class Order
    {
        private List<string> _products;

        public bool IsCompleted { get; set; }

        public Order(List<string> products)
        {
            _products = products;
        }

        public void AddProducts(string products)
        {
            _products.Add(products);
        }

        public void RemoveProduct(string product)
        {
            _products.Remove(product);
        }

        public void PrintOrder()
        {
            foreach (string a in _products)
            {
                Console.WriteLine($"Products: {a} ");
            }
        }
    }
}
