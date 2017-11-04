using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Data.Repositories;
using ShopDemoAPI.Model.Models;
using System.Linq;

namespace ShopDemoAPI.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        private IDbFactory dbFactory;
        private IPostCategoryRepository objRepository;
        private IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            POSTCATEGORY postCategory = new POSTCATEGORY();
            postCategory.NAME = "Test category";
            postCategory.ALIAS = "test-category";
            postCategory.STATUS = true;

            var result = objRepository.Add(postCategory);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.ID_POSTCATEGORY);
        }
    }
}