using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ElectronicsStore
    {
        private List<Product> products;
        private ProductGenerator generator;

        public ElectronicsStore()
        {
            generator = new ProductGenerator();
            products = generator.GenerateElectronicsProducts();
        }

        public List<Product> DisplayProducts()
        {
            return new List<Product>(products);
        }

        public void AddToCart(Product product, ShoppingCart cart)
        {
            cart.AddItem(product);
        }
    }
}
