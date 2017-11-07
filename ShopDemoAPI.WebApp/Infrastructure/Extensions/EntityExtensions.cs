using ShopDemoAPI.Model.Models;
using ShopDemoAPI.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this POSTCATEGORY postCategory, POSTCATEGORYViewModel postCategoryVm)
        {
            postCategory.ID_POSTCATEGORY = postCategoryVm.ID_POSTCATEGORY;
            postCategory.NAME = postCategoryVm.NAME;
            postCategory.ALIAS = postCategoryVm.ALIAS;
            postCategory.DESCRIPTION = postCategoryVm.DESCRIPTION;
            postCategory.PARENT_ID = postCategoryVm.PARENT_ID;
            postCategory.DISPLAYORDER = postCategoryVm.DISPLAYORDER;
            postCategory.IMAGE = postCategoryVm.IMAGE;
            postCategory.HOMEFLAG = postCategoryVm.HOMEFLAG;
            postCategory.METAKEYWORD = postCategoryVm.METAKEYWORD;
            postCategory.METADESCRIPTION = postCategoryVm.METADESCRIPTION;
            postCategory.CREATEDDAY = postCategoryVm.CREATEDDAY;
            postCategory.CREATEDBY = postCategoryVm.CREATEDBY;
            postCategory.UPDATEDDATE = postCategoryVm.UPDATEDDATE;
            postCategory.UPDATEDBY = postCategoryVm.UPDATEDBY;
            postCategory.STATUS = postCategoryVm.STATUS;
        }

        public static void UpdatePost(this POST post, POSTViewModel postVm)
        {
            post.ID_POST = postVm.ID_POST;
            post.NAME = postVm.NAME;
            post.ALIAS = postVm.ALIAS;
            post.ID_POSTCATEGORY = postVm.ID_POSTCATEGORY;
            post.IMAGE = postVm.IMAGE;
            post.DESCRIPTION = postVm.DESCRIPTION;
            post.CONTENT = postVm.CONTENT;
            post.HOMEFLAG = postVm.HOMEFLAG;
            post.HOTFLAG = postVm.HOTFLAG;
            post.VIEWCOUNT = postVm.VIEWCOUNT;
            post.METAKEYWORD = postVm.METAKEYWORD;
            post.METADESCRIPTION = postVm.METADESCRIPTION;
            post.CREATEDDAY = postVm.CREATEDDAY;
            post.CREATEDBY = postVm.CREATEDBY;
            post.UPDATEDDATE = postVm.UPDATEDDATE;
            post.UPDATEDBY = postVm.UPDATEDBY;
            post.STATUS = postVm.STATUS;
        }
    }
}