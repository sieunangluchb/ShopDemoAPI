using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Models
{
    public class ORDERDETAILViewModel
    {
        public int ID_ORDER { get; set; }
        
        public int ID_PRODUCT { get; set; }
        
        public int QUANTITY { get; set; }
        
        public virtual ORDERViewModel ORDER { get; set; }
        
        public virtual PRODUCTViewModel PRODUCT { get; set; }
    }
}