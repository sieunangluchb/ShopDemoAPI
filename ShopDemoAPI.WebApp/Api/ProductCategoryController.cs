using AutoMapper;
using ShopDemoAPI.Model.Models;
using ShopDemoAPI.Service;
using ShopDemoAPI.WebApp.Infrastructure.Core;
using ShopDemoAPI.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShopDemoAPI.WebApp.Infrastructure.Extensions;
using System.Web.Script.Serialization;

namespace ShopDemoAPI.WebApp.Api
{
    [RoutePrefix("api/productcategory")]
    public class ProductCategoryController : ApiControllerBase
    {
        private IProductCategoryService _productCategoryService;

        public ProductCategoryController(IErrorService errorService, IProductCategoryService productCategoryService) : base(errorService)
        {
            this._productCategoryService = productCategoryService;
        }
        
        [Route("getall")]
        [HttpGet]
        public HttpResponseMessage GetAll(HttpRequestMessage request, string keyword, int page, int pageSize = 20)
        {
            return CreateHttpResponse(request, () =>
            {
                int totalRow = 0;
                var model = _productCategoryService.GetAll(keyword);
                totalRow = model.Count();
                var query = model.OrderByDescending(x => x.CREATEDDAY).Skip(page * pageSize).Take(pageSize);
                var responseData = Mapper.Map<IEnumerable<PRODUCTCATEGORY>, IEnumerable<PRODUCTCATEGORYViewModel>>(query);

                var paginationSet = new PaginationSet<PRODUCTCATEGORYViewModel>()
                {
                    Items = responseData,
                    Page = page,
                    TotalCount = totalRow,
                    TotalPages = (int)Math.Ceiling((decimal)totalRow / pageSize)
                };

                var response = request.CreateResponse(HttpStatusCode.OK, paginationSet);
                return response;
            });
        }

        [Route("getallparents")]
        [HttpGet]
        public HttpResponseMessage GetAll(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {  
                var model = _productCategoryService.GetAll();

                var responseData = Mapper.Map<IEnumerable<PRODUCTCATEGORY>, IEnumerable<PRODUCTCATEGORYViewModel>>(model);
                
                var response = request.CreateResponse(HttpStatusCode.OK, responseData);
                return response;
            });
        }

        [Route("getbyid/{id:int}")]
        [HttpGet]
        public HttpResponseMessage GetById(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                var model = _productCategoryService.GetById(id);

                var responseData = Mapper.Map<PRODUCTCATEGORY, PRODUCTCATEGORYViewModel>(model);

                var response = request.CreateResponse(HttpStatusCode.OK, responseData);
                return response;
            });
        }

        [Route("create")]
        [HttpPost]
        [AllowAnonymous]
        public HttpResponseMessage Create(HttpRequestMessage request, PRODUCTCATEGORYViewModel productCategoryVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var newProductCategory = new PRODUCTCATEGORY();
                    newProductCategory.UpdateProductCategory(productCategoryVm);

                    newProductCategory.CREATEDDAY = DateTime.Now;

                    _productCategoryService.Add(newProductCategory);
                    _productCategoryService.Save();

                    var responseData = Mapper.Map<PRODUCTCATEGORY, PRODUCTCATEGORYViewModel>(newProductCategory);

                    response = request.CreateResponse(HttpStatusCode.Created, responseData);
                }
                return response;
            });
        }

        [Route("update")]
        [HttpPut]
        [AllowAnonymous]
        public HttpResponseMessage Update(HttpRequestMessage request, PRODUCTCATEGORYViewModel productCategoryVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var dbProductCategory = _productCategoryService.GetById(productCategoryVm.ID_PRODUCTCATEGORY);
                    dbProductCategory.UpdateProductCategory(productCategoryVm);
                    dbProductCategory.UPDATEDDATE = DateTime.Now;
                    _productCategoryService.Update(dbProductCategory);
                    _productCategoryService.Save();

                    var responseData = Mapper.Map<PRODUCTCATEGORY, PRODUCTCATEGORYViewModel>(dbProductCategory);

                    response = request.CreateResponse(HttpStatusCode.Created, responseData);
                }
                return response;
            });
        }

        [Route("delete")]
        [HttpDelete]
        [AllowAnonymous]
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var oldProductCategory = _productCategoryService.Delete(id);
                    _productCategoryService.Save();

                    var responseData = Mapper.Map<PRODUCTCATEGORY, PRODUCTCATEGORYViewModel>(oldProductCategory);

                    response = request.CreateResponse(HttpStatusCode.Created, responseData);
                }
                return response;
            });
        }

        [Route("deletemulti")]
        [HttpDelete]
        [AllowAnonymous]
        public HttpResponseMessage DeleteMulti(HttpRequestMessage request, string checkedProductCategories)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var lstProductCategory = new JavaScriptSerializer().Deserialize<List<int>>(checkedProductCategories);

                    foreach(var item in lstProductCategory)
                    {
                        _productCategoryService.Delete(item);
                    }
                    
                    _productCategoryService.Save();
                    
                    response = request.CreateResponse(HttpStatusCode.OK, lstProductCategory.Count);
                }
                return response;
            });
        }
    }
}