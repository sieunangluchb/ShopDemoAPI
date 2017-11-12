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
    }
}