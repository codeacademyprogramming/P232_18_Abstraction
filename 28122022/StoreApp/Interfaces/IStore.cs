using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp.Interfaces
{
    internal interface IStore
    {
        Product[] Products { get; }
        Sale[] Sales { get; }
        void AddProduct(Product product);
        void Sell(string name);
        double TotalAmount { get; }
    }
}
