using AutoMapper;
using ShopDemoAPI.Model.Models;
using ShopDemoAPI.Service;
using ShopDemoAPI.WebApp.Infrastructure.Core;
using ShopDemoAPI.WebApp.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShopDemoAPI.WebApp.Infrastructure.Extensions;
using System;

namespace ShopDemoAPI.WebApp.Api
{
    [RoutePrefix("api/postcategory")]
    [Authorize]
    public class PostCategoryController : ApiControllerBase
    {
        private IPostCategoryService _postCategoryService;

        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) : base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var lstPostCategory = _postCategoryService.GetAll();

                var lstPostCategoryVm = Mapper.Map<List<POSTCATEGORYViewModel>>(lstPostCategory);
                
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, lstPostCategoryVm);
                return response;
            });
        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, POSTCATEGORYViewModel postCategoryVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    POSTCATEGORY newPostCategory = new POSTCATEGORY();
                    newPostCategory.UpdatePostCategory(postCategoryVm);

                    newPostCategory.CREATEDDAY = DateTime.Now;
                    newPostCategory.CREATEDBY = User.Identity.Name;

                    var pCategory = _postCategoryService.Add(newPostCategory);
                    _postCategoryService.Save();

                    response = request.CreateResponse(HttpStatusCode.Created, pCategory);
                }
                return response;
            });
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, POSTCATEGORYViewModel postCategoryVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var postCategoryDb = _postCategoryService.GetById(postCategoryVm.ID_POSTCATEGORY);
                    postCategoryDb.UpdatePostCategory(postCategoryVm);

                    postCategoryDb.UPDATEDDATE = DateTime.Now;
                    postCategoryDb.UPDATEDBY = User.Identity.Name;

                    _postCategoryService.Update(postCategoryDb);
                    _postCategoryService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Delete(id);
                    _postCategoryService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
    }
}