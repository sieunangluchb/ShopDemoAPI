using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Models
{
    public class SLIDEViewModel
    {
        public int ID_SLIDE { get; set; }
        
        public string NAME { get; set; }
        
        public string DESCRIPTION { get; set; }
        
        public string IMAGE { get; set; }
        
        public string URL { get; set; }

        public int? DISPLAYORDER { get; set; }
        
        public bool STATUS { get; set; }
    }
}