using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Order
    {
        private List<string> _products;

        public bool IsCompleted { get; set; }

        public Order()
        {
            _products = new List<string>
        {
            "Computer",
            "Volkswagen Golf",
            "Smartphone",
            "Peace to Ukraine"
        };
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
