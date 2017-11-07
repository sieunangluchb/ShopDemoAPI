using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Models
{
    public class POSTTAGViewModel
    {
        public int ID_POST { get; set; }
        
        public string ID_TAG { get; set; }
        
        public virtual POSTViewModel POST { get; set; }
        
        public virtual TAGViewModel TAG { get; set; }
    }
}