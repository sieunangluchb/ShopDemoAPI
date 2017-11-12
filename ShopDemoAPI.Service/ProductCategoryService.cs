using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Data.Repositories;
using ShopDemoAPI.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Service
{
    public interface IProductCategoryService
    {
        PRODUCTCATEGORY Add(PRODUCTCATEGORY productCategory);

        void Update(PRODUCTCATEGORY productCategory);

        PRODUCTCATEGORY Delete(int id);

        IEnumerable<PRODUCTCATEGORY> GetAll();

        IEnumerable<PRODUCTCATEGORY> GetAll(string keyword);

        IEnumerable<PRODUCTCATEGORY> GetAllByParentID(int parentId);

        PRODUCTCATEGORY GetById(int id);

        void Save();
    }

    public class ProductCategoryService : IProductCategoryService
    {
        private IProductCategoryRepository _productCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._productCategoryRepository = productCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public PRODUCTCATEGORY Add(PRODUCTCATEGORY productCategory)
        {
            return _productCategoryRepository.Add(productCategory);
        }

        public PRODUCTCATEGORY Delete(int id)
        {
            return _productCategoryRepository.Delete(id);
        }

        public IEnumerable<PRODUCTCATEGORY> GetAll()
        {
            return _productCategoryRepository.GetAll();
        }

        public IEnumerable<PRODUCTCATEGORY> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _productCategoryRepository.GetMulti(x => x.NAME.Contains(keyword) || x.DESCRIPTION.Contains(keyword));
            else
                return _productCategoryRepository.GetAll();
        }

        public IEnumerable<PRODUCTCATEGORY> GetAllByParentID(int parentId)
        {
            return _productCategoryRepository.GetMulti(x => x.STATUS && x.PARENT_ID == parentId);
        }

        public PRODUCTCATEGORY GetById(int id)
        {
            return _productCategoryRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(PRODUCTCATEGORY productCategory)
        {
            _productCategoryRepository.Update(productCategory);
        }
    }
}
