using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Data.Repositories;
using ShopDemoAPI.Model.Models;
using System;
using System.Collections.Generic;

namespace ShopDemoAPI.Service
{
    public interface IPostCategoryService
    {
        POSTCATEGORY Add(POSTCATEGORY postCategory);

        void Update(POSTCATEGORY postCategory);

        POSTCATEGORY Delete(int id);

        IEnumerable<POSTCATEGORY> GetAll();

        IEnumerable<POSTCATEGORY> GetAllByParentID(int parentId);

        POSTCATEGORY GetById(int id);

        void Save();
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

        public POSTCATEGORY Add(POSTCATEGORY postCategory)
        {
            return _postCategoryRepository.Add(postCategory);
        }

        public POSTCATEGORY Delete(int id)
        {
            return _postCategoryRepository.Delete(id);
        }

        public IEnumerable<POSTCATEGORY> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public IEnumerable<POSTCATEGORY> GetAllByParentID(int parentId)
        {
            return _postCategoryRepository.GetMulti(x => x.STATUS && x.PARENT_ID == parentId);
        }

        public POSTCATEGORY GetById(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(POSTCATEGORY postCategory)
        {
            _postCategoryRepository.Update(postCategory);
        }
    }
}