using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using cheapgit.DAL.Models;
using cheapgit.DAL.Models.OracleServiceModels;

namespace cheapgit.DAL.Factories.Interfaces
{
    public interface IProductFactory
    {
        Task<Product> GenerateProduct(OracleProduct product);

        Task<IEnumerable<Product>> GerenateProducts(IEnumerable<OracleProduct> products);
    }
}
