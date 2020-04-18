using cheapgit.DAL.Factories.Interfaces;
using cheapgit.DAL.Models;
using cheapgit.DAL.Models.OracleServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace cheapgit.DAL.Factories
{
    public class ProductFactory : IProductFactory
    {
        public Product GenerateProduct(OracleProduct product)
        {
            return new Product
            {
                id = product.id,
                brand = product.brand,
                category = product.category,
                colours = product.colours,
                dateAdded = product.dateAdded,
                dateUpdated = product.dateUpdated,
                description = product.description,
                dimensions = product.dimensions,
                keys = product.keys,
                tags = product.tags,
                name = product.name,
                manufacturer = product.manufacturer,
                price = product.price,
                retailPrice = product.retailPrice,
                autoExpire = product.autoExpire,
                autoExpireDate = product.autoExpireDate,
                featureBullets = product.featureBullets,
                quantity = product.quantity
            };
        }

        public IEnumerable<Product> GerenateProducts(IEnumerable<OracleProduct> products)
        {
            List<Product> list = new List<Product>();

            foreach (var item in products)
            {
                list.Add(this.GenerateProduct(item));
            }

            return list;
        }
    }
}
