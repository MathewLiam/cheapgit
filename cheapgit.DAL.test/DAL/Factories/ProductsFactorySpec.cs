using NUnit.Framework;
using System;
using cheapgit.DAL.Models;
using cheapgit.DAL.Models.OracleServiceModels;
using cheapgit.DAL.Factories;
using cheapgit.DAL.Factories.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace cheapgit.test.DAL.Factories
{
    class ProductsFactorySpec
    {
        IProductFactory productfactory = new ProductFactory();

        [Test]
        public void CanGenerateProductFromOracleProduct()
        {
            var oracleproduct = new OracleProduct
            {
                id = "APRODUCT",
                brand = "Brand",
                category = "Cat1, Cat2",
                colours = "Rainbow",
                dateAdded = new DateTime(),
                dateUpdated = null,
                dimensions = null,
                keys = "Cat1, Cat2",
                tags = "Cat1, Cat2",
                manufacturer = "Me",
                name = "A test product",
                price = 57.0F
            };

            var product = this.productfactory.GenerateProduct(oracleproduct);

            Assert.True(product is Product);
            Assert.AreEqual(oracleproduct.id, product.id);
            Assert.AreEqual(oracleproduct.brand, product.brand);
            Assert.AreEqual(oracleproduct.category, product.category);
        }

        [Test]
        public void CanGenerateListOfProduct()
        {
            var listOracleProducts = new List<OracleProduct>
            {
                new OracleProduct 
                {
                    id = "APRODUCT",
                    brand = "Brand",
                    category = "Cat1, Cat2",
                    colours = "Rainbow",
                    dateAdded = new DateTime(),
                    dateUpdated = null,
                    dimensions = null,
                    keys = "Cat1, Cat2",
                    tags = "Cat1, Cat2",
                    manufacturer = "Me",
                    name = "A test product",
                    price = 57.0F
                },
                new OracleProduct
                {
                    id = "APRODUCT",
                    brand = "Brand",
                    category = "Cat1, Cat2",
                    colours = "Rainbow",
                    dateAdded = new DateTime(),
                    dateUpdated = null,
                    dimensions = null,
                    keys = "Cat1, Cat2",
                    tags = "Cat1, Cat2",
                    manufacturer = "Me",
                    name = "A test product",
                    price = 57.0F
                }
            };

            var products = (List<Product>)this.productfactory.GerenateProducts(listOracleProducts);

            Assert.True(products is List<Product>);
            Assert.AreEqual(listOracleProducts[0].id, products[0].id);
            Assert.AreEqual(listOracleProducts[1].id, products[1].id);
        }
    }
}
