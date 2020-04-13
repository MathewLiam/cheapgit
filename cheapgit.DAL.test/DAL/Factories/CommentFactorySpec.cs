using System;
using System.Collections.Generic;
using System.Text;
using cheapgit.DAL.Factories;
using cheapgit.DAL.Factories.Interfaces;
using cheapgit.DAL.Models;
using cheapgit.DAL.Models.OracleServiceModels;
using NUnit.Framework;

namespace cheapgit.test.DAL.Factories
{
    class CommentFactorySpec
    {
        ICommentFactory commentfactory = new CommentFactory();
        
        [Test]
        public void CanGenerateCommentFromOracleComment()
        {
            var oraclecomment = new OracleProductComment
            {
                id = "COMMENTID",
                productid = "PRODUCTID",
                dateAdded = new System.DateTime(),
                commentTitle = "A comment",
                commentBody = "A comment body where I have an opinion",
                flaggedInappropriate = 1
            };

            var productcomment = this.commentfactory.GenerateComment(oraclecomment);
            Assert.True(productcomment is ProductComment);
            Assert.AreEqual("COMMENTID", productcomment.id);
        }

        [Test]
        public void CanGenerateListOfCommentsFromOracleComments()
        {
            var listoraclecomments = new List<OracleProductComment>
            {
                new OracleProductComment
                {
                    id = "COMMENTID",
                    productid = "PRODUCTID",
                    dateAdded = new System.DateTime(),
                    commentTitle = "A comment",
                    commentBody = "A comment body where I have an opinion",
                    flaggedInappropriate = 1
                },
                new OracleProductComment
                {
                    id = "COMMENTID2",
                    productid = "PRODUCTID2",
                    dateAdded = new System.DateTime(),
                    commentTitle = "A comment 2",
                    commentBody = "A comment body where I have another opinion",
                    flaggedInappropriate = 0
                }
            };

            var listproductcomments = (List<ProductComment>)this.commentfactory.GenerateComments(listoraclecomments);
            Assert.True(listproductcomments is List<ProductComment>);
            Assert.AreEqual("COMMENTID", listproductcomments[0].id);
            Assert.AreEqual("COMMENTID2", listproductcomments[1].id);
        }
    }
}
