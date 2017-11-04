﻿using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Data.Repositories;
using ShopDemoAPI.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Service
{
    public interface IPostService
    {
        void Add(POST post);
        void Update(POST post);
        void Delete(int id);
        IEnumerable<POST> GetAll();
        IEnumerable<POST> GetAllPaging(int page, int pageSize, out int totalRow);
        IEnumerable<POST> GetAllByCategoryPaging(int postCategoryId, int page, int pageSize, out int totalRow);
        POST GetById(int id);
        IEnumerable<POST> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();
    }
    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;
        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(POST post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<POST> GetAll()
        {
            return _postRepository.GetAll(new string[] { "POSTCATEGORY" });
        }

        public IEnumerable<POST> GetAllByCategoryPaging(int postCategoryId, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.STATUS && x.ID_POSTCATEGORY == postCategoryId, out totalRow, page, pageSize, new string[] { "POSTCATEGORY" });
        }

        public IEnumerable<POST> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //TODO: Select all post by tag
            return _postRepository.GetAllByTag(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<POST> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.STATUS, out totalRow, page, pageSize);
        }

        public POST GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(POST post)
        {
            _postRepository.Update(post);
        }
    }
}
