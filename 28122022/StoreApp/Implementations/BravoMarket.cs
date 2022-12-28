using System;
using System.Collections.Generic;
using System.Text;
using StoreApp.Interfaces;

namespace StoreApp.Implementations
{
    internal class BravoMarket : IStore
    {
        public Product[] Products { get => _products; }
        public double TotalAmount { get => _totalAmount; }

        private double _totalAmount;

        private Product[] _products=new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }

        public void Sell(string name)
        {
            Product wantedProduct = FindByName(name);
            
            if(wantedProduct != null)
            {
                _totalAmount += wantedProduct.Price;
            }
        }

        public Product FindByName(string name)
        {
            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i].Name == name)
                {
                    return  _products[i];
                }
            }

            return null;
        }
    }
}
