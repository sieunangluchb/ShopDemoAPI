using ShopDemoAPI.Common;
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
        private ITagRepository _tagRepository;
        private IProductTagRepository _productTagRepository;

        private IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, ITagRepository tagRepository, IProductTagRepository productTagRepository, IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._tagRepository = tagRepository;
            this._productTagRepository = productTagRepository;
            this._unitOfWork = unitOfWork;
        }

        public PRODUCT Add(PRODUCT product)
        {
            var productResult = _productRepository.Add(product);
            //lưu dữ liệu vào database trước khi lưu tag vì PRODUCTTAG cần ID_PRODUCT
            _unitOfWork.Commit();

            if (!string.IsNullOrEmpty(product.TAGS))
            {
                string[] tags = product.TAGS.Split(',');
                for (var i = 0; i < tags.Length; i++)
                {
                    var tagId = StringHelper.ToUnsignString(tags[i]);
                    if (_tagRepository.Count(x => x.ID_TAG == tagId) == 0)
                    {
                        TAG tag = new TAG();
                        tag.ID_TAG = tagId;
                        tag.NAME = tags[i];
                        tag.TYPE = CommonContants.ProductTag;
                        _tagRepository.Add(tag);
                    }

                    PRODUCTTAG productTag = new PRODUCTTAG();
                    productTag.ID_PRODUCT = product.ID_PRODUCT;
                    productTag.ID_TAG = tagId;
                    _productTagRepository.Add(productTag);
                }
            }
            return productResult;
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

        public void Update(PRODUCT product)
        {
            _productRepository.Update(product);

            if (!string.IsNullOrEmpty(product.TAGS))
            {
                string[] tags = product.TAGS.Split(',');
                for (var i = 0; i < tags.Length; i++)
                {
                    var tagId = StringHelper.ToUnsignString(tags[i]);
                    if (_tagRepository.Count(x => x.ID_TAG == tagId) == 0)
                    {
                        TAG tag = new TAG();
                        tag.ID_TAG = tagId;
                        tag.NAME = tags[i];
                        tag.TYPE = CommonContants.ProductTag;
                        _tagRepository.Add(tag);
                    }
                    _productTagRepository.DeleteMulti(x => x.ID_PRODUCT == product.ID_PRODUCT);
                    PRODUCTTAG productTag = new PRODUCTTAG();
                    productTag.ID_PRODUCT = product.ID_PRODUCT;
                    productTag.ID_TAG = tagId;
                    _productTagRepository.Add(productTag);
                }
            }
        }
    }
}
