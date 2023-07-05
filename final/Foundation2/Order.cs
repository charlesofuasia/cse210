using System;

namespace OnlineOrder
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;
        private float _shippingCost;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();

            if (_customer.IsAmericanCustomer())
            {
                _shippingCost = 5.00f;
            }
            else
            {
                _shippingCost = 35.00f;
            }
        }

        public void AddProducts(string id, string name, float price, int quantity)
        {
            Product product = new Product(id, name, price, quantity);
            _products.Add(product);
        }

        public float ComputeOrdercost()
        {
            float totalCost = 0;

            foreach (Product item in _products)
            {
                totalCost += item.ComputeProductPrice();
            }

            return _shippingCost + totalCost;
        }

        public string FormatShippingLabel()
        {
            return $"***Shipping Address***\n{_customer.GetCustomerName()}\n{_customer.GetAddress()}";
        }

        public void PrintPackingLabel()
        {
            Console.WriteLine("***Items Packed***");
            foreach (Product item in _products)
            {
                Console.WriteLine($"{item.GetID()} : {item.GetProductName()}    -   {item.GetQuantity()} unit{AddS(item.GetQuantity())}");
            }

        }

        private string AddS(int _quantity)
        {/*Function to modify a noun to either singular or plural by
           adding "s" if the quantity of the noun is greater than 1
           Parameter: int _quantity
           returns string "s"
           */
            if (_quantity > 1)
            {
                return "s";
            }
            else
            {
                return "";
            }
        }

    }
}