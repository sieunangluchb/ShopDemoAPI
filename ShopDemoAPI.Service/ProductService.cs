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
    public interface IProductService
    {
        PRODUCT Add(PRODUCT product);

        void Update(PRODUCT product);

        PRODUCT Delete(int id);

        IEnumerable<PRODUCT> GetAll();

        IEnumerable<PRODUCT> GetAll(string keyword);

        PRODUCT GetById(int id);

        void Save();
    }
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }

        public PRODUCT Add(PRODUCT PRODUCT)
        {
            return _productRepository.Add(PRODUCT);
        }

        public PRODUCT Delete(int id)
        {
            return _productRepository.Delete(id);
        }

        public IEnumerable<PRODUCT> GetAll()
        {
            return _productRepository.GetAll();
        }

        public IEnumerable<PRODUCT> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _productRepository.GetMulti(x => x.NAME.Contains(keyword) || x.DESCRIPTION.Contains(keyword));
            else
                return _productRepository.GetAll();
        }

        public PRODUCT GetById(int id)
        {
            return _productRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(PRODUCT PRODUCT)
        {
            _productRepository.Update(PRODUCT);
        }
    }
}
