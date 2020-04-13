using System;
using System.Collections.Generic;
using System.Text;
using cheapgit.DAL.Models;
using cheapgit.DAL.Models.OracleServiceModels;

namespace cheapgit.DAL.Factories.Interfaces
{
    public interface ICommentFactory
    {
        IEnumerable<ProductComment> GenerateComments(IEnumerable<OracleProductComment> oracleComments);
        ProductComment GenerateComment(OracleProductComment oracleComment);
        OracleProductComment GenerateComment(ProductComment comment);

    }
}
