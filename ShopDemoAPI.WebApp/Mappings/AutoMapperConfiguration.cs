using AutoMapper;
using ShopDemoAPI.Model.Models;
using ShopDemoAPI.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {

            Mapper.Initialize(cfg => {
                cfg.CreateMap<ERROR, ERRORViewModel>();
                cfg.CreateMap<FOOTER, FOOTERViewModel>();
                cfg.CreateMap<MENUGROUP, MENUGROUPViewModel>();
                cfg.CreateMap<MENU, MENUViewModel>();
                cfg.CreateMap<ORDERDETAIL, ORDERDETAILViewModel>();
                cfg.CreateMap<ORDER, ORDERViewModel>();
                cfg.CreateMap<PAGE, PAGEViewModel>();
                cfg.CreateMap<POSTCATEGORY, POSTCATEGORYViewModel>();
                cfg.CreateMap<POSTTAG, POSTTAGViewModel>();
                cfg.CreateMap<POST, POSTViewModel>();
                cfg.CreateMap<PRODUCTCATEGORY, PRODUCTCATEGORYViewModel>();
                cfg.CreateMap<PRODUCTTAG, PRODUCTTAGViewModel>();
                cfg.CreateMap<PRODUCT, PRODUCTViewModel>();
                cfg.CreateMap<SLIDE, SLIDEViewModel>();
                cfg.CreateMap<SUPPORTONLINE, SUPPORTONLINEViewModel>();
                cfg.CreateMap<SYSTEMCONFIG, SYSTEMCONFIGViewModel>();
                cfg.CreateMap<TAG, TAGViewModel>();
                cfg.CreateMap<VISITORSTATISTIC, VISITORSTATISTICViewModel>();
            });
        }
    }
}