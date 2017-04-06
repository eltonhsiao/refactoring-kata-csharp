using System.Collections.Generic;

namespace RefactoringKata
{
    public class Order
    {
        private readonly int id;
        private readonly List<Product> _products = new List<Product>();

        public Order(int id)
        {
            this.id = id;
        }

        public int GetOrderId()
        {
            return id;
        }

        public int GetProductsCount()
        {
            return _products.Count;
        }

        public Product GetProduct(int j)
        {
            return _products[j];
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public string FormatString()
        {
            string outputString = string.Empty;
            foreach (Product i in _products)
            {
                outputString += i.FormatString();
            }

            return string.Format("{{\"id\": {0}, \"products\": [{1}]}}, ", id, outputString);
        }
    }
}