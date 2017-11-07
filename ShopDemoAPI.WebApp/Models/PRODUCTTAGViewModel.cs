using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Models
{
    public class PRODUCTTAGViewModel
    {
        public int ID_PRODUCT { get; set; }
        
        public string ID_TAG { get; set; }
        
        public virtual PRODUCTViewModel PRODUCT { get; set; }
        
        public virtual TAGViewModel TAGs { get; set; }
    }
}