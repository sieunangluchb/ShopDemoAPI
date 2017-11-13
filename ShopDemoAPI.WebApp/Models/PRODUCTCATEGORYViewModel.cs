using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Models
{
    public class PRODUCTCATEGORYViewModel
    {
        public int ID_PRODUCTCATEGORY { get; set; }

        [Required]
        public string NAME { get; set; }

        [Required]
        public string ALIAS { get; set; }
        
        public string DESCRIPTION { get; set; }

        public int? PARENT_ID { get; set; }

        public int? DISPLAYORDER { get; set; }
        
        public string IMAGE { get; set; }

        public bool? HOMEFLAG { get; set; }

        public string METAKEYWORD { get; set; }

        public string METADESCRIPTION { get; set; }

        public DateTime? CREATEDDAY { get; set; }

        public string CREATEDBY { get; set; }

        public DateTime? UPDATEDDATE { get; set; }

        public string UPDATEDBY { get; set; }

        [Required]
        public bool STATUS { get; set; }

        public virtual IEnumerable<PRODUCTViewModel> PRODUCTs { get; set; }
    }
}