using cheapgit.DAL.Factories.Interfaces;
using cheapgit.DAL.Models;
using cheapgit.DAL.Models.OracleServiceModels;
using cheapgit.DAL.Workers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cheapgit.DAL.Factories
{
    public class ProductFactory : IProductFactory
    {
        private readonly IApiWorker _apiWorker;

        public ProductFactory(IApiWorker apiWorker)
        {
            _apiWorker = apiWorker;
        }

        public async Task<Product> GenerateProduct(OracleProduct product)
        {
            Product _product = new Product
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

            _product.images = await _apiWorker.GetProductImages(_product.id);
            _product.reviews = await _apiWorker.GetProductReviews(_product.id);
            return _product;
        }

        public async Task<IEnumerable<Product>> GerenateProducts(IEnumerable<OracleProduct> products)
        {
            List<Product> list = new List<Product>();

            foreach (var item in products)
            {
                list.Add(await this.GenerateProduct(item));
            }

            return list;
        }
    }
}
