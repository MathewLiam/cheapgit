namespace cheapgit.DAL.Factories
{
    using cheapgit.DAL.Factories.Interfaces;
    using cheapgit.DAL.Models;
    using cheapgit.DAL.Models.OracleServiceModels;
    using cheapgit.DAL.Workers.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="ProductFactory" />.
    /// </summary>
    public class ProductFactory : IProductFactory
    {
        /// <summary>
        /// Defines the _apiWorker.
        /// </summary>
        private readonly IApiWorker _apiWorker;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductFactory"/> class.
        /// </summary>
        /// <param name="apiWorker">The apiWorker<see cref="IApiWorker"/>.</param>
        public ProductFactory(IApiWorker apiWorker)
        {
            _apiWorker = apiWorker;
        }

        /// <summary>
        /// The GenerateProduct.
        /// </summary>
        /// <param name="product">The product<see cref="OracleProduct"/>.</param>
        /// <returns>The <see cref="Task{Product}"/>.</returns>
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

        /// <summary>
        /// The GerenateProducts.
        /// </summary>
        /// <param name="products">The products<see cref="IEnumerable{OracleProduct}"/>.</param>
        /// <returns>The <see cref="Task{IEnumerable{Product}}"/>.</returns>
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
