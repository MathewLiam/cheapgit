using System;
using System.Collections.Generic;
using System.Text;
using cheapgit.DAL.Factories.Interfaces;
using cheapgit.DAL.Models;
using cheapgit.DAL.Models.OracleServiceModels;

namespace cheapgit.DAL.Factories
{
    public class CommentFactory : ICommentFactory
    {
        public ProductComment GenerateComment(OracleProductComment oracleComment)
        {
            return new ProductComment
            {
                id = oracleComment.id,
                productid = oracleComment.id,
                dateAdded = oracleComment.dateAdded,
                commentTitle = oracleComment.commentTitle,
                commentBody = oracleComment.commentBody,
                flaggedInappropriate = oracleComment.flaggedInappropriate
            };
        }

        public OracleProductComment GenerateComment(ProductComment comment)
        {
            return new OracleProductComment
            {
                id = comment.id,
                productid = comment.id,
                dateAdded = comment.dateAdded,
                commentTitle = comment.commentTitle,
                commentBody = comment.commentBody,
                flaggedInappropriate = comment.flaggedInappropriate
            };
        }

        public IEnumerable<ProductComment> GenerateComments(IEnumerable<OracleProductComment> oracleComments)
        {
            List<ProductComment> comments = new List<ProductComment>();

            foreach (var comment in oracleComments)
            {
                comments.Add(this.GenerateComment(comment));
            }

            return comments;
        }
    }
}
