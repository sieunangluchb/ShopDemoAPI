using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Models
{
    public class SYSTEMCONFIGViewModel
    {
        public int ID_SYSTEMCONFIG { get; set; }
        
        public string CODE { get; set; }
        
        public string VALUESTRING { get; set; }

        public int? VALUEINT { get; set; }
    }
}