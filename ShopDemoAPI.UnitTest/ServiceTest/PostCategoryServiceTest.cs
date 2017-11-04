using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Data.Repositories;
using ShopDemoAPI.Model.Models;
using ShopDemoAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _postCategoryService;
        private List<POSTCATEGORY> _listPostCateGory;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _postCategoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listPostCateGory = new List<POSTCATEGORY>()
            {
                new POSTCATEGORY(){ ID_POSTCATEGORY = 1, NAME = "Danh mục 1", ALIAS = "danh-muc-1", STATUS = true},
                new POSTCATEGORY(){ ID_POSTCATEGORY = 2, NAME = "Danh mục 2", ALIAS = "danh-muc-2", STATUS = true},
                new POSTCATEGORY(){ ID_POSTCATEGORY = 3, NAME = "Danh mục 3", ALIAS = "danh-muc-3", STATUS = true},
            };
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //Setup method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listPostCateGory);

            //Call action
            var result = _postCategoryService.GetAll() as List<POSTCATEGORY>;

            //Compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {
            POSTCATEGORY postCategory = new POSTCATEGORY();
            int id = 1;
            postCategory.NAME = "Test";
            postCategory.ALIAS = "test";
            postCategory.STATUS = true;

            _mockRepository.Setup(m => m.Add(postCategory)).Returns((POSTCATEGORY p) =>
            {
                p.ID_POSTCATEGORY = 1;
                return p;
            });
            var result = _postCategoryService.Add(postCategory);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID_POSTCATEGORY);
        }
    }
}
