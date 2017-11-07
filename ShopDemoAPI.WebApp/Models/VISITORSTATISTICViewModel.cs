using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Models
{
    public class VISITORSTATISTICViewModel
    {
        public Guid ID_VISITORSTATISTIC { get; set; }
        
        public DateTime VISITEDDATE { get; set; }
        
        public string IPADDRESS { get; set; }
    }
}