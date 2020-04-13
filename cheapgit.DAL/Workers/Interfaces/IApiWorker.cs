using cheapgit.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cheapgit.DAL.Workers.Interfaces
{
    public interface IApiWorker
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<IEnumerable<Product>> GetProductsByCategory(string category);
        Task<Product> GetProductById(string id);
        Task<IEnumerable<ProductComment>> GetProductComments(string productid);
        Task<ProductComment> GetProductComment(string productid, string commentid);
        Task<IEnumerable<ProductReview>> GetProductReviews(string productid);
        Task<ProductReview> GetProductReview(string productid, string reviewid);

    }
}
