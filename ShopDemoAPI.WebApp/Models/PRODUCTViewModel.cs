using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Models
{
    public class PRODUCTViewModel
    {
        public int ID_PRODUCT { get; set; }
        
        public string NAME { get; set; }
        
        public string ALIAS { get; set; }

        public int? ID_PRODUCTCATEGORY { get; set; }
        
        public string IMAGE { get; set; }
        
        public string MOREIMAGES { get; set; }

        public decimal PRICE { get; set; }

        public decimal? PROMOTIONPRICE { get; set; }

        public int? WARRANTY { get; set; }
        
        public string DESCRIPTION { get; set; }

        public string CONTENT { get; set; }

        public bool? HOMEFLAG { get; set; }

        public bool? HOTFLAG { get; set; }

        public int? VIEWCOUNT { get; set; }

        public string TAGS { get; set; }

        public string METAKEYWORD { get; set; }

        public string METADESCRIPTION { get; set; }

        public DateTime? CREATEDDAY { get; set; }

        public string CREATEDBY { get; set; }

        public DateTime? UPDATEDDATE { get; set; }

        public string UPDATEDBY { get; set; }

        public bool STATUS { get; set; }

        public virtual PRODUCTCATEGORYViewModel PRODUCTCATEGORY { get; set; }

        public virtual IEnumerable<ORDERDETAILViewModel> ORDERDETAILs { get; set; }

        //public virtual IEnumerable<PRODUCTTAGViewModel> PRODUCTTAGs { get; set; }
    }
}