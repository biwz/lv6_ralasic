using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv6_Ralasic
{
    class Box
    {
        private List<Product> products;
        public Box() { this.products = new List<Product>(); }
        public Box(List<Product> products)
        {
            this.products = new List<Product>(products.ToArray());
        }
        public void AddProduct(Product product) { this.products.Add(product); }
        public void RemoveProduct(Product product) { this.products.Remove(product); }
        public int Count { get { return this.products.Count; } }
        public void Clear()
        {
            this.products.Clear();
        }
        public Product this[int index] { get { return this.products[index]; } }
        public IAbstractIteratorBox GetIterator() { return new BoxIterator(this); }
    }
}
