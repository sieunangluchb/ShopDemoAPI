using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Models
{
    public class ORDERViewModel
    {
        public int ID_ORDER { get; set; }
        
        public string CUSTOMERNAME { get; set; }
        
        public string CUSTOMERADDRESS { get; set; }
        
        public string CUSTOMEREMAIL { get; set; }
        
        public string CUSTOMERMOBILE { get; set; }
        
        public string CUSTOMERMESSAGE { get; set; }

        public DateTime? CREATEDDATE { get; set; }
        
        public string CREATEDBY { get; set; }
        
        public string PAYMENTMETHOD { get; set; }
        
        public string PAYMENTSTATUS { get; set; }
        
        public bool STATUS { get; set; }

        public virtual IEnumerable<ORDERDETAILViewModel> ORDERDETAILs { get; set; }
    }
}