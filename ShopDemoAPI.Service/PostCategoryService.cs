using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Data.Repositories;
using ShopDemoAPI.Model.Models;
using System;
using System.Collections.Generic;

namespace ShopDemoAPI.Service
{
    public interface IPostCategoryService
    {
        void Add(POSTCATEGORY postCategory);

        void Update(POSTCATEGORY postCategory);

        void Delete(int id);

        IEnumerable<POSTCATEGORY> GetAll();

        IEnumerable<POSTCATEGORY> GetAllByParentID(int parentId);

        POSTCATEGORY GetById(int id);

        IEnumerable<POSTCATEGORY> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChanges();
    }

    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(POSTCATEGORY postCategory)
        {
            _postCategoryRepository.Add(postCategory);
        }

        public void Delete(int id)
        {
            _postCategoryRepository.Delete(id);
        }

        public IEnumerable<POSTCATEGORY> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public IEnumerable<POSTCATEGORY> GetAllByParentID(int parentId)
        {
            return _postCategoryRepository.GetMulti(x => x.STATUS && x.PARENT_ID == parentId);
        }

        public IEnumerable<POSTCATEGORY> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public POSTCATEGORY GetById(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(POSTCATEGORY postCategory)
        {
            _postCategoryRepository.Update(postCategory);
        }
    }
}