using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Models
{
    public class PAGEViewModel
    {
        public int ID_PAGE { get; set; }
        
        public string NAME { get; set; }

        public string CONTENT { get; set; }
        
        public string METAKEYWORD { get; set; }
        
        public string METADESCRIPTION { get; set; }
        
        public bool STATUS { get; set; }
    }
}