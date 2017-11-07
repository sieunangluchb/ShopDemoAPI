using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Models
{
    public class MENUGROUPViewModel
    {
        public int ID_MENUGROUP { get; set; }
        
        public string NAME { get; set; }

        public virtual IEnumerable<MENUViewModel> MENUs { get; set; }
    }
}