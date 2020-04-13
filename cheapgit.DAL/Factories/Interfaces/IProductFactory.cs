using System;
using System.Collections.Generic;
using System.Text;
using cheapgit.DAL.Models;
using cheapgit.DAL.Models.OracleServiceModels;

namespace cheapgit.DAL.Factories.Interfaces
{
    public interface IProductFactory
    {
        Product GenerateProduct(OracleProduct product);

        IEnumerable<Product> GerenateProducts(IEnumerable<OracleProduct> products);
    }
}
