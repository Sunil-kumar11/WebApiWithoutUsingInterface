using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithoutUsingInterface.Models;

namespace WebApiWithoutUsingInterface.ProductData
{
    public class MockProducts
    {
        private List<Products> Products = new List<Products>()
        {
            new Products()
            {
                Id=Guid.NewGuid(),ProductName="vikas"
            },
            new Products()
            {
                Id = Guid.NewGuid(),ProductName= "ravi"
            }
        };

        public List<Products> GetProducts()
        {

            return Products;
        }

        public Products GetProduct(Guid id)
        {
            return Products.SingleOrDefault(x => x.Id == id);
            
        }

        internal object GetProduct()
        {
            throw new NotImplementedException();
        }

        public Products AddProduct(Products products)
        {
            Products.Add(products);
            return products;
        }
    }
}
