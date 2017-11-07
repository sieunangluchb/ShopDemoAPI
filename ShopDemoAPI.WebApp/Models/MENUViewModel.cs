using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Models
{
    public class MENUViewModel
    {
        public int ID_MENU { get; set; }
        
        public string NAME { get; set; }
        
        public string URL { get; set; }

        public int? DISPLAYORDER { get; set; }
        
        public int ID_MENUGROUP { get; set; }
        
        public string TARGET { get; set; }
        
        public bool STATUS { get; set; }
        
        public virtual MENUGROUPViewModel MENUGROUP { get; set; }
    }
}