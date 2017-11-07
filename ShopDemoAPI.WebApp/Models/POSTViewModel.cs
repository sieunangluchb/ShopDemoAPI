using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Models
{
    public class POSTViewModel
    {
        public int ID_POST { get; set; }
        
        public string NAME { get; set; }
        
        public string ALIAS { get; set; }

        public int? ID_POSTCATEGORY { get; set; }
        
        public string IMAGE { get; set; }
        
        public string DESCRIPTION { get; set; }

        public string CONTENT { get; set; }

        public bool? HOMEFLAG { get; set; }

        public bool? HOTFLAG { get; set; }

        public int? VIEWCOUNT { get; set; }

        public string METAKEYWORD { get; set; }
        
        public string METADESCRIPTION { get; set; }

        public DateTime? CREATEDDAY { get; set; }
        
        public string CREATEDBY { get; set; }

        public DateTime? UPDATEDDATE { get; set; }
        
        public string UPDATEDBY { get; set; }

        public bool STATUS { get; set; }

        public virtual POSTCATEGORYViewModel POSTCATEGORY { get; set; }

        public virtual IEnumerable<POSTTAGViewModel> POSTTAGs { get; set; }
    }
}