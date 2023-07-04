using System;

namespace OnlineOrder
{
    public class Product
    {
        private string _productId;
        private string _productName;
        private float _unitPrice;
        private int _quantity;

        public Product(string Id, string productName, float price, int quantity)
        {
            _productId = Id;
            _productName = productName;
            _unitPrice = price;
            _quantity = quantity;
        }

        public string GetID()
        {
            return _productId;
        }

        public string GetProductName()
        {
            return _productName;
        }

        public float ComputeProductPrice()
        {
            return _unitPrice * _quantity;
        }
    }
}