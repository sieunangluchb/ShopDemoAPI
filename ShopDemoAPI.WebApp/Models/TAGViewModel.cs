using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Models
{
    public class TAGViewModel
    {
        public string ID_TAG { get; set; }
        
        public string NAME { get; set; }
        
        public string TYPE { get; set; }

        public virtual IEnumerable<POSTTAGViewModel> POSTTAGs { get; set; }

        public virtual IEnumerable<PRODUCTTAGViewModel> PRODUCTTAGs { get; set; }
    }
}