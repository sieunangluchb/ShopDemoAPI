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

    [RoutePrefix("api/product")]
    [Authorize]
    public class ProductController : ApiControllerBase
    {
        #region Initialize
        private IProductService _productService;

        public ProductController(IErrorService errorService, IProductService productService) : base(errorService)
        {
            this._productService = productService;
        }

        #endregion

        [Route("getall")]
        [HttpGet]
        public HttpResponseMessage GetAll(HttpRequestMessage request, string keyword, int page, int pageSize = 20)
        {
            return CreateHttpResponse(request, () =>
            {
                int totalRow = 0;
                var model = _productService.GetAll(keyword);
                totalRow = model.Count();
                var query = model.OrderByDescending(x => x.CREATEDDAY).Skip(page * pageSize).Take(pageSize);
                var responseData = Mapper.Map<IEnumerable<PRODUCT>, IEnumerable<PRODUCTViewModel>>(query);

                var paginationSet = new PaginationSet<PRODUCTViewModel>()
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
                var model = _productService.GetAll();

                var responseData = Mapper.Map<IEnumerable<PRODUCT>, IEnumerable<PRODUCTViewModel>>(model);

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
                var model = _productService.GetById(id);

                var responseData = Mapper.Map<PRODUCT, PRODUCTViewModel>(model);

                var response = request.CreateResponse(HttpStatusCode.OK, responseData);
                return response;
            });
        }

        [Route("create")]
        [HttpPost]
        [AllowAnonymous]
        public HttpResponseMessage Create(HttpRequestMessage request, PRODUCTViewModel productVm)
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
                    var newProduct = new PRODUCT();
                    newProduct.UpdateProduct(productVm);

                    newProduct.CREATEDDAY = DateTime.Now;
                    newProduct.CREATEDBY = User.Identity.Name;

                    _productService.Add(newProduct);
                    _productService.Save();

                    var responseData = Mapper.Map<PRODUCT, PRODUCTViewModel>(newProduct);

                    response = request.CreateResponse(HttpStatusCode.Created, responseData);
                }
                return response;
            });
        }

        [Route("update")]
        [HttpPut]
        [AllowAnonymous]
        public HttpResponseMessage Update(HttpRequestMessage request, PRODUCTViewModel productVm)
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
                    var dbProduct = _productService.GetById(productVm.ID_PRODUCT);
                    dbProduct.UpdateProduct(productVm);

                    dbProduct.UPDATEDDATE = DateTime.Now;
                    dbProduct.UPDATEDBY = User.Identity.Name;

                    _productService.Update(dbProduct);
                    _productService.Save();

                    var responseData = Mapper.Map<PRODUCT, PRODUCTViewModel>(dbProduct);

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
                    var oldProduct = _productService.Delete(id);
                    _productService.Save();

                    var responseData = Mapper.Map<PRODUCT, PRODUCTViewModel>(oldProduct);

                    response = request.CreateResponse(HttpStatusCode.Created, responseData);
                }
                return response;
            });
        }

        [Route("deletemulti")]
        [HttpDelete]
        [AllowAnonymous]
        public HttpResponseMessage DeleteMulti(HttpRequestMessage request, string checkedProducts)
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
                    var lstProduct = new JavaScriptSerializer().Deserialize<List<int>>(checkedProducts);

                    foreach (var item in lstProduct)
                    {
                        _productService.Delete(item);
                    }

                    _productService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK, lstProduct.Count);
                }
                return response;
            });
        }
    }
}
